using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Drawing.Text;
using System.Xml;
using System.Xml.Linq;

namespace Minecraft_Server_Manager
{
    public class Command
    {
        public string name { get; set; }
        public int pid { get; set; }
        public string serverpath { get; set; }
        public string datapath { get; set; }
        public string javapath { get; set; }
        public string command { get; set; }
        public string arguments { get; set; }
        public void Run()
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo("cmd.exe");
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.UseShellExecute = true;
            startInfo.CreateNoWindow = true;
            startInfo.Arguments = "/C MinecraftServerManagerListener.exe " + name + " " + pid + " " + serverpath + " " + datapath + " " + javapath + " " + command + " " + arguments;
            startInfo.WorkingDirectory = Properties.Settings.Default.DataPath;
            process.StartInfo = startInfo;
            process.Start();

            Console.WriteLine(arguments);
        }
    }
}