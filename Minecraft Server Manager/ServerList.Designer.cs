
namespace Minecraft_Server_Manager.Properties
{
    partial class ServerList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServerList));
            this.label1 = new System.Windows.Forms.Label();
            this.StartServer = new System.Windows.Forms.Button();
            this.NewServer = new System.Windows.Forms.Button();
            this.serverListView = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "Server Liste";
            // 
            // StartServer
            // 
            this.StartServer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.StartServer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.StartServer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.StartServer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.StartServer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartServer.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.StartServer.ForeColor = System.Drawing.Color.Transparent;
            this.StartServer.Image = ((System.Drawing.Image)(resources.GetObject("StartServer.Image")));
            this.StartServer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.StartServer.Location = new System.Drawing.Point(348, 4);
            this.StartServer.Name = "StartServer";
            this.StartServer.Size = new System.Drawing.Size(76, 34);
            this.StartServer.TabIndex = 5;
            this.StartServer.Text = "Start";
            this.StartServer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.StartServer.UseVisualStyleBackColor = false;
            this.StartServer.Click += new System.EventHandler(this.StartServer_Click);
            // 
            // NewServer
            // 
            this.NewServer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NewServer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.NewServer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.NewServer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.NewServer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewServer.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NewServer.ForeColor = System.Drawing.Color.Transparent;
            this.NewServer.Image = ((System.Drawing.Image)(resources.GetObject("NewServer.Image")));
            this.NewServer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NewServer.Location = new System.Drawing.Point(266, 3);
            this.NewServer.Name = "NewServer";
            this.NewServer.Size = new System.Drawing.Size(76, 34);
            this.NewServer.TabIndex = 4;
            this.NewServer.Text = "Neu";
            this.NewServer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.NewServer.UseVisualStyleBackColor = false;
            // 
            // serverListView
            // 
            this.serverListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.serverListView.FormattingEnabled = true;
            this.serverListView.ItemHeight = 15;
            this.serverListView.Items.AddRange(new object[] {
            "SOMETHING"});
            this.serverListView.Location = new System.Drawing.Point(5, 45);
            this.serverListView.Name = "serverListView";
            this.serverListView.Size = new System.Drawing.Size(419, 304);
            this.serverListView.TabIndex = 6;
            // 
            // ServerList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.Controls.Add(this.serverListView);
            this.Controls.Add(this.StartServer);
            this.Controls.Add(this.NewServer);
            this.Controls.Add(this.label1);
            this.Name = "ServerList";
            this.Size = new System.Drawing.Size(429, 355);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button StartServer;
        private System.Windows.Forms.Button NewServer;
        public System.Windows.Forms.ListBox serverListView;
    }
}
