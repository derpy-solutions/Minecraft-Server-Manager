
namespace Minecraft_Server_Manager
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ToolBar = new System.Windows.Forms.Panel();
            this.UpdateNotification = new System.Windows.Forms.PictureBox();
            this.einstellungenTab = new System.Windows.Forms.Button();
            this.serverListTab = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.einstellungen = new Minecraft_Server_Manager.Einstellungen();
            this.FilterInput = new System.Windows.Forms.TextBox();
            this.serverListView = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.StartServer = new System.Windows.Forms.Button();
            this.NewServer = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.RunLoop = new System.ComponentModel.BackgroundWorker();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.ToolBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UpdateNotification)).BeginInit();
            this.SuspendLayout();
            // 
            // ToolBar
            // 
            this.ToolBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ToolBar.AutoScroll = true;
            this.ToolBar.Controls.Add(this.UpdateNotification);
            this.ToolBar.Controls.Add(this.einstellungenTab);
            this.ToolBar.Controls.Add(this.serverListTab);
            this.ToolBar.Location = new System.Drawing.Point(0, 0);
            this.ToolBar.Name = "ToolBar";
            this.ToolBar.Size = new System.Drawing.Size(55, 794);
            this.ToolBar.TabIndex = 10;
            // 
            // UpdateNotification
            // 
            this.UpdateNotification.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.UpdateNotification.Image = ((System.Drawing.Image)(resources.GetObject("UpdateNotification.Image")));
            this.UpdateNotification.Location = new System.Drawing.Point(12, 752);
            this.UpdateNotification.Name = "UpdateNotification";
            this.UpdateNotification.Size = new System.Drawing.Size(30, 30);
            this.UpdateNotification.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.UpdateNotification.TabIndex = 7;
            this.UpdateNotification.TabStop = false;
            // 
            // einstellungenTab
            // 
            this.einstellungenTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.einstellungenTab.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.einstellungenTab.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.einstellungenTab.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.einstellungenTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.einstellungenTab.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.einstellungenTab.ForeColor = System.Drawing.Color.Transparent;
            this.einstellungenTab.Image = ((System.Drawing.Image)(resources.GetObject("einstellungenTab.Image")));
            this.einstellungenTab.Location = new System.Drawing.Point(0, 55);
            this.einstellungenTab.Name = "einstellungenTab";
            this.einstellungenTab.Size = new System.Drawing.Size(55, 55);
            this.einstellungenTab.TabIndex = 6;
            this.einstellungenTab.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.einstellungenTab.UseVisualStyleBackColor = false;
            this.einstellungenTab.Click += new System.EventHandler(this.einstellungenTab_Click);
            // 
            // serverListTab
            // 
            this.serverListTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.serverListTab.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.serverListTab.FlatAppearance.BorderSize = 0;
            this.serverListTab.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.serverListTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.serverListTab.ForeColor = System.Drawing.Color.Transparent;
            this.serverListTab.Image = ((System.Drawing.Image)(resources.GetObject("serverListTab.Image")));
            this.serverListTab.Location = new System.Drawing.Point(0, 0);
            this.serverListTab.Name = "serverListTab";
            this.serverListTab.Size = new System.Drawing.Size(55, 55);
            this.serverListTab.TabIndex = 5;
            this.serverListTab.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.serverListTab.UseVisualStyleBackColor = false;
            this.serverListTab.Click += new System.EventHandler(this.serverListTab_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.AutoScroll = true;
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Location = new System.Drawing.Point(518, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 0);
            this.panel1.TabIndex = 9;
            // 
            // einstellungen
            // 
            this.einstellungen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.einstellungen.AutoScroll = true;
            this.einstellungen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.einstellungen.Location = new System.Drawing.Point(56, 0);
            this.einstellungen.MinimumSize = new System.Drawing.Size(429, 366);
            this.einstellungen.Name = "einstellungen";
            this.einstellungen.Size = new System.Drawing.Size(1299, 794);
            this.einstellungen.TabIndex = 0;
            this.einstellungen.Visible = false;
            // 
            // FilterInput
            // 
            this.FilterInput.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FilterInput.Location = new System.Drawing.Point(61, 53);
            this.FilterInput.Name = "FilterInput";
            this.FilterInput.Size = new System.Drawing.Size(315, 26);
            this.FilterInput.TabIndex = 10;
            this.FilterInput.TextChanged += new System.EventHandler(this.FilterInput_TextChanged);
            // 
            // serverListView
            // 
            this.serverListView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.serverListView.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.serverListView.FormattingEnabled = true;
            this.serverListView.ItemHeight = 20;
            this.serverListView.Location = new System.Drawing.Point(61, 84);
            this.serverListView.Name = "serverListView";
            this.serverListView.Size = new System.Drawing.Size(315, 704);
            this.serverListView.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(61, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 30);
            this.label1.TabIndex = 8;
            this.label1.Text = "Server Liste";
            // 
            // StartServer
            // 
            this.StartServer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.StartServer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.StartServer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.StartServer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartServer.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.StartServer.ForeColor = System.Drawing.Color.Transparent;
            this.StartServer.Image = ((System.Drawing.Image)(resources.GetObject("StartServer.Image")));
            this.StartServer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.StartServer.Location = new System.Drawing.Point(300, 6);
            this.StartServer.Name = "StartServer";
            this.StartServer.Size = new System.Drawing.Size(76, 34);
            this.StartServer.TabIndex = 7;
            this.StartServer.Text = "Start";
            this.StartServer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.StartServer.UseVisualStyleBackColor = false;
            this.StartServer.Click += new System.EventHandler(this.StartServer_Click_1);
            // 
            // NewServer
            // 
            this.NewServer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.NewServer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.NewServer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.NewServer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewServer.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NewServer.ForeColor = System.Drawing.Color.Transparent;
            this.NewServer.Image = ((System.Drawing.Image)(resources.GetObject("NewServer.Image")));
            this.NewServer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NewServer.Location = new System.Drawing.Point(218, 6);
            this.NewServer.Name = "NewServer";
            this.NewServer.Size = new System.Drawing.Size(76, 34);
            this.NewServer.TabIndex = 6;
            this.NewServer.Text = "Neu";
            this.NewServer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.NewServer.UseVisualStyleBackColor = false;
            this.NewServer.Click += new System.EventHandler(this.NewServer_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(382, 5);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(973, 785);
            this.flowLayoutPanel1.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Location = new System.Drawing.Point(53, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2, 794);
            this.panel2.TabIndex = 2;
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 10000;
            this.toolTip1.InitialDelay = 50;
            this.toolTip1.ReshowDelay = 100;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(1356, 794);
            this.Controls.Add(this.einstellungen);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.NewServer);
            this.Controls.Add(this.StartServer);
            this.Controls.Add(this.serverListView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.FilterInput);
            this.Controls.Add(this.ToolBar);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1250, 253);
            this.Name = "Form1";
            this.Text = "Minecraft Server Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ToolBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UpdateNotification)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel ToolBar;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Einstellungen einstellungen;
        private System.Windows.Forms.Button serverListTab;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button einstellungenTab;
        private System.Windows.Forms.Button StartServer;
        private System.Windows.Forms.Button NewServer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox serverListView;
        private System.Windows.Forms.TextBox FilterInput;
        private System.ComponentModel.BackgroundWorker RunLoop;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox UpdateNotification;
    }
}

