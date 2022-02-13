
namespace Minecraft_Server_Manager
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.RunLoop = new System.ComponentModel.BackgroundWorker();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.sideBar1 = new Minecraft_Server_Manager.Custom_Controls.SideBar();
            this.ServersTab = new Minecraft_Server_Manager.Custom_Controls.Servers();
            this.SettingsTab = new Minecraft_Server_Manager.Custom_Controls.Settings();
            this.restartPopUp = new Minecraft_Server_Manager.Custom_Controls.RestartPopUp();
            this.SuspendLayout();
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 10000;
            this.toolTip1.InitialDelay = 50;
            this.toolTip1.ReshowDelay = 100;
            // 
            // sideBar1
            // 
            this.sideBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.sideBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.sideBar1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sideBar1.ForeColor = System.Drawing.Color.White;
            this.sideBar1.Location = new System.Drawing.Point(0, 0);
            this.sideBar1.Margin = new System.Windows.Forms.Padding(4);
            this.sideBar1.MaximumSize = new System.Drawing.Size(300, 1000000000);
            this.sideBar1.MinimumSize = new System.Drawing.Size(85, 200);
            this.sideBar1.Name = "sideBar1";
            this.sideBar1.Size = new System.Drawing.Size(85, 667);
            this.sideBar1.TabIndex = 17;
            // 
            // ServersTab
            // 
            this.ServersTab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ServersTab.BackColor = System.Drawing.Color.Transparent;
            this.ServersTab.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ServersTab.ForeColor = System.Drawing.Color.White;
            this.ServersTab.Location = new System.Drawing.Point(93, 10);
            this.ServersTab.Margin = new System.Windows.Forms.Padding(4);
            this.ServersTab.Name = "ServersTab";
            this.ServersTab.Size = new System.Drawing.Size(1176, 654);
            this.ServersTab.TabIndex = 19;
            // 
            // SettingsTab
            // 
            this.SettingsTab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SettingsTab.BackColor = System.Drawing.Color.Transparent;
            this.SettingsTab.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SettingsTab.ForeColor = System.Drawing.Color.White;
            this.SettingsTab.Location = new System.Drawing.Point(93, 13);
            this.SettingsTab.Margin = new System.Windows.Forms.Padding(4);
            this.SettingsTab.Name = "SettingsTab";
            this.SettingsTab.Size = new System.Drawing.Size(1163, 639);
            this.SettingsTab.TabIndex = 20;
            this.SettingsTab.Visible = false;
            // 
            // restartPopUp
            // 
            this.restartPopUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.restartPopUp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.restartPopUp.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.restartPopUp.Location = new System.Drawing.Point(588, 246);
            this.restartPopUp.Margin = new System.Windows.Forms.Padding(4);
            this.restartPopUp.Name = "restartPopUp";
            this.restartPopUp.Size = new System.Drawing.Size(517, 201);
            this.restartPopUp.TabIndex = 21;
            this.restartPopUp.Visible = false;
            this.restartPopUp.VisibleChanged += new System.EventHandler(this.restartPopUp_VisibleChanged);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(1269, 665);
            this.Controls.Add(this.restartPopUp);
            this.Controls.Add(this.sideBar1);
            this.Controls.Add(this.ServersTab);
            this.Controls.Add(this.SettingsTab);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1285, 375);
            this.Name = "Main";
            this.Text = "Minecraft Server Manager";
            this.Load += new System.EventHandler(this.Main_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Main_MouseClick);
            this.Resize += new System.EventHandler(this.Main_Resize);
            this.ResumeLayout(false);

        }

        #endregion
        public System.ComponentModel.BackgroundWorker RunLoop;
        public System.Windows.Forms.ToolTip toolTip1;
        private Custom_Controls.SideBar sideBar1;
        private Custom_Controls.Servers ServersTab;
        private Custom_Controls.Settings SettingsTab;
        private Custom_Controls.Servers servers1;
        private Custom_Controls.Settings settings1;
        public Custom_Controls.RestartPopUp restartPopUp;
    }
}