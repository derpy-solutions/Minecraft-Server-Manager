using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Minecraft_Server_Manager
{
    public class G
    {
        //public static string FolderPath = @"F:\frenkey_Developments\Visual Studio\Minecraft Server Manager - Kopie\";
        public static List<Server> Servers = new List<Server>();
        public static List<string> ServerFoldersList = new List<string>();
        public static string[] ServerFolders;
        public static bool running = true;
        public static Control CardPanel;
        public static ListBox serverList;
    }

    public class Command
    {
        public string name { get; set; }
        public int pid { get; set; }
        public string serverpath { get; set; }
        public string datapath { get; set; }
        public string command { get; set; }
        public string arguments { get; set; }
        public void Run()
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo("cmd.exe");
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.UseShellExecute = true;
            startInfo.CreateNoWindow = true;
            startInfo.Arguments = "/C MinecraftServerManagerListener.exe " + name + " " + pid + " " + serverpath + " " + datapath + " " + command + " " + arguments;
            startInfo.WorkingDirectory = Properties.Settings.Default.DataPath;
            process.StartInfo = startInfo;
            process.Start();

            Console.WriteLine(arguments);
        }
    }

    public class Server
    {
        public string name { get; set; }
        public int status { get; set; }
        public string version { get; set; }
        public string window { get; set; }
        public int pid { get; set; }
        public int port { get; set; }
        public DateTime starttime { get; set; }
        public int readLines { get; set; }
        public List<string> players = new List<string>();
        public ServerCardControl serverCard { get; set; }
        public string ini { get; set; }
        public void Update()
        {
            if (serverCard != null)
            {
                serverCard.updateValues();
            }
        }
        public void Create()
        {
            Console.WriteLine("Create Server: " + name + "!");
            G.CardPanel.Controls.Add(new ServerCardControl(this));
            var i = 0;

            foreach (ServerCardControl c in G.CardPanel.Controls)
            {
                //Console.WriteLine("Check Existing Control: " + c.sName.Text);

                if (i == G.CardPanel.Controls.Count - 1)
                {
                    //Console.WriteLine("Found Server Card No. "+ i + " - " +  c.sName.Text +"!");
                    serverCard = c;
                    break;
                }

                i = i + 1;
            }
            starttime = DateTime.Now;
            Update();
            G.Servers.Add(this);
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
                command = "Stop"
            };

            c.Run();

            if (ini != null)
            {
                File.Delete(ini);
            }

            //Console.WriteLine("Before Deletion: " + G.CardPanel.Controls.Count);
            if (serverCard != null)
            {
                serverCard.Dispose();
            }
            //Console.WriteLine("After Deletion: " + G.CardPanel.Controls.Count);

            for (int i = G.Servers.Count - 1; i >= 0; i--)
            {
                var s = G.Servers[i];

                if (s.name == name && s.pid == pid)
                {
                    G.Servers.RemoveAt(i);
                }
            }
        }
        public bool IsRunning()
        {
            return ini == null || (pid == -1  && (DateTime.Now.Subtract(starttime).TotalMilliseconds < 10000))|| Form1.ProcessExists(pid) && File.Exists(ini);
        }
        public void ReadIni(string path = null)
        {
            if (path != null)
            {
                ini = path;
            }

            var MyIni = new Form1.ServerIni();
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
                            else if (line.Contains("For help, type"))
                            {
                                status = 3;

                                if (ini != null && File.Exists(ini))
                                {
                                    var MyIni = new Form1.IniFile(ini);
                                    MyIni.Write("Status", status.ToString());
                                    ReadIni();
                                    changed = true;
                                }
                            }
                        }
                    }
                }
            }

            if (!changed && status == 1 && exists && this.ini != null)
            {
                ReadIni();

                if (File.Exists(this.ini))
                {
                    status = 2;
                    var MyIni = new Form1.IniFile(this.ini);
                    MyIni.Write("Status", status.ToString());

                    changed = true;
                }
            }
            else if (!changed && File.Exists(Properties.Settings.Default.DataPath + @"\Status Updates\update\" + name + ".ini"))
            {
                changed = true;
                File.Delete(Properties.Settings.Default.DataPath + @"\Status Updates\update" + name + ".ini");
            }



            return changed;
        }
    }

    public class Dir
    {
        public static void Copy(string sourceDirectory, string targetDirectory)
        {
            var diSource = new DirectoryInfo(sourceDirectory);
            var diTarget = new DirectoryInfo(targetDirectory);

            CopyAll(diSource, diTarget);
        }

        public static void CopyAll(DirectoryInfo source, DirectoryInfo target)
        {
            Directory.CreateDirectory(target.FullName);

            // Copy each file into the new directory.
            foreach (FileInfo fi in source.GetFiles())
            {
                //Console.WriteLine("[" + DateTime.Now +"]: " + @"Copying {0}\{1}", target.FullName, fi.Name);
                fi.CopyTo(Path.Combine(target.FullName, fi.Name), true);
            }

            // Copy each subdirectory using recursion.
            foreach (DirectoryInfo diSourceSubDir in source.GetDirectories())
            {
                DirectoryInfo nextTargetSubDir =
                    target.CreateSubdirectory(diSourceSubDir.Name);
                CopyAll(diSourceSubDir, nextTargetSubDir);
            }
        }
    }

    static class Program
    {

        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}