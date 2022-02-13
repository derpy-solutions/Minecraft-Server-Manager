using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace Minecraft_Server_Manager.Custom_Controls
{
    public partial class RestartPopUp : UserControl
    {
        public RestartPopUp()
        {
            InitializeComponent();
        }

        private void Restart_Click(object sender, EventArgs e)
        {
            var path = Environment.GetFolderPath(Environment.SpecialFolder.CommonStartMenu);

            if (Directory.Exists(path) && Directory.Exists(path + @"\Programs"))           
            {
                path = path + @"\Programs";

                Console.WriteLine("Startup Folder Exists.");
                Console.WriteLine(path);
                Console.WriteLine(path + @"\Minecraft Server Manager.lnk");
                if (File.Exists(path + @"\Minecraft Server Manager.lnk")) {

                    Console.WriteLine("Shortcut Exists.");

                    System.Diagnostics.Process process = new System.Diagnostics.Process();
                    System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo("cmd.exe");
                    startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                    startInfo.UseShellExecute = false;
                    startInfo.CreateNoWindow = false;
                    startInfo.Arguments = "/C " + '"' + path + @"\Minecraft Server Manager.lnk"+ '"';
                    startInfo.WorkingDirectory = Properties.Settings.Default.DataPath;
                    process.StartInfo = startInfo;
                   if (process.Start())
                    {
                        Application.Exit();
                    }
                }
            }
        }

        private void NoRestart_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
