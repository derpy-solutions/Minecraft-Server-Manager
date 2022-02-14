using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Minecraft_Server_Manager.Custom_Controls.Commands
{
    public partial class Command_Teleport : UserControl
    {
        public Command_Teleport()
        {
            InitializeComponent();
            Teleport_Label.Text = Main.rm.GetString("Teleport");
            to_Player.Text = Main.rm.GetString("to_Player");

            //Set Font
#if !DEBUG
label1.Font = Fonts.Text();
Player_Target.Font = Fonts.Text();
label2.Font = Fonts.Text();
Player_Destination.Font = Fonts.Text();
Run.Font = Fonts.Button();
#endif
        }

        private void Run_Click(object sender, EventArgs e)
        {
            if (G.selectedServer != null)
            {
                G.selectedServer.Teleport();
            }
        }
    }
}
