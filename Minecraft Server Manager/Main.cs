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
using System.Drawing;

namespace Minecraft_Server_Manager
{
    public partial class Main : Form
    {
        public static System.Resources.ResourceManager rm = new System.Resources.ResourceManager("Minecraft_Server_Manager.de_local", Assembly.GetExecutingAssembly());

        public static bool initialized;
        public Main()
        {
            switch (Properties.Settings.Default.Language)
            {
                case "EN":
                    rm = new System.Resources.ResourceManager("Minecraft_Server_Manager.en_local", Assembly.GetExecutingAssembly());
                    break;

                case "DE":
                    rm = new System.Resources.ResourceManager("Minecraft_Server_Manager.de_local", Assembly.GetExecutingAssembly());
                    break;
            }
            Console.WriteLine("Creative: " + rm.GetString("Creative"));

#if DEBUG
            Console.WriteLine("DEBUG");
#else
                Console.WriteLine("RELEASE");
#endif

            Console.WriteLine("Main Tick - Init");

            if (Properties.Settings.Default.DataPath.ToString() == "" || Properties.Settings.Default.ServerPath.ToString() == "")
            {
                Properties.Settings.Default.ServerPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Minecraft Server Manager";
                Properties.Settings.Default.DataPath = @"C:\Program Files\derpy Solutions\Minecraft Server Manager\Data";
                Properties.Settings.Default.Save();
            }
            Directory.CreateDirectory(Properties.Settings.Default.ServerPath);
            Directory.CreateDirectory(Properties.Settings.Default.DataPath);


            InitializeComponent();
            MyControls.Main = this;
            MyControls.SideBar = sideBar1;
            MyControls.Settings = SettingsTab;
            MyControls.Servers = ServersTab;
            MyControls.FavoritesMenu = new Custom_Controls.FavoritesMenu();
            MyControls.FavoritesMenu.Hide();

            if (G.Favorites == null)
            {
                G.Favorites = MyControls.FavoritesMenu;
            }


            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
            System.Diagnostics.FileVersionInfo fvi = System.Diagnostics.FileVersionInfo.GetVersionInfo(assembly.Location);
            string version = fvi.FileVersion;
            Console.WriteLine(version);
            G.Ver.current = Version.Parse(version);

            MyControls.SideBar.CurrentVersion.Text = G.Ver.current.ToString();

            FavoriteCommands.Load();

            Loops loops = new Loops();
            loops.InitializeLoop();

            foreach (Action action in Inits.Voids)
            {
                action();
            }

            if (!Fonts.IsFontInstalled("Century Gothic"))
            {
                Fonts.InstallFont(Properties.Settings.Default.DataPath + @"\Fonts\CenturyGothic_Bold.ttf");
                Fonts.InstallFont(Properties.Settings.Default.DataPath + @"\Fonts\CenturyGothic_Bold_Italic.ttf");
                Fonts.InstallFont(Properties.Settings.Default.DataPath + @"\Fonts\CenturyGothic_Italic.ttf");
                Fonts.InstallFont(Properties.Settings.Default.DataPath + @"\Fonts\CenturyGothic_Regular.ttf");

                var path = Environment.GetFolderPath(Environment.SpecialFolder.CommonStartMenu);
                MyControls.Main.restartPopUp.Show();
            }

            Initialize();
            initialized = true;
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
                var ini = new Server.ServerIni();
                ini.Create(file);

                if (ini.pid != -1 && G.ProcessExists(ini.pid) && Process.GetProcessById(ini.pid).ProcessName == "java")
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
        }

        private void Main_FormClosing(Object sender, FormClosingEventArgs e)
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
                Properties.Settings.Default.Size = this.RestoreBounds.Size;            }

            Properties.Settings.Default.Save();

            G.running = false;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            this.FormClosing += Main_FormClosing;
            this.Location = Properties.Settings.Default.Position;
            this.Size = Properties.Settings.Default.Size;
        }

        private void Main_MouseClick(object sender, MouseEventArgs e)
        {
            if (sideBar1.Width >= sideBar1.MaximumSize.Width)
            {
                sideBar1.SideBarTimer.Start();
            }
        }

        private void restartPopUp_VisibleChanged(object sender, EventArgs e)
        {
            if (restartPopUp.Visible)
            {
                int x = (this.Width - restartPopUp.Width) / 2;
                int y = (this.Height - restartPopUp.Height) / 2;

                var pos = new Point(x,y);
                restartPopUp.Location = pos;
                restartPopUp.Update();
            }
        }

        private void Main_Resize(object sender, EventArgs e)
        {
            if (restartPopUp.Visible)
            {
                int x = (this.Width - restartPopUp.Width) / 2;
                int y = (this.Height - restartPopUp.Height) / 2;

                var pos = new Point(x, y);
                restartPopUp.Location = pos;
                restartPopUp.Update();
            }
        }
    }
}