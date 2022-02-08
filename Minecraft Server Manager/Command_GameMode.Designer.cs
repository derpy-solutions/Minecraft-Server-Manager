
namespace Minecraft_Server_Manager
{
    partial class Command_GameMode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Command_GameMode));
            this.sCustomCommandRun = new System.Windows.Forms.Button();
            this.player = new System.Windows.Forms.ComboBox();
            this.gamemode = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sCustomCommandRun
            // 
            this.sCustomCommandRun.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.sCustomCommandRun.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.sCustomCommandRun.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.sCustomCommandRun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sCustomCommandRun.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sCustomCommandRun.ForeColor = System.Drawing.Color.Transparent;
            this.sCustomCommandRun.Image = ((System.Drawing.Image)(resources.GetObject("sCustomCommandRun.Image")));
            this.sCustomCommandRun.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sCustomCommandRun.Location = new System.Drawing.Point(574, 25);
            this.sCustomCommandRun.Name = "sCustomCommandRun";
            this.sCustomCommandRun.Size = new System.Drawing.Size(76, 30);
            this.sCustomCommandRun.TabIndex = 6;
            this.sCustomCommandRun.Text = "Run";
            this.sCustomCommandRun.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.sCustomCommandRun.UseVisualStyleBackColor = false;
            this.sCustomCommandRun.Click += new System.EventHandler(this.sCustomCommandRun_Click);
            // 
            // player
            // 
            this.player.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.player.FormattingEnabled = true;
            this.player.Location = new System.Drawing.Point(220, 25);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(160, 28);
            this.player.TabIndex = 7;
            // 
            // gamemode
            // 
            this.gamemode.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gamemode.FormattingEnabled = true;
            this.gamemode.Items.AddRange(new object[] {
            "Kreativ Modus",
            "Überleben Modus",
            "Abenteuer Modus",
            "Zuschauer Modus"});
            this.gamemode.Location = new System.Drawing.Point(405, 26);
            this.gamemode.Name = "gamemode";
            this.gamemode.Size = new System.Drawing.Size(165, 28);
            this.gamemode.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Ändere den Spielmodus von";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(380, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "zu";
            // 
            // Command_GameMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gamemode);
            this.Controls.Add(this.player);
            this.Controls.Add(this.sCustomCommandRun);
            this.Name = "Command_GameMode";
            this.Size = new System.Drawing.Size(650, 80);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button sCustomCommandRun;
        public System.Windows.Forms.ComboBox player;
        public System.Windows.Forms.ComboBox gamemode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public ServerCardControl serverCard;
    }
}