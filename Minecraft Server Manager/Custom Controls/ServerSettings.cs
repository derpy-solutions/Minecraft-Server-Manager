using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Minecraft_Server_Manager.Custom_Controls
{
    public partial class ServerSettings : UserControl
    {
        public Server server;
        public ServerSettings()
        {
            InitializeComponent();

            Name_Edit.Hide();
            Name_EditDiscard.Hide();
            Name_EditSave.Hide();

            RAM_Unit.SelectedItem = "GB";
            RAM_Amount.Value = 2;
            RAM_Amount.Increment = 1;
            RAM_Amount.Maximum = 64;

            Delete.Text = Main.rm.GetString("DeleteServer");
            Save.Text = Main.rm.GetString("Save");
            Discard.Text = Main.rm.GetString("Cancel");
            ShowUI.Text = Main.rm.GetString("ShowUI");

            //Set Fonts
            if (Fonts.setFonts)
            {
#if !DEBUG
                        Name_Edit.Font = Fonts.Header();
                        Name_Label.Font = Fonts.Header();

                        RAM_Label.Font = Fonts.Text();
                        RAM_Amount.Font = Fonts.Text();
                        RAM_Unit.Font = Fonts.Text();

                        ShowUI.Font = Fonts.Text();

                        Delete.Font = Fonts.Button();
                        Discard.Font = Fonts.Button();
                        Save.Font = Fonts.Button();
#endif
            }
            }

        private void Save_Click(object sender, EventArgs e)
        {
            server.settings.Show_UI = this.ShowUI.Checked;
            server.settings.RAM_Amount = Decimal.ToInt32(this.RAM_Amount.Value);
            server.settings.RAM_Unit = this.RAM_Unit.SelectedItem.ToString();
            server.settings.Save();
            this.Hide();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Discard_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            //Delete & Refresh
            if (server.path != null)
            {
                if (Directory.Exists(server.path))
                {
                    Directory.Delete(server.path, true);
                    MyControls.Servers.RefreshServerList();
                }
            } 
            this.Hide();
        }

        private void ShowUI_Click(object sender, EventArgs e)
        {
            if (ShowUI.Checked)
            {
                ShowUI.Checked = false;
            }
            else
            {
                ShowUI.Checked = true;
            }
        }

        private void RAM_Unit_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (RAM_Unit.SelectedItem)
            {
                case "GB":
                    RAM_Amount.Increment = 1;
                    RAM_Amount.Maximum = 64;
                    break;

                case "MB":
                    RAM_Amount.Increment = 256;
                    RAM_Amount.Maximum = 65536;
                    break;
            }
        }

        private void Name_Label_DoubleClick(object sender, EventArgs e)
        {
            Name_Edit.Text = Name_Label.Text;
            Name_Edit.Show();
            Name_Edit.Select();
            Name_EditDiscard.Show();
            Name_EditSave.Show();
        }

        private void Name_EditSave_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(Properties.Settings.Default.ServerPath + @"\" + server.name))
            {
                Directory.Move(Properties.Settings.Default.ServerPath + @"\" + server.name, Properties.Settings.Default.ServerPath + @"\" + Name_Edit.Text);
                Name_Label.Text = Name_Edit.Text;
                server.name = Name_Edit.Text;
                server.path = Properties.Settings.Default.ServerPath + @"\" + Name_Edit.Text;
                server.settings.Path = Properties.Settings.Default.ServerPath + @"\" + Name_Edit.Text;

                MyControls.Servers.RefreshServerList();

                // SAVE
                Name_Edit.Hide();
                Name_EditDiscard.Hide();
                Name_EditSave.Hide();
            }
        }

        private void Name_EditDiscard_Click(object sender, EventArgs e)
        {
            Name_Edit.Hide();
            Name_EditDiscard.Hide();
            Name_EditSave.Hide();
        }

        private void ServerSettings_VisibleChanged(object sender, EventArgs e)
        {
            if (server != null)
            {
                if (this.Visible)
                {
                    this.BringToFront();
                }

                this.ShowUI.Checked = server.settings.Show_UI;
                this.RAM_Amount.Value = server.settings.RAM_Amount;
                this.RAM_Unit.SelectedItem = server.settings.RAM_Unit;
            }
        }

        private void ShowUI_CheckStateChanged(object sender, EventArgs e)
        {

        }

        private void ShowUI_CheckedChanged(object sender, EventArgs e)
        {
            Console.WriteLine("Check Changed to: " + ShowUI.Checked);
            if (ShowUI.Checked)
            {
                ShowUI.Image = Properties.Resources.checkbox_checked;
            }
            else
            {
                ShowUI.Image = Properties.Resources.checkbox_unchecked;
            }
        }
    }
}
