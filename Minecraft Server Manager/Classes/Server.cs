using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Drawing.Text;
using System.Xml;
using System.Xml.Linq;
using System.Diagnostics;


namespace Minecraft_Server_Manager
{
    public class Server
    {
        public string name { get; set; }
        public string path { get; set; }
        public int status { get; set; }
        public string version { get; set; }
        public string window { get; set; }
        public int listIndex { get; set; }
        public int pid { get; set; }
        public int port { get; set; }
        public string ini { get; set; }
        public DateTime starttime { get; set; }
        public int readLines { get; set; }
        public class ServerIni
        {
            public int status { get; set; }
            public int pid { get; set; }
            public int port { get; set; }
            public string name { get; set; }
            public void Create(string file)
            {
                if (File.Exists(file))
                {
                    var ini = new IniFile(file);

                    if (ini.KeyExists("status"))
                    {
                        status = int.Parse(ini.Read("status"));
                    }
                    else
                    {
                        status = -1;
                    }

                    if (ini.KeyExists("pid"))
                    {
                        pid = int.Parse(ini.Read("pid"));
                    }
                    else
                    {
                        pid = -1;
                    }

                    if (ini.KeyExists("port"))
                    {
                        port = int.Parse(ini.Read("port"));
                    }
                    else
                    {
                        port = -1;
                    }

                    if (ini.KeyExists("name"))
                    {
                        name = ini.Read("name");
                    }
                    else
                    {
                        name = "A Server";
                    }
                }
            }
        }
        public List<string> players = new List<string>();
        public Custom_Controls.ServerCard serverCard;

        public class Settings
        {
            public string Path;
            public int RAM_Amount = 4;
            public string RAM_Unit = "GB";
            public string Version = "1.18.1";
            public bool Show_UI = false;
            public bool loaded = false;
            public void Load(bool force = false)
            {
                if (!loaded || force)
                {
                    Console.WriteLine("Load Settings: " + Path);
                    string xmlFileName = Path + @"\MSM.xml";
                    if (File.Exists(xmlFileName))
                    {
                        XDocument xdoc = XDocument.Load(xmlFileName);

                        foreach (XElement server in xdoc.Descendants("Server"))
                        {
                            var v1 = server.Element("RAM_Amount")?.Value;
                            if (v1 != null)
                            {
                                RAM_Amount = int.Parse(v1);
                            }

                            var v2 = server.Element("RAM_Unit")?.Value;
                            if (v2 != null)
                            {
                                RAM_Unit = v2;
                            }

                            var v3 = server.Element("Version")?.Value;
                            if (v3 != null)
                            {
                                Version = v3;
                            }

                            var v4 = server.Element("Show_UI")?.Value;
                            if (v4 != null)
                            {
                                Show_UI = bool.Parse(v4);
                            }
                        }
                    }
                    else
                    {
                        Save();
                    }

                    loaded = true;
                }
            }
            public void Save()
            {
                Console.WriteLine("Saving Server Properties...");
                string xmlFileName = Path + @"\MSM.xml";
                XmlWriterSettings settings = new XmlWriterSettings();
                settings.Indent = true;
                settings.IndentChars = ("\t");
                settings.OmitXmlDeclaration = true;

                using (XmlWriter writer = XmlWriter.Create(xmlFileName, settings))
                {
                    writer.WriteStartElement("Servers");

                    writer.WriteStartElement("Server");
                    writer.WriteElementString("RAM_Amount", RAM_Amount.ToString());
                    writer.WriteElementString("RAM_Unit", RAM_Unit.ToString());
                    writer.WriteElementString("Version", Version.ToString());
                    writer.WriteElementString("Show_UI", Show_UI.ToString());
                    writer.WriteEndElement();

                    writer.WriteEndElement();
                    writer.Flush();
                }
            }
        }
        public Settings settings = new Settings();
        public void Create()
        {
            Console.WriteLine("Add Server: " + name);
            starttime = DateTime.Now;
            serverCard = new Custom_Controls.ServerCard(this);
            MyControls.Servers.ServerCardsArea.Controls.Add(serverCard);
            settings.Load();

            Update();
            G.Servers.Add(this);        
        }
        public void Start()
        {
            Create();

            if (File.Exists(Properties.Settings.Default.ServerPath + @"\" + name + @"\logs\latest.log"))
            {
                File.Delete(Properties.Settings.Default.ServerPath + @"\" + name + @"\logs\latest.log");
            }

            string cmd = Properties.Settings.Default.cmdCommand;

            switch (settings.RAM_Unit)
            {
                case "GB":
                    cmd = "-Xmx" + settings.RAM_Amount + "G " + cmd;
                    break;

                case "MB":
                    cmd = "-Xmx" + settings.RAM_Amount + "M " + cmd;
                    break;
            }

            if (!settings.Show_UI)
            {
                cmd = cmd + " --nogui";
            }

            var c = new Command()
            {
                name = '"' + name + '"',
                pid = 0,
                serverpath = '"' + Properties.Settings.Default.ServerPath + '"',
                datapath = '"' + Properties.Settings.Default.DataPath + '"',
                javapath = '"' + Properties.Settings.Default.JavaPath + '"',
                command = "StartServer",
                arguments = '"' + cmd + '"',
            };
            c.Run();
        }
        public void Update()
        {
            Console.WriteLine("Update Server Card & Status!");
            if (serverCard != null)
            {
                switch (status)
                {
                    case 1:
                        serverCard.sStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(156)))), ((int)(((byte)(56)))));
                        serverCard.sStatus.Text = Main.rm.GetString("Server_Started"); 
                        break;

                    case 2:
                        serverCard.sStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(255)))), ((int)(((byte)(250)))));
                        serverCard.sStatus.Text = Main.rm.GetString("Server_Loading");
                        break;

                    case 3:
                        serverCard.sStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(215)))), ((int)(((byte)(16)))));
                        var port = this.port.ToString();
                        if (port.Length > 2)
                        {
                            port = port.Remove(0, 3);
                        }

                        serverCard.sStatus.Text = Main.rm.GetString("Server_Online")  + " Port #" + port;
                        break;

                    case 4:
                        serverCard.sStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(41)))), ((int)(((byte)(12)))));
                        serverCard.sStatus.Text = Main.rm.GetString("Server_Shutdown");
                        break;

                    default:
                        // code block
                        break;
                }

                serverCard.sName.Text = name;
                serverCard.sPlayers.Items.Clear();
                players.Sort();


                List<Control> controls = new List<Control>();
                controls.Add(serverCard.command_GameMode1.Player);
                controls.Add(serverCard.command_Teleport1.Player_Target);
                controls.Add(serverCard.command_Teleport1.Player_Destination);
                controls.Add(serverCard.command_Kick1.Player);


                foreach (ComboBox ctrl in controls)
                {
                    if (ctrl.SelectedItem != null && (!players.Contains(ctrl.SelectedItem.ToString()) || ctrl.SelectedItem.ToString() == "" || ctrl.SelectedItem.ToString() == Main.rm.GetString("Player")))
                    {
                        ctrl.SelectedItem = null;
                    }

                    if (ctrl.Items.Contains(Main.rm.GetString("Player")))
                    {
                        ctrl.Items.Remove(Main.rm.GetString("Player"));
                    }
                }


                foreach (string player in players)
                {
                    //Console.WriteLine("[" + DateTime.Now +"]: " +player);
                    serverCard.sPlayers.Items.Add(player);

                    foreach (ComboBox ctrl in controls)
                    {
                        if (!ctrl.Items.Contains(player))
                        {
                            Console.WriteLine("Add " + player + " to control '" + ctrl.Name + "'");
                            ctrl.Items.Add(player);
                        }

                        if (ctrl.SelectedItem == null || ctrl.SelectedItem.ToString() == "")
                        {
                            ctrl.SelectedItem = player;
                        }
                    }
                }


                foreach (ComboBox ctrl in controls)
                {
                    List<string> delete = new List<string>();

                    foreach (string name in ctrl.Items)
                    {
                        if (!serverCard.sPlayers.Items.Contains(name))
                        {
                            delete.Add(name);
                        }
                    }

                    foreach (string name in delete)
                    {
                        ctrl.Items.Remove(name);
                    }

                    if (ctrl.SelectedItem == null)
                    {
                        ctrl.Items.Add(Main.rm.GetString("Player"));
                        ctrl.SelectedItem = Main.rm.GetString("Player");
                    }
                }
            }
        }
        public void Kick()
        {
            Command command = new Command()
            {
                name = '"' + name + '"',
                pid = pid,
                serverpath = '"' + Properties.Settings.Default.ServerPath + '"',
                datapath = '"' + Properties.Settings.Default.DataPath + '"',
                javapath = '"' + Properties.Settings.Default.JavaPath + '"',
                command = "Custom",
                arguments = '"' + "kick " + serverCard.command_Kick1.Player.SelectedItem.ToString() + '"'
            };

            command.Run();
        }
        public void GameMode()
        {
            var mode = "";
            switch (serverCard.command_GameMode1.GameMode.SelectedItem.ToString())
            {
                case "Kreativ Modus":
                    mode = "creative";
                    break;
                case "Überleben Modus":
                    mode = "survival";
                    break;
                case "Abenteuer Modus":
                    mode = "adventure";
                    break;
                case "Zuschauer Modus":
                    mode = "spectator";
                    break;
                case "Creative Mode":
                    mode = "creative";
                    break;
                case "Survival Mode":
                    mode = "survival";
                    break;
                case "Adventure Mode":
                    mode = "adventure";
                    break;
                case "Spectator Mode":
                    mode = "spectator";
                    break;
            }
            if (mode != "")
            {
                Command command = new Command()
                {
                    name = '"' + name + '"',
                    pid = pid,
                    serverpath = '"' + Properties.Settings.Default.ServerPath + '"',
                    datapath = '"' + Properties.Settings.Default.DataPath + '"',
                    javapath = '"' + Properties.Settings.Default.JavaPath + '"',
                    command = "Custom",
                    arguments = '"' + "gamemode " + mode + " " + serverCard.command_GameMode1.Player.SelectedItem.ToString() + '"'
                };

                command.Run();
            }
        }
        public void Teleport()
        {
            Command command = new Command()
            {
                name = '"' + name + '"',
                pid = pid,
                serverpath = '"' + Properties.Settings.Default.ServerPath + '"',
                datapath = '"' + Properties.Settings.Default.DataPath + '"',
                javapath = '"' + Properties.Settings.Default.JavaPath + '"',
                command = "Custom",
                arguments = '"' + "tp " + serverCard.command_Teleport1.Player_Target.SelectedItem.ToString() + " " + serverCard.command_Teleport1.Player_Destination.SelectedItem.ToString() + '"'
            };

            command.Run();
        }
        public void CustomCommand()
        {
            Command command = new Command()
            {
                name = '"' + name + '"',
                pid = pid,
                serverpath = '"' + Properties.Settings.Default.ServerPath + '"',
                datapath = '"' + Properties.Settings.Default.DataPath + '"',
                javapath = '"' + Properties.Settings.Default.JavaPath + '"',
                command = "Custom",
                arguments = '"' + serverCard.sCustomCommand.Text + '"'
            };

            command.Run();
        }
        public void Stop()
        {
            Command command = new Command()
            {
                name = '"' + name + '"',
                pid = pid,
                serverpath = '"' + Properties.Settings.Default.ServerPath + '"',
                datapath = '"' + Properties.Settings.Default.DataPath + '"',
                javapath = '"' + Properties.Settings.Default.JavaPath + '"',
                command = "Stop",
                arguments = '"' + "stop" + '"'
            };

            
            command.Run();
            if (G.ProcessExists(pid)) {
            var p = Process.GetProcessById(pid);
                if (p != null)
                {
                    p.Close();
                }
            }
        }
        public void ReadIni(string path = null)
        {
            if (path != null)
            {
                ini = path;
            }

            var MyIni = new ServerIni();
            MyIni.Create(ini);

            name = MyIni.name;
            pid = MyIni.pid;
            status = MyIni.status;
            port = MyIni.port;
        }
        public bool TrackLog()
        {

            //Tracks Players and Status
            var changed = false;
            var path = Properties.Settings.Default.ServerPath + @"\" + name + @"\logs\latest.log";
            var exists = File.Exists(path);
            if (exists)
            {
                using (Stream stream = File.Open(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                {
                    using (StreamReader reader = new StreamReader(stream))
                    {
                        string line = null;
                        for (int j = 0; j < readLines; ++j)
                        {
                            reader.ReadLine();
                        }

                        while ((line = reader.ReadLine()) != null)
                        {
                            readLines++;

                            if (line.Contains("joined the game"))
                            {
                                string sName = Regex.Replace(line, ".*: ", "");
                                sName = Regex.Replace(sName, " joined the game", "");
                                //changed = true;

                                if (!players.Contains(sName))
                                {
                                    Console.WriteLine("[" + DateTime.Now + "]: " + sName + " ist dem Spiel beigetreten!");
                                    players.Add(sName);
                                    changed = true;
                                }
                            }
                            else if (line.Contains("left the game"))
                            {
                                string sName = Regex.Replace(line, ".*: ", "");
                                sName = Regex.Replace(sName, " left the game", "");
                                //changed = true;

                                if (players.Contains(sName))
                                {
                                    Console.WriteLine("[" + DateTime.Now + "]: " + sName + " hat das Spiel verlassen!");
                                    players.Remove(sName);
                                    changed = true;
                                }
                            }
                            else if (line.Contains("For help, type") && status != 3)
                            {
                                status = 3;

                                if (ini != null && File.Exists(ini))
                                {
                                    var MyIni = new IniFile(ini);
                                    MyIni.Write("Status", status.ToString());
                                    ReadIni();
                                    changed = true;
                                }
                            }
                        }
                    }
                }
            }

            if (!changed && status == 1 && exists && this.ini != null && status != 2)
            {
                ReadIni();

                if (File.Exists(this.ini))
                {
                    status = 2;
                    var MyIni = new IniFile(this.ini);
                    MyIni.Write("Status", status.ToString());

                    changed = true;
                }
            }

            if (File.Exists(Properties.Settings.Default.DataPath + @"\Status Updates\update\" + name + ".ini"))
            {
                changed = true;
                File.Delete(Properties.Settings.Default.DataPath + @"\Status Updates\update\" + name + ".ini");
            }

            return changed;
        }
        public bool IsRunning()
        {
            return ini == null || (pid == -1 && (DateTime.Now.Subtract(starttime).TotalMilliseconds < 10000)) || G.ProcessExists(pid) && File.Exists(ini);
        }
        public void Dispose()
        {
            Console.WriteLine("Dispose Server '" + name + "'");

            var c = new Command()
            {
                name = '"' + name + '"',
                pid = pid,
                serverpath = '"' + Properties.Settings.Default.ServerPath + '"',
                datapath = '"' + Properties.Settings.Default.DataPath + '"',
                javapath = '"' + Properties.Settings.Default.JavaPath + '"',
                command = "Stop"
            };

            c.Run();

            if (ini != null)
            {
                File.Delete(ini);
            }

            if (serverCard != null)
            {
                serverCard.Dispose();
            }

            for (int i = G.Servers.Count - 1; i >= 0; i--)
            {
                var s = G.Servers[i];

                if (s.name == name && s.pid == pid)
                {
                    G.Servers.RemoveAt(i);
                }
            }
        }
    }
}
