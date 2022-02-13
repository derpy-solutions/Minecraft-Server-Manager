using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Minecraft_Server_Manager.Custom_Controls
{
    public partial class FavoriteCommand : UserControl
    {
        public FavoriteCommand(FavoriteCommands.Command cmd)
        {
            InitializeComponent();
            this.favCommand = cmd;
            this.CommandName.Text = cmd.name;
            this.Command.Text = cmd.command;
        }

        private void CommandName_Click(object sender, EventArgs e)
        {
            this.CommandNameEdit.Text = this.CommandName.Text;
            this.CommandNameEdit.Show();
            this.CommandName.Hide();
            this.ActiveControl = CommandNameEdit;
        }

        private void CommandNameEdit_Leave(object sender, EventArgs e)
        {
            this.CommandName.Text = this.CommandNameEdit.Text;
            this.favCommand.name = this.CommandName.Text;
            this.favCommand.command = this.Command.Text;

            FavoriteCommands.Save();
            this.CommandName.Show();
            this.CommandNameEdit.Hide();
        }

        private void Command_TextChanged(object sender, EventArgs e)
        {
            this.favCommand.command = this.Command.Text;
            this.favCommand.name = this.CommandName.Text;
            FavoriteCommands.Save();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            FavoriteCommands.Commands.Remove(this.favCommand);
            FavoriteCommands.Save();
            this.Dispose();
        }

        private void Run_Click(object sender, EventArgs e)
        {
            Server server = G.selectedServer;

            Command command = new Command()
            {
                name = '"' + server.name + '"',
                pid = server.pid,
                serverpath = '"' + Properties.Settings.Default.ServerPath + '"',
                datapath = '"' + Properties.Settings.Default.DataPath + '"',
                javapath = '"' + Properties.Settings.Default.JavaPath + '"',
                command = "Custom",
                arguments = '"' + this.favCommand.command + '"'
            };

            command.Run();

        }
    }
}
