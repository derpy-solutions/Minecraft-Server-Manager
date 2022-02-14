using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Minecraft_Server_Manager.Custom_Controls.Commands
{
    public partial class Command_Kick : UserControl
    {
        public Command_Kick()
        {
            InitializeComponent();

            Kick_Label.Text = Main.rm.GetString("Kick");
            of_Server.Text = Main.rm.GetString("of_the_server");

            //Set Font
#if !DEBUG
label1.Font = Fonts.Text();
Player.Font = Fonts.Text();
label2.Font = Fonts.Text();
Run.Font = Fonts.Button();
#endif
        }

        private void Run_Click(object sender, EventArgs e)
        {
            if (G.selectedServer != null)
            {
                G.selectedServer.Kick();
            }
        }
    }
}
