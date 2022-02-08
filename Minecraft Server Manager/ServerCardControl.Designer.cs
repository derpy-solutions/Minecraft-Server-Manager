using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Minecraft_Server_Manager
{
    partial class ServerCardControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServerCardControl));
            this.sName = new System.Windows.Forms.Label();
            this.sPlayers = new System.Windows.Forms.ListBox();
            this.sBox = new System.Windows.Forms.GroupBox();
            this.command_Teleport1 = new Minecraft_Server_Manager.Command_Teleport();
            this.command_Kick1 = new Minecraft_Server_Manager.Command_Kick();
            this.command_GameMode1 = new Minecraft_Server_Manager.Command_GameMode();
            this.sCommandSelect = new System.Windows.Forms.ComboBox();
            this.sCustomCommand = new System.Windows.Forms.TextBox();
            this.sCustomCommandRun = new System.Windows.Forms.Button();
            this.kick = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.sStatus = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.sBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // sName
            // 
            this.sName.BackColor = System.Drawing.Color.Transparent;
            this.sName.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sName.ForeColor = System.Drawing.Color.White;
            this.sName.Location = new System.Drawing.Point(5, 5);
            this.sName.Name = "sName";
            this.sName.Size = new System.Drawing.Size(264, 22);
            this.sName.TabIndex = 1;
            this.sName.Text = "Server Name";
            // 
            // sPlayers
            // 
            this.sPlayers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.sPlayers.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sPlayers.FormattingEnabled = true;
            this.sPlayers.ItemHeight = 20;
            this.sPlayers.Location = new System.Drawing.Point(5, 43);
            this.sPlayers.Name = "sPlayers";
            this.sPlayers.Size = new System.Drawing.Size(153, 144);
            this.sPlayers.TabIndex = 2;
            // 
            // sBox
            // 
            this.sBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sBox.BackColor = System.Drawing.Color.Transparent;
            this.sBox.Controls.Add(this.command_Teleport1);
            this.sBox.Controls.Add(this.command_Kick1);
            this.sBox.Controls.Add(this.command_GameMode1);
            this.sBox.Location = new System.Drawing.Point(174, 43);
            this.sBox.Name = "sBox";
            this.sBox.Size = new System.Drawing.Size(660, 112);
            this.sBox.TabIndex = 3;
            this.sBox.TabStop = false;
            // 
            // command_Teleport1
            // 
            this.command_Teleport1.BackColor = System.Drawing.Color.Transparent;
            this.command_Teleport1.Location = new System.Drawing.Point(5, 25);
            this.command_Teleport1.Name = "command_Teleport1";
            this.command_Teleport1.Size = new System.Drawing.Size(650, 85);
            this.command_Teleport1.TabIndex = 7;
            // 
            // command_Kick1
            // 
            this.command_Kick1.BackColor = System.Drawing.Color.Transparent;
            this.command_Kick1.Location = new System.Drawing.Point(5, 25);
            this.command_Kick1.Name = "command_Kick1";
            this.command_Kick1.Size = new System.Drawing.Size(650, 85);
            this.command_Kick1.TabIndex = 6;
            // 
            // command_GameMode1
            // 
            this.command_GameMode1.BackColor = System.Drawing.Color.Transparent;
            this.command_GameMode1.Location = new System.Drawing.Point(5, 25);
            this.command_GameMode1.Name = "command_GameMode1";
            this.command_GameMode1.Size = new System.Drawing.Size(650, 80);
            this.command_GameMode1.TabIndex = 5;
            // 
            // sCommandSelect
            // 
            this.sCommandSelect.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sCommandSelect.FormattingEnabled = true;
            this.sCommandSelect.Items.AddRange(new object[] {
            "Teleport",
            "Game Mode",
            "Kick"});
            this.sCommandSelect.Location = new System.Drawing.Point(184, 37);
            this.sCommandSelect.Name = "sCommandSelect";
            this.sCommandSelect.Size = new System.Drawing.Size(157, 28);
            this.sCommandSelect.TabIndex = 20;
            this.sCommandSelect.SelectedIndexChanged += new System.EventHandler(this.sCommandSelect_SelectedIndexChanged);
            // 
            // sCustomCommand
            // 
            this.sCustomCommand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sCustomCommand.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sCustomCommand.Location = new System.Drawing.Point(174, 167);
            this.sCustomCommand.Name = "sCustomCommand";
            this.sCustomCommand.Size = new System.Drawing.Size(578, 26);
            this.sCustomCommand.TabIndex = 4;
            // 
            // sCustomCommandRun
            // 
            this.sCustomCommandRun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sCustomCommandRun.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.sCustomCommandRun.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.sCustomCommandRun.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.sCustomCommandRun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sCustomCommandRun.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sCustomCommandRun.ForeColor = System.Drawing.Color.Transparent;
            this.sCustomCommandRun.Image = ((System.Drawing.Image)(resources.GetObject("sCustomCommandRun.Image")));
            this.sCustomCommandRun.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sCustomCommandRun.Location = new System.Drawing.Point(759, 161);
            this.sCustomCommandRun.Name = "sCustomCommandRun";
            this.sCustomCommandRun.Size = new System.Drawing.Size(76, 34);
            this.sCustomCommandRun.TabIndex = 5;
            this.sCustomCommandRun.Text = "Run";
            this.sCustomCommandRun.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.sCustomCommandRun.UseVisualStyleBackColor = false;
            this.sCustomCommandRun.Click += new System.EventHandler(this.sCustomCommandRun_Click);
            // 
            // kick
            // 
            this.kick.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.kick.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.kick.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.kick.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.kick.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kick.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kick.ForeColor = System.Drawing.Color.Transparent;
            this.kick.Image = ((System.Drawing.Image)(resources.GetObject("kick.Image")));
            this.kick.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.kick.Location = new System.Drawing.Point(759, 5);
            this.kick.Name = "kick";
            this.kick.Size = new System.Drawing.Size(76, 34);
            this.kick.TabIndex = 6;
            this.kick.Text = "Kick";
            this.kick.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.kick.UseVisualStyleBackColor = false;
            this.kick.Click += new System.EventHandler(this.kick_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.Transparent;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(678, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(76, 34);
            this.button2.TabIndex = 1;
            this.button2.Text = "Stop";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // sStatus
            // 
            this.sStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sStatus.BackColor = System.Drawing.Color.Transparent;
            this.sStatus.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sStatus.ForeColor = System.Drawing.Color.White;
            this.sStatus.Location = new System.Drawing.Point(275, 5);
            this.sStatus.Name = "sStatus";
            this.sStatus.Size = new System.Drawing.Size(290, 22);
            this.sStatus.TabIndex = 7;
            this.sStatus.Text = "Server Status";
            this.sStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 10000;
            this.toolTip1.InitialDelay = 50;
            this.toolTip1.ReshowDelay = 100;
            // 
            // ServerCardControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.sCommandSelect);
            this.Controls.Add(this.sStatus);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.kick);
            this.Controls.Add(this.sCustomCommandRun);
            this.Controls.Add(this.sCustomCommand);
            this.Controls.Add(this.sBox);
            this.Controls.Add(this.sPlayers);
            this.Controls.Add(this.sName);
            this.Name = "ServerCardControl";
            this.Size = new System.Drawing.Size(840, 198);
            this.sBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        public void SetName(string caption)
        {
            sName.Text = caption;
        }

        public void updateValues(Server serv = null)
        {
            sName.Text = sServer.name;
            this.sPlayers.Items.Clear();

            List<Control> controls = new List<Control>();
            controls.Add(this.command_GameMode1.player);
            controls.Add(this.command_Teleport1.player1);
            controls.Add(this.command_Teleport1.player2);
            controls.Add(this.command_Kick1.player);

            foreach (ComboBox ctrl in controls)
            {
                ctrl.Items.Clear();

                if (ctrl.SelectedItem != null && (!this.sServer.players.Contains(ctrl.SelectedItem.ToString()) || ctrl.SelectedItem.ToString() == ""))
                {
                    ctrl.SelectedItem = null;
                }
            }

            foreach (string player in this.sServer.players)
            {
                //Console.WriteLine("[" + DateTime.Now +"]: " +player);
                this.sPlayers.Items.Add(player);

                foreach (ComboBox ctrl in controls)
                {
                    ctrl.Items.Add(player);

                    if (ctrl.SelectedItem == null || ctrl.SelectedItem.ToString() == "")
                    {
                        ctrl.SelectedItem = player;
                    }
                }

                if (this.command_GameMode1.player.SelectedItem == null || this.command_GameMode1.player.SelectedItem.ToString() == "")
                {
                    this.command_GameMode1.player.SelectedItem = player;
                }
            }

            foreach (ComboBox ctrl in controls)
            {
                if (ctrl.SelectedItem == null)
                {
                    ctrl.Items.Add("Spieler");
                    ctrl.SelectedItem = "Spieler";
                }
            }

            switch (sServer.status)
            {
                case 1:
                    this.sStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(156)))), ((int)(((byte)(56)))));
                    this. sStatus.Text = "Server gestartet ...";
                    break;

                case 2:
                    this.sStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(255)))), ((int)(((byte)(250)))));
                   this. sStatus.Text = "Lade Server ...";
                    break;

                case 3:
                    this.sStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(215)))), ((int)(((byte)(16)))));
                    var port = sServer.port.ToString();
                        if (port.Length > 2)
                    {
                        port = port.Remove(0, 3);
                    }

                   this. sStatus.Text = "Online auf Jugendhaus #" + port;
                    break;

                case 4:
                    this.sStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(41)))), ((int)(((byte)(12)))));
                   this. sStatus.Text = "Server fährt herunter ...";
                    break;

                default:
                    // code block
                    break;
            }
        }
        #endregion

        public System.Windows.Forms.Label sName;
        public System.Windows.Forms.ListBox sPlayers;
        public System.Windows.Forms.GroupBox sBox;
        public System.Windows.Forms.ComboBox sCommandSelect;
        public System.Windows.Forms.TextBox sCustomCommand;
        public System.Windows.Forms.Button sCustomCommandRun;
        public System.Windows.Forms.Button kick;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.Label sStatus;
        public Server sServer;
        private Command_GameMode command_GameMode1;
        private Command_Teleport command_Teleport1;
        private Command_Kick command_Kick1;
        private ToolTip toolTip1;
    }
}
