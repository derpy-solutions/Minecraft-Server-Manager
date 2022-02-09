using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Minecraft_Server_Manager
{
    public partial class Einstellungen : UserControl
    {
        public Einstellungen()
        {
            InitializeComponent();

            //set Tooltips
            this.toolTip1.SetToolTip(this.textBox1, "Lege den Pfad zu den Servern fest!");
            this.toolTip1.SetToolTip(this.textBox2, "Lege den Data Pfad fest!");
            this.toolTip1.SetToolTip(this.textBox3, "Gib deinen eigenen CMD command ein um die Server zu starten!");
            this.toolTip1.SetToolTip(this.textBox4, "Gib den Pfad zu deiner Java Version an!");
            this.toolTip1.SetToolTip(this.button2, "Löscht alle deine Einstellungen!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.ServerPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Minecraft Server Manager";
            Properties.Settings.Default.DataPath = @"C:\Program Files\derpy Solutions\Minecraft Server Manager\Data";
            Properties.Settings.Default.cmdCommand = "java -Xmx4G @libraries/net/minecraftforge/forge/1.18.1-39.0.64/win_args.txt %* --nogui";
            Properties.Settings.Default.JavaPath = @"C:\Program Files\Java\jdk-17.0.2";
            Properties.Settings.Default.Size= new Size(1250, 600);
            Properties.Settings.Default.Position = new Point(0, 0);
            Properties.Settings.Default.Save();

            textBox1.Text = Properties.Settings.Default.ServerPath.ToString();
            textBox2.Text = Properties.Settings.Default.DataPath.ToString();
            textBox3.Text = "java -Xmx4G @libraries/net/minecraftforge/forge/1.18.1-39.0.64/win_args.txt %* --nogui";
            textBox4.Text = Properties.Settings.Default.JavaPath;

            Directory.CreateDirectory(Properties.Settings.Default.ServerPath);
            Directory.CreateDirectory(Properties.Settings.Default.DataPath);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.cmdCommand = textBox3.Text;
            Properties.Settings.Default.Save();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    textBox1.Text = fbd.SelectedPath;
                    Properties.Settings.Default.ServerPath = fbd.SelectedPath;
                    Properties.Settings.Default.Save();
                    Console.WriteLine("1st Parent: " + this.Parent.Name);
                    Console.WriteLine("Parent Parent: " + this.Parent.Parent.Name);
                    var lv = G.serverList;
                    if (lv != null)
                    {

                        var serverPath = Properties.Settings.Default["ServerPath"].ToString() + @"\";
                        G.ServerFolders = Directory.GetDirectories(serverPath);
                        G.ServerFoldersList.Clear();
                        lv.Items.Clear();

                        for (int i = 0; i < G.ServerFolders.Length; i++)
                        {
                            string sName = Regex.Replace(G.ServerFolders[i], @".*\\", "");
                            G.ServerFoldersList.Add(sName);
                            lv.Items.Add(sName);
                        }
                    }

                    Console.WriteLine(Parent.Parent.Name);
                    //var parent = 
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    textBox2.Text = fbd.SelectedPath;
                    Properties.Settings.Default.DataPath = fbd.SelectedPath;
                    Properties.Settings.Default.Save();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = Properties.Settings.Default.JavaPath,
                Title = "Path to 'Java.exe'",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = ".exe",
                Filter = "java.exe|java.exe",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox4.Text = openFileDialog1.FileName;
                Properties.Settings.Default.JavaPath = openFileDialog1.FileName;
                Properties.Settings.Default.Save();
            }
        }
    }
}
