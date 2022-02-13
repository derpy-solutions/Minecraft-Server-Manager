using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Minecraft_Server_Manager.Custom_Controls
{
    public partial class ServerCard : UserControl
    {
        public ServerCard(Server server)
        {
            InitializeComponent();

            this.sCommandSelect.SelectedItem = "Teleport";

            //Set Fonts
            if (Fonts.setFonts)
            {
#if !DEBUG
                            sName.Font = Fonts.Header();
                            sStatus.Font = Fonts.Header();
                            sPlayers.Font = Fonts.Text();
                            sCommandSelect.Font = Fonts.Text();
                            sCustomCommand.Font = Fonts.Text();
                            sCustomCommandRun.Font = Fonts.Button();
#endif
            }

            if (server == null)
            {
                Server s = new Server()
                {
                    name = "My Server",
                };
                this.sServer = s;
            }
            else
            {
                this.sServer = server;
            }
        }

        private void Favorites_Click(object sender, EventArgs e)
        {
            if (G.Favorites == null)
            {
                FavoritesMenu favoritesMenu = new FavoritesMenu();
                G.Favorites = favoritesMenu;
            }

            G.Favorites.Location = MousePosition;
            G.Favorites.Show();
        }

        private void ServerCard_MouseEnter(object sender, EventArgs e)
        {
            G.selectedServer = this.sServer;
        }

        private void sCustomCommandRun_Click(object sender, EventArgs e)
        {
            G.selectedServer.CustomCommand();
        }

        private void CloseServer_Click(object sender, EventArgs e)
        {
            G.selectedServer.Stop();
        }

        private void sCommandSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sCommandSelect.SelectedItem != null)
            {
                switch (sCommandSelect.SelectedItem)
                {
                    case "Game Mode":
                        this.command_GameMode1.Show();
                        this.command_Kick1.Hide();
                        this.command_Teleport1.Hide();
                        break;

                    case "Teleport":
                        this.command_GameMode1.Hide();
                        this.command_Kick1.Hide();
                        this.command_Teleport1.Show();
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
