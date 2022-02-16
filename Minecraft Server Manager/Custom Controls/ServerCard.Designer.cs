
namespace Minecraft_Server_Manager.Custom_Controls
{
    partial class ServerCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServerCard));
            this.sCommandSelect = new System.Windows.Forms.ComboBox();
            this.sStatus = new System.Windows.Forms.Label();
            this.CloseServer = new System.Windows.Forms.Button();
            this.sCustomCommandRun = new System.Windows.Forms.Button();
            this.sCustomCommand = new System.Windows.Forms.TextBox();
            this.sBox = new System.Windows.Forms.GroupBox();
            this.command_Teleport1 = new Minecraft_Server_Manager.Custom_Controls.Commands.Command_Teleport();
            this.command_Kick1 = new Minecraft_Server_Manager.Custom_Controls.Commands.Command_Kick();
            this.command_GameMode1 = new Minecraft_Server_Manager.Custom_Controls.Commands.Command_GameMode();
            this.sPlayers = new System.Windows.Forms.ListBox();
            this.sName = new System.Windows.Forms.Label();
            this.Favorites = new System.Windows.Forms.Button();
            this.sBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // sCommandSelect
            // 
            this.sCommandSelect.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sCommandSelect.FormattingEnabled = true;
            this.sCommandSelect.Items.AddRange(new object[] {
            "Game Mode",
            "Kick",
            "Teleport"});
            this.sCommandSelect.Location = new System.Drawing.Point(184, 37);
            this.sCommandSelect.Name = "sCommandSelect";
            this.sCommandSelect.Size = new System.Drawing.Size(157, 28);
            this.sCommandSelect.Sorted = true;
            this.sCommandSelect.TabIndex = 29;
            this.sCommandSelect.SelectedIndexChanged += new System.EventHandler(this.sCommandSelect_SelectedIndexChanged);
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
            this.sStatus.Size = new System.Drawing.Size(288, 22);
            this.sStatus.TabIndex = 28;
            this.sStatus.Text = "Server Status";
            this.sStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CloseServer
            // 
            this.CloseServer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseServer.BackColor = System.Drawing.Color.Transparent;
            this.CloseServer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.CloseServer.FlatAppearance.BorderSize = 0;
            this.CloseServer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.CloseServer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseServer.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CloseServer.ForeColor = System.Drawing.Color.Transparent;
            this.CloseServer.Image = global::Minecraft_Server_Manager.Properties.Resources.close;
            this.CloseServer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CloseServer.Location = new System.Drawing.Point(807, -1);
            this.CloseServer.Name = "CloseServer";
            this.CloseServer.Size = new System.Drawing.Size(30, 30);
            this.CloseServer.TabIndex = 21;
            this.CloseServer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CloseServer.UseVisualStyleBackColor = false;
            this.CloseServer.Click += new System.EventHandler(this.CloseServer_Click);
            // 
            // sCustomCommandRun
            // 
            this.sCustomCommandRun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sCustomCommandRun.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.sCustomCommandRun.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.sCustomCommandRun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sCustomCommandRun.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sCustomCommandRun.ForeColor = System.Drawing.Color.Transparent;
            this.sCustomCommandRun.Image = ((System.Drawing.Image)(resources.GetObject("sCustomCommandRun.Image")));
            this.sCustomCommandRun.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.sCustomCommandRun.Location = new System.Drawing.Point(752, 173);
            this.sCustomCommandRun.Name = "sCustomCommandRun";
            this.sCustomCommandRun.Size = new System.Drawing.Size(80, 30);
            this.sCustomCommandRun.TabIndex = 26;
            this.sCustomCommandRun.Text = "Run";
            this.sCustomCommandRun.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.sCustomCommandRun.UseVisualStyleBackColor = false;
            this.sCustomCommandRun.Click += new System.EventHandler(this.sCustomCommandRun_Click);
            // 
            // sCustomCommand
            // 
            this.sCustomCommand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sCustomCommand.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sCustomCommand.Location = new System.Drawing.Point(174, 175);
            this.sCustomCommand.Name = "sCustomCommand";
            this.sCustomCommand.Size = new System.Drawing.Size(536, 26);
            this.sCustomCommand.TabIndex = 25;
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
            this.sBox.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.sBox.Size = new System.Drawing.Size(658, 122);
            this.sBox.TabIndex = 24;
            this.sBox.TabStop = false;
            // 
            // command_Teleport1
            // 
            this.command_Teleport1.BackColor = System.Drawing.Color.Transparent;
            this.command_Teleport1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.command_Teleport1.ForeColor = System.Drawing.Color.White;
            this.command_Teleport1.Location = new System.Drawing.Point(7, 11);
            this.command_Teleport1.Margin = new System.Windows.Forms.Padding(0);
            this.command_Teleport1.Name = "command_Teleport1";
            this.command_Teleport1.Size = new System.Drawing.Size(650, 97);
            this.command_Teleport1.TabIndex = 2;
            // 
            // command_Kick1
            // 
            this.command_Kick1.BackColor = System.Drawing.Color.Transparent;
            this.command_Kick1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.command_Kick1.ForeColor = System.Drawing.Color.White;
            this.command_Kick1.Location = new System.Drawing.Point(7, 11);
            this.command_Kick1.Margin = new System.Windows.Forms.Padding(0);
            this.command_Kick1.Name = "command_Kick1";
            this.command_Kick1.Size = new System.Drawing.Size(650, 97);
            this.command_Kick1.TabIndex = 1;
            // 
            // command_GameMode1
            // 
            this.command_GameMode1.BackColor = System.Drawing.Color.Transparent;
            this.command_GameMode1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.command_GameMode1.ForeColor = System.Drawing.Color.White;
            this.command_GameMode1.Location = new System.Drawing.Point(7, 11);
            this.command_GameMode1.Margin = new System.Windows.Forms.Padding(4);
            this.command_GameMode1.Name = "command_GameMode1";
            this.command_GameMode1.Size = new System.Drawing.Size(650, 97);
            this.command_GameMode1.TabIndex = 0;
            // 
            // sPlayers
            // 
            this.sPlayers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.sPlayers.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sPlayers.FormattingEnabled = true;
            this.sPlayers.ItemHeight = 20;
            this.sPlayers.Location = new System.Drawing.Point(5, 37);
            this.sPlayers.Name = "sPlayers";
            this.sPlayers.Size = new System.Drawing.Size(153, 164);
            this.sPlayers.Sorted = true;
            this.sPlayers.TabIndex = 23;
            // 
            // sName
            // 
            this.sName.BackColor = System.Drawing.Color.Transparent;
            this.sName.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sName.ForeColor = System.Drawing.Color.White;
            this.sName.Location = new System.Drawing.Point(5, 5);
            this.sName.Name = "sName";
            this.sName.Size = new System.Drawing.Size(264, 22);
            this.sName.TabIndex = 22;
            this.sName.Text = "Server Name";
            // 
            // Favorites
            // 
            this.Favorites.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Favorites.BackColor = System.Drawing.Color.Transparent;
            this.Favorites.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.Favorites.FlatAppearance.BorderSize = 0;
            this.Favorites.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.Favorites.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Favorites.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Favorites.ForeColor = System.Drawing.Color.Transparent;
            this.Favorites.Image = global::Minecraft_Server_Manager.Properties.Resources.library;
            this.Favorites.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Favorites.Location = new System.Drawing.Point(716, 173);
            this.Favorites.Name = "Favorites";
            this.Favorites.Size = new System.Drawing.Size(30, 30);
            this.Favorites.TabIndex = 30;
            this.Favorites.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Favorites.UseVisualStyleBackColor = false;
            this.Favorites.Click += new System.EventHandler(this.Favorites_Click);
            // 
            // ServerCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.Favorites);
            this.Controls.Add(this.sCommandSelect);
            this.Controls.Add(this.sStatus);
            this.Controls.Add(this.CloseServer);
            this.Controls.Add(this.sCustomCommandRun);
            this.Controls.Add(this.sCustomCommand);
            this.Controls.Add(this.sBox);
            this.Controls.Add(this.sPlayers);
            this.Controls.Add(this.sName);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ServerCard";
            this.Size = new System.Drawing.Size(838, 208);
            this.MouseEnter += new System.EventHandler(this.ServerCard_MouseEnter);
            this.sBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ComboBox sCommandSelect;
        public System.Windows.Forms.Label sStatus;
        public System.Windows.Forms.Button CloseServer;
        public System.Windows.Forms.Button sCustomCommandRun;
        public System.Windows.Forms.TextBox sCustomCommand;
        public System.Windows.Forms.GroupBox sBox;
        public System.Windows.Forms.ListBox sPlayers;
        public System.Windows.Forms.Label sName;
        public Commands.Command_Teleport command_Teleport1;
        public Commands.Command_Kick command_Kick1;
        public Commands.Command_GameMode command_GameMode1;
        public System.Windows.Forms.Button Favorites;
        public Server sServer;
        public void updateValues()
        {

        }
    }
}
