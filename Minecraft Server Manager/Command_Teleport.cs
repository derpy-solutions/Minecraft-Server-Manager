using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Minecraft_Server_Manager
{
    public partial class Command_Teleport : UserControl
    {
        public Command_Teleport()
        {
            InitializeComponent();
        }

        private void sCustomCommandRun_Click(object sender, EventArgs e)
        {
            ServerCardControl serverCard = (this.Parent.Parent as ServerCardControl);

            if (this.player1.SelectedItem != null && this.player2.SelectedItem != null)
            {
                var c = new Command()
                {
                    name = '"' + serverCard.sServer.name + '"',
                    pid = serverCard.sServer.pid,
                    serverpath = '"' + Properties.Settings.Default.ServerPath + '"',
                    datapath = '"' + Properties.Settings.Default.DataPath + '"',
                    command = "Custom",
                    arguments = '"' + "tp " + this.player1.SelectedItem.ToString() +  " " + this.player2.SelectedItem.ToString() + '"'
                };
                c.Run();
            }
        }
    }
}
