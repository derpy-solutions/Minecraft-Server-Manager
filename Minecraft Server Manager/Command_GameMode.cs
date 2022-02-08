using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Minecraft_Server_Manager
{
    public partial class Command_GameMode : UserControl
    {
        public Command_GameMode()
        {
            InitializeComponent();

            this.gamemode.SelectedItem = "Kreativ Modus";
        }

        private void sCustomCommandRun_Click(object sender, EventArgs e)
        {
            ServerCardControl serverCard = (this.Parent.Parent as ServerCardControl);
            var mode = "";
            if (this.gamemode.SelectedItem != null) 
            { 
                switch (this.gamemode.SelectedItem.ToString())
            {
                case "Kreativ Modus":
                    mode = "creative";
                    break;

                case "Überleben Modus":
                    mode = "survival";
                    break;

                case "Abenteuer Modus":
                    mode = "adventure";
                    break;

                case "Zuschauer Modus":
                    mode = "spectator";
                    break;
            }

                if (mode != "")
                {
                    var c = new Command()
                    {
                        name = '"' + serverCard.sServer.name + '"',
                        pid = serverCard.sServer.pid,
                        serverpath = '"' + Properties.Settings.Default.ServerPath + '"',
                        datapath = '"' + Properties.Settings.Default.DataPath + '"',
                        command = "Custom",
                        arguments = '"' + "gamemode " + mode + " " + this.player.SelectedItem.ToString() + '"'
                    };
                    c.Run();
                }
            }
        }
    }
}
