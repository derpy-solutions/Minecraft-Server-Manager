using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Reflection;

namespace Minecraft_Server_Manager.Custom_Controls
{
    public partial class Settings : UserControl
    {
        bool initialized = false;
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

            Header.Text = Main.rm.GetString("Settings");
            ServerPath_Label.Text = "Server " + Main.rm.GetString("Path");
            DataPath_Label.Text = "Data " + Main.rm.GetString("Path");
            JavaPath_Label.Text = "Java " + Main.rm.GetString("Path");
            CMDCommand_Label.Text = "CMD " + Main.rm.GetString("Command");
            CheckForUpdates.Text = Main.rm.GetString("SearchForUpdates");
            show_Tooltips.Text = Main.rm.GetString("Show_ToolTips");
            ResetSettings.Text = Main.rm.GetString("ResetSettings");
            LanguageLabel.Text = Main.rm.GetString("Language");
            RAM_Label.Text = Main.rm.GetString("Settings_RAM");

            Inits.Voids.Add(Init);
        }

        public void Init()
        {
            ServerPath_TextBox.Text = Properties.Settings.Default.ServerPath;
            DataPath_TextBox.Text = Properties.Settings.Default.DataPath;
            JavaPath_TextBox.Text = Properties.Settings.Default.JavaPath;
            CMDCommand_TextBox.Text = Properties.Settings.Default.cmdCommand;
            CheckForUpdates.Checked = Properties.Settings.Default.CheckForUpdates;
            show_Tooltips.Checked = Properties.Settings.Default.ShowTooltips;

            RAM_Amount.Value = Properties.Settings.Default.RAM_Amount;
            RAM_Unit.SelectedItem = Properties.Settings.Default.RAM_Unit;

            switch (Properties.Settings.Default.Language)
            {
                case "DE":
                    LanguageSelect.SelectedItem = "Deutsch";
                    break;

                case "EN":
                    LanguageSelect.SelectedItem = "English";
                    break;
            }

            if (Properties.Settings.Default.ShowTooltips)
            {
                MyControls.Main.toolTip1.SetToolTip(ServerPath_Label, Main.rm.GetString("ttp_ServerPath"));
                MyControls.Main.toolTip1.SetToolTip(ServerPath_TextBox, Main.rm.GetString("ttp_ServerPath"));
                MyControls.Main.toolTip1.SetToolTip(ServerPath_Browse, Main.rm.GetString("ttp_Browse") + " " + Main.rm.GetString("Server") + " " + Main.rm.GetString("Path"));

                MyControls.Main.toolTip1.SetToolTip(DataPath_Label, Main.rm.GetString("ttp_DataPath"));
                MyControls.Main.toolTip1.SetToolTip(DataPath_TextBox, Main.rm.GetString("ttp_DataPath"));
                MyControls.Main.toolTip1.SetToolTip(DataPath_Browse, Main.rm.GetString("ttp_Browse") + " " +" Data " + Main.rm.GetString("Path"));

                MyControls.Main.toolTip1.SetToolTip(JavaPath_Label, Main.rm.GetString("ttp_JavaPath"));
                MyControls.Main.toolTip1.SetToolTip(JavaPath_TextBox, Main.rm.GetString("ttp_JavaPath"));
                MyControls.Main.toolTip1.SetToolTip(JavaPath_Browse, Main.rm.GetString("ttp_Browse") + " " + " Java " + Main.rm.GetString("Path"));

                MyControls.Main.toolTip1.SetToolTip(CMDCommand_Label, Main.rm.GetString("ttp_CMD"));
                MyControls.Main.toolTip1.SetToolTip(CMDCommand_TextBox, Main.rm.GetString("ttp_CMD"));
                MyControls.Main.toolTip1.SetToolTip(ResetSettings, Main.rm.GetString("ttp_Reset"));
            }

            initialized = true;
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

        private void LanguageSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LanguageSelect.SelectedIndex > -1 && initialized)
            {
                switch (LanguageSelect.SelectedItem)
                {
                    case "Deutsch":
                        Properties.Settings.Default.Language = "DE";
                        Main.rm = new System.Resources.ResourceManager("Minecraft_Server_Manager.de_local", Assembly.GetExecutingAssembly());
                        Properties.Settings.Default.Save();
                        MyControls.Main.restartPopUp.Content.Text = Main.rm.GetString("Restart_Language");
                        MyControls.Main.restartPopUp.Restart.Text = Main.rm.GetString("Restart");
                        MyControls.Main.restartPopUp.NoRestart.Text = Main.rm.GetString("NoRestart");
                        MyControls.Main.restartPopUp.Show();
                        break;

                    case "English":
                        Properties.Settings.Default.Language = "EN";
                        Main.rm = new System.Resources.ResourceManager("Minecraft_Server_Manager.en_local", Assembly.GetExecutingAssembly());
                        Properties.Settings.Default.Save();
                        MyControls.Main.restartPopUp.Content.Text = Main.rm.GetString("Restart_Language");
                        MyControls.Main.restartPopUp.Restart.Text = Main.rm.GetString("Restart");
                        MyControls.Main.restartPopUp.NoRestart.Text = Main.rm.GetString("NoRestart");
                        MyControls.Main.restartPopUp.Show();
                        break;
                }
            }
        }

        private void show_Tooltips_CheckedChanged(object sender, EventArgs e)
        {
            if (show_Tooltips.CheckState == CheckState.Checked)
            {
                show_Tooltips.Image = Properties.Resources.checkbox_checked;
            }
            else
            {
                show_Tooltips.Image = Properties.Resources.checkbox_unchecked;
            }
        }

        private void show_Tooltips_Click(object sender, EventArgs e)
        {

                if (show_Tooltips.CheckState == CheckState.Checked)
                {
                    show_Tooltips.CheckState = CheckState.Unchecked;
                }
                else
                {
                    show_Tooltips.CheckState = CheckState.Checked;
                }

                Properties.Settings.Default.ShowTooltips = show_Tooltips.Checked;
                Properties.Settings.Default.Save();

            MyControls.Main.restartPopUp.Content.Text = Main.rm.GetString("Show_ToolTips_Changed");
            MyControls.Main.restartPopUp.Restart.Text = Main.rm.GetString("Restart");
            MyControls.Main.restartPopUp.NoRestart.Text = Main.rm.GetString("NoRestart");
            MyControls.Main.restartPopUp.Show();
        }

        private void RAM_Label_Click(object sender, EventArgs e)
        {

        }

        private void RAM_Unit_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RAM_Unit.SelectedItem != null)
            {
                Properties.Settings.Default.RAM_Unit = RAM_Unit.SelectedItem.ToString();
                Properties.Settings.Default.Save();
            }
        }

        private void RAM_Amount_ValueChanged(object sender, EventArgs e)
        {
                Properties.Settings.Default.RAM_Amount = Decimal.ToInt32(RAM_Amount.Value);
                Properties.Settings.Default.Save();
        }
    }
}
