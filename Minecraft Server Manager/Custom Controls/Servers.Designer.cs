
namespace Minecraft_Server_Manager.Custom_Controls
{
    partial class Servers
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
            this.ServerListBox = new System.Windows.Forms.ListBox();
            this.Search_Input = new System.Windows.Forms.TextBox();
            this.SearchPlaceholder = new System.Windows.Forms.Label();
            this.CreateServer = new System.Windows.Forms.Button();
            this.StartServer = new System.Windows.Forms.Button();
            this.ServerCardsArea = new System.Windows.Forms.FlowLayoutPanel();
            this.serverSettings = new Minecraft_Server_Manager.Custom_Controls.ServerSettings();
            this.SuspendLayout();
            // 
            // ServerListBox
            // 
            this.ServerListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ServerListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ServerListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ServerListBox.ForeColor = System.Drawing.Color.White;
            this.ServerListBox.FormattingEnabled = true;
            this.ServerListBox.ItemHeight = 20;
            this.ServerListBox.Location = new System.Drawing.Point(0, 81);
            this.ServerListBox.Name = "ServerListBox";
            this.ServerListBox.Size = new System.Drawing.Size(300, 780);
            this.ServerListBox.TabIndex = 14;
            this.ServerListBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.ServerListBox_DrawItem);
            this.ServerListBox.DoubleClick += new System.EventHandler(this.ServerListBox_DoubleClick);
            // 
            // Search_Input
            // 
            this.Search_Input.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.Search_Input.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Search_Input.ForeColor = System.Drawing.Color.White;
            this.Search_Input.Location = new System.Drawing.Point(0, 46);
            this.Search_Input.Name = "Search_Input";
            this.Search_Input.Size = new System.Drawing.Size(300, 26);
            this.Search_Input.TabIndex = 15;
            this.Search_Input.TextChanged += new System.EventHandler(this.Search_Input_TextChanged);
            this.Search_Input.Enter += new System.EventHandler(this.Search_Input_Enter);
            this.Search_Input.Leave += new System.EventHandler(this.Search_Input_Leave);
            // 
            // SearchPlaceholder
            // 
            this.SearchPlaceholder.AutoSize = true;
            this.SearchPlaceholder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.SearchPlaceholder.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.SearchPlaceholder.ForeColor = System.Drawing.Color.White;
            this.SearchPlaceholder.Location = new System.Drawing.Point(3, 49);
            this.SearchPlaceholder.Name = "SearchPlaceholder";
            this.SearchPlaceholder.Size = new System.Drawing.Size(52, 18);
            this.SearchPlaceholder.TabIndex = 16;
            this.SearchPlaceholder.Text = "Suche";
            // 
            // CreateServer
            // 
            this.CreateServer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.CreateServer.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.CreateServer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateServer.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CreateServer.Image = global::Minecraft_Server_Manager.Properties.Resources.add;
            this.CreateServer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CreateServer.Location = new System.Drawing.Point(0, 3);
            this.CreateServer.Name = "CreateServer";
            this.CreateServer.Size = new System.Drawing.Size(140, 35);
            this.CreateServer.TabIndex = 17;
            this.CreateServer.Text = "Neu";
            this.CreateServer.UseVisualStyleBackColor = false;
            this.CreateServer.Click += new System.EventHandler(this.CreateServer_Click);
            // 
            // StartServer
            // 
            this.StartServer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.StartServer.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.StartServer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartServer.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.StartServer.Image = global::Minecraft_Server_Manager.Properties.Resources.start;
            this.StartServer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.StartServer.Location = new System.Drawing.Point(160, 3);
            this.StartServer.Name = "StartServer";
            this.StartServer.Size = new System.Drawing.Size(140, 35);
            this.StartServer.TabIndex = 18;
            this.StartServer.Text = "Start";
            this.StartServer.UseVisualStyleBackColor = false;
            this.StartServer.Click += new System.EventHandler(this.StartServer_Click);
            // 
            // ServerCardsArea
            // 
            this.ServerCardsArea.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ServerCardsArea.AutoScroll = true;
            this.ServerCardsArea.Location = new System.Drawing.Point(307, 0);
            this.ServerCardsArea.Name = "ServerCardsArea";
            this.ServerCardsArea.Size = new System.Drawing.Size(852, 863);
            this.ServerCardsArea.TabIndex = 19;
            // 
            // serverSettings
            // 
            this.serverSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.serverSettings.BackColor = System.Drawing.Color.Transparent;
            this.serverSettings.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.serverSettings.ForeColor = System.Drawing.Color.White;
            this.serverSettings.Location = new System.Drawing.Point(307, 0);
            this.serverSettings.Margin = new System.Windows.Forms.Padding(4);
            this.serverSettings.Name = "serverSettings";
            this.serverSettings.Size = new System.Drawing.Size(852, 863);
            this.serverSettings.TabIndex = 20;
            this.serverSettings.Visible = false;
            // 
            // Servers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.ServerListBox);
            this.Controls.Add(this.ServerCardsArea);
            this.Controls.Add(this.StartServer);
            this.Controls.Add(this.CreateServer);
            this.Controls.Add(this.SearchPlaceholder);
            this.Controls.Add(this.Search_Input);
            this.Controls.Add(this.serverSettings);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Servers";
            this.Size = new System.Drawing.Size(1159, 863);
            this.Load += new System.EventHandler(this.Servers_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ListBox ServerListBox;
        public System.Windows.Forms.TextBox Search_Input;
        public System.Windows.Forms.Label SearchPlaceholder;
        public System.Windows.Forms.Button CreateServer;
        public System.Windows.Forms.Button StartServer;
        public System.Windows.Forms.FlowLayoutPanel ServerCardsArea;
        public ServerSettings serverSettings;
    }
}
