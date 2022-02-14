using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Minecraft_Server_Manager.Custom_Controls.Commands
{
    public partial class Command_GameMode : UserControl
    {
        public Command_GameMode()
        {
            InitializeComponent();
            this.GameMode.Items.AddRange(new object[] {
            Main.rm.GetString("Creative") + " " + Main.rm.GetString("Mode"),
            Main.rm.GetString("Survival") + " " + Main.rm.GetString("Mode"),
            Main.rm.GetString("Adventure") + " " + Main.rm.GetString("Mode"),
            Main.rm.GetString("Spectator") + " " + Main.rm.GetString("Mode")});

            this.GameMode.SelectedItem = Main.rm.GetString("Creative") + " " + Main.rm.GetString("Mode");
            SetGamemode_Label.Text = Main.rm.GetString("Set_GameMode");
            to.Text = Main.rm.GetString("to");

            //Set Font
#if !DEBUG
label1.Font = Fonts.Text();
Player.Font = Fonts.Text();
label2.Font = Fonts.Text();
GameMode.Font = Fonts.Text();
Run.Font = Fonts.Button();
#endif
        }

        private void Run_Click(object sender, EventArgs e)
        {
            if (G.selectedServer != null)
            {
                G.selectedServer.GameMode();
            }
        }
    }
}
