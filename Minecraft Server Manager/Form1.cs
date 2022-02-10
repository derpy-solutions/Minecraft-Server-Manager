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
    public partial class Form1 : Form
    {
        public class IniFile   // revision 11
        {
            string Path;
            string EXE = Assembly.GetExecutingAssembly().GetName().Name;

            [DllImport("kernel32", CharSet = CharSet.Unicode)]
            static extern long WritePrivateProfileString(string Section, string Key, string Value, string FilePath);

            [DllImport("kernel32", CharSet = CharSet.Unicode)]
            static extern int GetPrivateProfileString(string Section, string Key, string Default, StringBuilder RetVal, int Size, string FilePath);

            public IniFile(string IniPath = null)
            {
                Path = new FileInfo(IniPath ?? EXE + ".ini").FullName;
            }

            public string Read(string Key, string Section = null)
            {
                var RetVal = new StringBuilder(255);
                GetPrivateProfileString(Section ?? EXE, Key, "", RetVal, 255, Path);
                return RetVal.ToString();
            }

            public void Write(string Key, string Value, string Section = null)
            {
                WritePrivateProfileString(Section ?? EXE, Key, Value, Path);
            }

            public void DeleteKey(string Key, string Section = null)
            {
                Write(Key, null, Section ?? EXE);
            }

            public void DeleteSection(string Section = null)
            {
                Write(null, null, Section ?? EXE);
            }

            public bool KeyExists(string Key, string Section = null)
            {
                return Read(Key, Section).Length > 0;
            }
        }

        Loop loop;
        Thread loopThread;

        public Form1()
        {
            InitializeComponent();
            if (GitHub.Run.UpdateAvailable())
            {
                this.UpdateNotification.Image = Properties.Resources.circle_exclamationmark_red;
                this.toolTip1.SetToolTip(this.UpdateNotification, "There is an update update available!" + Environment.NewLine + "Current: " + G.Ver.current.ToString() + Environment.NewLine + "Newest: " + G.Ver.newest.ToString());
            }
            else
            {
                this.UpdateNotification.Image = Properties.Resources.circle_checkmark_green;
                this.toolTip1.SetToolTip(this.UpdateNotification, "No update available." + Environment.NewLine + "Current: " + G.Ver.current.ToString() + Environment.NewLine + "Newest: " + G.Ver.newest.ToString());
            }


            G.CardPanel = flowLayoutPanel1;
            G.serverList = serverListView;

            var serverPath = einstellungen.Controls["textBox1"];
            var dataPath = einstellungen.Controls["textBox2"];
            var cmdCommand = einstellungen.Controls["textBox3"];
            var javaPath = einstellungen.Controls["textBox4"];

            if (Properties.Settings.Default.DataPath.ToString() == "" || Properties.Settings.Default.ServerPath.ToString() == "")
            {
                Properties.Settings.Default.ServerPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Minecraft Server Manager";
                Properties.Settings.Default.DataPath = @"C:\Program Files\derpy Solutions\Minecraft Server Manager\Data";
                Properties.Settings.Default.Save();

                einstellungenTab_Click();
            }

            serverPath.Text = Properties.Settings.Default.ServerPath.ToString();
            dataPath.Text = Properties.Settings.Default.DataPath.ToString();
            cmdCommand.Text = Properties.Settings.Default.cmdCommand.ToString();
            javaPath.Text = Properties.Settings.Default.JavaPath.ToString();


            Directory.CreateDirectory(Properties.Settings.Default.ServerPath);
            Directory.CreateDirectory(Properties.Settings.Default.DataPath);
            Initialize();
            SetFonts();

            loop = new Loop();
            loop.LoopUpdate += new EventHandler<Changes>(OnChange);
            loopThread = new Thread(new ThreadStart(loop.Run));
            loopThread.Start();
        }

        private void SetFonts()
        {
            // Main Window
            this.label1.Font = G.defaultHeaderFont;
            this.FilterInput.Font = G.defaultTextFont;
            this.serverListView.Font = G.defaultTextFont;
            this.NewServer.Font = G.defaultButtonFont;
            this.StartServer.Font = G.defaultButtonFont;
        }

        public class Loop
        {
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
                    Thread.Sleep(2500);
                }
            }
        }
        public class Changes : EventArgs
        {
            public List<ServerUpdate> Servers { get; set; }

            public Changes(List<ServerUpdate> servers)
            {
                Servers = servers;
            }
        }
        public class ServerUpdate
        {
            public Server server { get; set; }
            public string method { get; set; }
        }
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

        private void OnChange(object sender, Changes e)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke((MethodInvoker)delegate
                {
                    OnChange(sender, e);
                });
                return;
            }

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

        public static bool ProcessExists(int id)
        {
            return Process.GetProcesses().Any(x => x.Id == id);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormClosing += Form1_FormClosing;
            this.Location = Properties.Settings.Default.Position;
            this.Size = Properties.Settings.Default.Size;

        }

        private void Form1_FormClosing(Object sender, FormClosingEventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                Console.WriteLine("Store Pos and Size");
                // save location and size if the state is normal
                Properties.Settings.Default.Position = this.Location;
                Properties.Settings.Default.Size = this.Size;
            }
            else
            {
                Console.WriteLine("Store Restore Pos and Size");
                // save the RestoreBounds if the form is minimized or maximized!
                Properties.Settings.Default.Position = this.RestoreBounds.Location;
                Properties.Settings.Default.Size = this.RestoreBounds.Size;
            }

            Properties.Settings.Default.Save();

            G.running = false;
        }

        private List<string> getIniFiles(int category = 1)
        {
            string[] fileArray = { };
            switch (category)
            {
                case 1:
                    {
                        fileArray = Directory.GetFiles(Properties.Settings.Default.DataPath.ToString() + @"\Status Updates", "*.ini");
                        break;
                    }
                case 2:
                    {
                        fileArray = Directory.GetFiles(Properties.Settings.Default.DataPath + @"\Status Updates\update", "*.ini");
                        break;
                    }
                default:
                    {
                        break;
                    }
            }

            List<string> files = fileArray.ToList();
            return files;
        }

        public void Initialize()
        {
            Console.WriteLine("[" + DateTime.Now + "]: " + "Initialize...");

            foreach (string file in getIniFiles())
            {
                var ini = new ServerIni();
                ini.Create(file);

                if (ini.pid != -1 && ProcessExists(ini.pid) && Process.GetProcessById(ini.pid).ProcessName == "cmd")
                {
                    var server = new Server();
                    server.ReadIni(file);
                    server.Create();
                }
                else
                {
                    Console.WriteLine("[" + DateTime.Now + "]: Process " + ini.pid + " from " + ini.name + " no longer exist. Wipe file " + file);
                    File.Delete(file);
                }
            }

            RefreshServerList();

            //set Tooltips
            this.toolTip1.SetToolTip(this.serverListTab, "Wechsel zu der Server Liste!");
            this.toolTip1.SetToolTip(this.einstellungenTab, "Wechsel zu den Einstellungen!");
            this.toolTip1.SetToolTip(this.StartServer, "Starte den ausgewählten Server!");
            this.toolTip1.SetToolTip(this.FilterInput, "Gib einen Namen ein!");
            this.toolTip1.SetToolTip(this.NewServer, "Erstelle einen neuen Server mit dem eingegebenen Namen!");
            this.toolTip1.SetToolTip(this.serverListView, "Alle deine Server!");
        }

        public void RefreshServerList()
        {
            var serverPath = Properties.Settings.Default.ServerPath.ToString() + @"\";
            G.ServerFolders = Directory.GetDirectories(serverPath);
            G.ServerFoldersList.Clear();

            for (int i = 0; i < G.ServerFolders.Length; i++)
            {
                string sName = Regex.Replace(G.ServerFolders[i], @".*\\", "");
                G.ServerFoldersList.Add(sName);
            }

            this.serverListView.Items.Clear();

            foreach (string server in G.ServerFoldersList)
            {
                if (server.Contains(this.FilterInput.Text, StringComparison.OrdinalIgnoreCase))
                {
                    this.serverListView.Items.Add(server);
                    //Console.WriteLine("[" + DateTime.Now +"]: " +server);
                }
            }
        }

        private void serverListTab_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.cmdCommand.ToString() != "" && Properties.Settings.Default.DataPath.ToString() != "" && Properties.Settings.Default.ServerPath.ToString() != "")
            {
                this.einstellungen.Hide();

                this.einstellungenTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
                this.einstellungenTab.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
                this.einstellungenTab.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
                this.einstellungenTab.FlatAppearance.BorderSize = 1;

                this.serverListTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
                this.serverListTab.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
                this.serverListTab.FlatAppearance.BorderSize = 0;
            }
        }

        public void einstellungenTab_Click(object sender = null, EventArgs e = null)
        {
            this.einstellungen.Show();

            this.serverListTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.serverListTab.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.serverListTab.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.serverListTab.FlatAppearance.BorderSize = 1;

            this.einstellungenTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.einstellungenTab.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.einstellungenTab.FlatAppearance.BorderSize = 0;
        }

        private void StartServer_Click_1(object sender, EventArgs e)
        {
            if (this.serverListView.SelectedItem != null)
            {
                var running = false;

                foreach (Server rServ in G.Servers)
                {
                    if (rServ.name == this.serverListView.SelectedItem.ToString())
                    {
                        running = true;
                        break;
                    }
                }

                if (!running)
                {

                    var c = new Command()
                    {
                        name = '"' + this.serverListView.SelectedItem.ToString() + '"',
                        pid = 0,
                        serverpath = '"' + Properties.Settings.Default.ServerPath + '"',
                        datapath = '"' + Properties.Settings.Default.DataPath + '"',
                        javapath = '"' + Properties.Settings.Default.JavaPath + '"',
                        command = "StartServer",
                        arguments = '"' + Properties.Settings.Default.cmdCommand + '"',
                    };
                    c.Run();


                    var server = new Server();
                    server.name = this.serverListView.SelectedItem.ToString();
                    server.pid = -1;
                    server.status = 1;
                    server.port = -1;
                    server.ini = Properties.Settings.Default.DataPath + @"\Status Updates\" + server.name + ".ini";
                    server.Create();

                    var MyIni = new IniFile(server.ini);
                    MyIni.Write("Name", server.name);
                    MyIni.Write("Status", server.status.ToString());
                    MyIni.Write("PID", server.pid.ToString());
                    MyIni.Write("Port", server.pid.ToString());
                }
            }
            else
            {
                //var serv = G.Servers[G.Servers.Count-1];
                //serv.name = "some new name";
                //serv.Update();
            }
        }

        private void FilterInput_TextChanged(object sender, EventArgs e)
        {
            RefreshServerList();
        }

        private void NewServer_Click(object sender, EventArgs e)
        {

            var name = FilterInput.Text;
            if (name != "" && !G.ServerFoldersList.Contains(name))
            {
                Console.WriteLine("[" + DateTime.Now + "]: " + "add Server: " + name);
                Dir.Copy(Properties.Settings.Default.DataPath.ToString() + @"\ServerSource", Properties.Settings.Default.ServerPath.ToString() + @"\" + name);
                RefreshServerList();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (ModifierKeys.HasFlag(Keys.Control))
            {
            }
            else
            {
            }
        }
    }
}