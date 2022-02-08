
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
            this.einstellungenTab = new System.Windows.Forms.Button();
            this.serverListTab = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TabArea = new System.Windows.Forms.Panel();
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
            this.TabArea.SuspendLayout();
            this.SuspendLayout();
            // 
            // ToolBar
            // 
            this.ToolBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ToolBar.AutoScroll = true;
            this.ToolBar.Controls.Add(this.einstellungenTab);
            this.ToolBar.Controls.Add(this.serverListTab);
            this.ToolBar.Location = new System.Drawing.Point(0, 0);
            this.ToolBar.Name = "ToolBar";
            this.ToolBar.Size = new System.Drawing.Size(55, 835);
            this.ToolBar.TabIndex = 10;
            // 
            // einstellungenTab
            // 
            this.einstellungenTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.einstellungenTab.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.einstellungenTab.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.einstellungenTab.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.einstellungenTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.einstellungenTab.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
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
            this.serverListTab.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
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
            // TabArea
            // 
            this.TabArea.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.TabArea.AutoScroll = true;
            this.TabArea.Controls.Add(this.einstellungen);
            this.TabArea.Controls.Add(this.FilterInput);
            this.TabArea.Controls.Add(this.serverListView);
            this.TabArea.Controls.Add(this.label1);
            this.TabArea.Controls.Add(this.StartServer);
            this.TabArea.Controls.Add(this.NewServer);
            this.TabArea.Location = new System.Drawing.Point(55, 0);
            this.TabArea.Name = "TabArea";
            this.TabArea.Size = new System.Drawing.Size(440, 835);
            this.TabArea.TabIndex = 11;
            // 
            // einstellungen
            // 
            this.einstellungen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.einstellungen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.einstellungen.Location = new System.Drawing.Point(0, 0);
            this.einstellungen.Name = "einstellungen";
            this.einstellungen.Size = new System.Drawing.Size(440, 835);
            this.einstellungen.TabIndex = 0;
            this.einstellungen.Visible = false;
            // 
            // FilterInput
            // 
            this.FilterInput.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FilterInput.Location = new System.Drawing.Point(5, 55);
            this.FilterInput.Name = "FilterInput";
            this.FilterInput.Size = new System.Drawing.Size(434, 26);
            this.FilterInput.TabIndex = 10;
            this.FilterInput.TextChanged += new System.EventHandler(this.FilterInput_TextChanged);
            // 
            // serverListView
            // 
            this.serverListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.serverListView.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.serverListView.FormattingEnabled = true;
            this.serverListView.ItemHeight = 21;
            this.serverListView.Location = new System.Drawing.Point(5, 90);
            this.serverListView.Name = "serverListView";
            this.serverListView.Size = new System.Drawing.Size(434, 718);
            this.serverListView.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 30);
            this.label1.TabIndex = 8;
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
            this.StartServer.Location = new System.Drawing.Point(282, 5);
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
            this.NewServer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NewServer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.NewServer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.NewServer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.NewServer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewServer.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NewServer.ForeColor = System.Drawing.Color.Transparent;
            this.NewServer.Image = ((System.Drawing.Image)(resources.GetObject("NewServer.Image")));
            this.NewServer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NewServer.Location = new System.Drawing.Point(364, 5);
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
            this.flowLayoutPanel1.Location = new System.Drawing.Point(500, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(689, 835);
            this.flowLayoutPanel1.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Location = new System.Drawing.Point(53, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2, 835);
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
            this.ClientSize = new System.Drawing.Size(1196, 835);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.ToolBar);
            this.Controls.Add(this.TabArea);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Minecraft Server Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ToolBar.ResumeLayout(false);
            this.TabArea.ResumeLayout(false);
            this.TabArea.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel ToolBar;
        private System.Windows.Forms.Panel TabArea;
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
    }
}

