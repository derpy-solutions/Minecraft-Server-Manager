using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Text.RegularExpressions;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Reflection;

namespace Minecraft_Server_Manager
{
    public partial class Main
    {
        Loop loop;
        Thread loopThread;

        public class Loop
        {
            public static bool processingChanges;
            public static bool updatesFound;
            public static bool installPopUp;
            public event EventHandler<Changes> LoopUpdate;

            public void Update(Changes e)
            {
                if (LoopUpdate != null)
                {
                    LoopUpdate(this, e);
                }
            }

            public void Run()
            {
                while (G.running)
                {
                    List<ServerUpdate> servers = new List<ServerUpdate>();
                    var update = false;

                    if (GitHub.CheckForUpdates())
                    {
                        updatesFound = true;
                    }

                    if (GitHub.setupPID > 0)
                    {
                        if (!G.ProcessExists(GitHub.setupPID))
                        {
                            installPopUp = true;
                        }
                    }

                    if (!Loop.processingChanges)
                    {
                        foreach (Server server in G.Servers)
                        {
                            if (server.TrackLog())
                            {
                                servers.Add(new ServerUpdate() { server = server, method = "refresh" });
                                update = true;
                            }

                            if (!server.IsRunning())
                            {
                                servers.Add(new ServerUpdate() { server = server, method = "closed" });
                                update = true;
                            }
                        }

                        if (update)
                        {
                            Update(new Changes(servers));
                        }

                        if (updatesFound || (!GitHub.UI_Updated && Main.initialized))
                        {
                            Update(new Changes(null, true));
                        }

                        if (installPopUp)
                        {
                            Update(new Changes(null, false, true));
                            installPopUp = false;
                        }
                    }

                    Thread.Sleep(250);
                }
            }
        }
        public class Changes : EventArgs
        {
            public bool updatesFound;
            public bool installPopUp;
            public List<ServerUpdate> Servers { get; set; }

            public Changes(List<ServerUpdate> servers = null, bool updatestatus = false, bool installpop = false)
            {
                Servers = servers;
                updatesFound = updatestatus;
                installPopUp = installpop;
        }
        }
        public class ServerUpdate
        {
            public Server server { get; set; }
            public string method { get; set; }
        }
        private void OnChange(object sender, Changes e)
        {
            Loop.processingChanges = true;
            if (this.InvokeRequired)
            {
                this.BeginInvoke((MethodInvoker)delegate
                {
                    OnChange(sender, e);
                });
                return;
            }

            if (e.Servers != null)
            {
                foreach (ServerUpdate update in e.Servers)
                {
                    switch (update.method)
                    {
                        case "refresh":
                            update.server.Update();
                            break;

                        case "closed":
                            update.server.Dispose();
                            break;
                    }
                }
            }

            if (e.updatesFound)
            {
                GitHub.UpdateUI();
            }

            if (e.installPopUp)
            {
                MyControls.Main.restartPopUp.Show();
                GitHub.setupPID = 0;
            }

            Loop.processingChanges = false;
        }

        public void InitializeLoop()
        {
            loop = new Loop();
            loop.LoopUpdate += new EventHandler<Changes>(OnChange);
            loopThread = new Thread(new ThreadStart(loop.Run));
            loopThread.Start();
        }
    }
}