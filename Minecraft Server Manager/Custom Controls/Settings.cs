using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Minecraft_Server_Manager.Custom_Controls
{
    public partial class Settings : UserControl
    {
        public Settings()
        {
            InitializeComponent();

            if (Fonts.setFonts)
            {
#if !DEBUG
            {
                        Header.Font = Fonts.Header();

                        ServerPath_Label.Font = Fonts.Text();
                        ServerPath_TextBox.Font = Fonts.Text();
                        ServerPath_Browse.Font = Fonts.Button();

                        DataPath_Label.Font = Fonts.Text();
                        DataPath_TextBox.Font = Fonts.Text();
                        DataPath_Browse.Font = Fonts.Button();

                        JavaPath_Label.Font = Fonts.Text();
                        JavaPath_TextBox.Font = Fonts.Text();
                        JavaPath_Browse.Font = Fonts.Button();

                        CMDCommand_Label.Font = Fonts.Text();
                        CMDCommand_TextBox.Font = Fonts.Text();

                        ResetSettings.Font = Fonts.Button();
#endif
            }

            Inits.Voids.Add(Init);
        }

        public void Init()
        {
            ServerPath_TextBox.Text = Properties.Settings.Default.ServerPath;
            DataPath_TextBox.Text = Properties.Settings.Default.DataPath;
            JavaPath_TextBox.Text = Properties.Settings.Default.JavaPath;
            CMDCommand_TextBox.Text = Properties.Settings.Default.cmdCommand;
            CheckForUpdates.Checked = Properties.Settings.Default.CheckForUpdates;
            Console.WriteLine("Check For Updates: " + Properties.Settings.Default.CheckForUpdates);
            //Properties.Settings.Default.CheckForUpdates;
        }

        private void ResetSettings_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.ServerPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Minecraft Server Manager";
            Properties.Settings.Default.DataPath = @"C:\Program Files\derpy Solutions\Minecraft Server Manager\Data";
            Properties.Settings.Default.cmdCommand = "java -Xmx4G @libraries/net/minecraftforge/forge/1.18.1-39.0.64/win_args.txt %* --nogui";
            Properties.Settings.Default.JavaPath = @"C:\Program Files\Java\jdk-17.0.2";
            Properties.Settings.Default.Size = new Size(1250, 600);
            Properties.Settings.Default.Position = new Point(0, 0);
            Properties.Settings.Default.CheckForUpdates = true;
            Properties.Settings.Default.Save();

            Directory.CreateDirectory(Properties.Settings.Default.ServerPath);
            Directory.CreateDirectory(Properties.Settings.Default.DataPath);

            ServerPath_TextBox.Text = Properties.Settings.Default.ServerPath;
            DataPath_TextBox.Text = Properties.Settings.Default.DataPath;
            JavaPath_TextBox.Text = Properties.Settings.Default.JavaPath;
            CMDCommand_TextBox.Text = Properties.Settings.Default.cmdCommand;
            if (MyControls.Servers != null)
            {
                MyControls.Servers.RefreshServerList();
            }
        }

        private void CMDCommand_TextBox_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.cmdCommand = CMDCommand_TextBox.Text;
            Properties.Settings.Default.Save();
        }

        private void JavaPath_Browse_Click(object sender, EventArgs e)
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
                JavaPath_TextBox.Text = openFileDialog1.FileName;
                Properties.Settings.Default.JavaPath = openFileDialog1.FileName;
                Properties.Settings.Default.Save();
            }
        }

        private void JavaPath_TextBox_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.JavaPath = JavaPath_TextBox.Text;
            Properties.Settings.Default.Save();
        }

        private void DataPath_TextBox_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.DataPath = DataPath_TextBox.Text;
            Properties.Settings.Default.Save();
        }

        private void ServerPath_TextBox_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.ServerPath = ServerPath_TextBox.Text;
            Properties.Settings.Default.Save();
            if (MyControls.Servers != null)
            {
                MyControls.Servers.RefreshServerList();
            }
        }

        private void ServerPath_Browse_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    ServerPath_TextBox.Text = fbd.SelectedPath;
                    Properties.Settings.Default.ServerPath = fbd.SelectedPath;
                    Properties.Settings.Default.Save();
                    if (MyControls.Servers != null)
                    {
                        MyControls.Servers.RefreshServerList();
                    }
                }
            }
        }

        private void DataPath_Browse_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    DataPath_TextBox.Text = fbd.SelectedPath;
                    Properties.Settings.Default.DataPath = fbd.SelectedPath;
                    Properties.Settings.Default.Save();
                }
            }
        }

        private void CheckForUpdates_Click(object sender, EventArgs e)
        {

            if (CheckForUpdates.CheckState == CheckState.Checked)
            {
                CheckForUpdates.CheckState = CheckState.Unchecked;
            }
            else
            {
                CheckForUpdates.CheckState = CheckState.Checked;
            }

            Properties.Settings.Default.CheckForUpdates = CheckForUpdates.Checked;
            Properties.Settings.Default.Save();
        }

        private void CheckForUpdates_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckForUpdates.CheckState == CheckState.Checked)
            {
                CheckForUpdates.Image = Properties.Resources.checkbox_checked;
            }
            else
            {
                CheckForUpdates.Image = Properties.Resources.checkbox_unchecked;
            }
        }
    }
}
