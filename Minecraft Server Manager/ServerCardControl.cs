using System;
using System.Globalization;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minecraft_Server_Manager
{
    public partial class ServerCardControl : UserControl
    {

        public ServerCardControl(Server serv)
        {
            Console.WriteLine("Created: " + serv.name);
            this.sServer = serv;
            InitializeComponent();

            // Add all serv infos
            this.sName.Text = serv.name;
            this.sCommandSelect.SelectedItem = "Teleport";

            //Set Tooltips

            this.toolTip1.SetToolTip(this.button2, "Stoppe den Server!");
            this.toolTip1.SetToolTip(this.kick, "Kicke alle Spieler vom Server!");
            this.toolTip1.SetToolTip(this.sPlayers, "Hier siehst du alle Spieler welche auf dem Server sind!");
            this.toolTip1.SetToolTip(this.sCommandSelect, "Wähle einen Befehl aus!");
            this.toolTip1.SetToolTip(this.sCustomCommand, "Gib deinen eigenen Befehl ein!");
            this.toolTip1.SetToolTip(this.sCustomCommandRun, "Führe deinen Befehl aus!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Console.WriteLine("[" + DateTime.Now +"]: " +"Shutting down " + sServer.name + " (" + sServer.pid + ")");
            sServer.status = 4;
           this.updateValues();

            var c = new Command()
            {
                name = '"' + sServer .name + '"',
                pid = sServer.pid,
                serverpath = '"' + Properties.Settings.Default.ServerPath + '"',
                datapath = '"' + Properties.Settings.Default.DataPath + '"',
                command = "Stop"
            };
            c.Run();
        }

        private void sCustomCommandRun_Click(object sender, EventArgs e)
        {
            if (sCustomCommand.Text != "")
                Console.WriteLine("[" + DateTime.Now +"]: " +"Run Custom Command: " + '"' + sCustomCommand.Text + '"');
            {
                var c = new Command()
                {
                    name = '"' + sServer.name + '"',
                    pid = sServer.pid,
                    serverpath = '"' + Properties.Settings.Default.ServerPath + '"',
                    datapath = '"' + Properties.Settings.Default.DataPath + '"',
                    command = "Custom",
                    arguments = '"' + sCustomCommand.Text + '"',
                };
                c.Run();
            }
        }

        private void kick_Click(object sender, EventArgs e)
        {
            var players = "";
            foreach (string player in sServer.players)
            {
                players = player + "|" + players;
            }

            var c = new Command()
            {
                name = '"' + sServer.name + '"',
                pid = sServer.pid,
                serverpath = '"' + Properties.Settings.Default.ServerPath + '"',
                datapath = '"' + Properties.Settings.Default.DataPath + '"',
                command = "KickAll",
                arguments = '"' + players + '"',
            };
            c.Run();
        }

        private void sCommandSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = this.sCommandSelect.SelectedItem;
            if (item != null)
            {
                switch (item)
                {
                    case "Teleport":
                        this.command_GameMode1.Hide();
                        this.command_Kick1.Hide();
                        this.command_Teleport1.Show();
                        break;
                        
                    case "Game Mode":
                        this.command_GameMode1.Show();
                        this.command_Kick1.Hide();
                        this.command_Teleport1.Hide();
                        break;
                        
                    case "Kick":
                        this.command_GameMode1.Hide();
                        this.command_Kick1.Show();
                        this.command_Teleport1.Hide();
                        break;
                }
            }
        }
    }
}

