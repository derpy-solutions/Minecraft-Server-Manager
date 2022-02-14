
namespace Minecraft_Server_Manager.Custom_Controls.Commands
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
            this.Run = new System.Windows.Forms.Button();
            this.to = new System.Windows.Forms.Label();
            this.SetGamemode_Label = new System.Windows.Forms.Label();
            this.Player = new System.Windows.Forms.ComboBox();
            this.GameMode = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Run
            // 
            this.Run.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Run.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Run.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.Run.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Run.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Run.ForeColor = System.Drawing.Color.Transparent;
            this.Run.Image = ((System.Drawing.Image)(resources.GetObject("Run.Image")));
            this.Run.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Run.Location = new System.Drawing.Point(577, 0);
            this.Run.Name = "Run";
            this.Run.Size = new System.Drawing.Size(80, 80);
            this.Run.TabIndex = 36;
            this.Run.Text = "Run";
            this.Run.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Run.UseVisualStyleBackColor = false;
            this.Run.Click += new System.EventHandler(this.Run_Click);
            // 
            // to
            // 
            this.to.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.to.AutoSize = true;
            this.to.BackColor = System.Drawing.Color.Transparent;
            this.to.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.to.ForeColor = System.Drawing.Color.White;
            this.to.Location = new System.Drawing.Point(363, 4);
            this.to.Margin = new System.Windows.Forms.Padding(0);
            this.to.Name = "to";
            this.to.Size = new System.Drawing.Size(33, 20);
            this.to.TabIndex = 35;
            this.to.Text = "auf";
            // 
            // SetGamemode_Label
            // 
            this.SetGamemode_Label.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.SetGamemode_Label.AutoSize = true;
            this.SetGamemode_Label.BackColor = System.Drawing.Color.Transparent;
            this.SetGamemode_Label.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SetGamemode_Label.ForeColor = System.Drawing.Color.White;
            this.SetGamemode_Label.Location = new System.Drawing.Point(0, 4);
            this.SetGamemode_Label.Margin = new System.Windows.Forms.Padding(0);
            this.SetGamemode_Label.Name = "SetGamemode_Label";
            this.SetGamemode_Label.Size = new System.Drawing.Size(203, 20);
            this.SetGamemode_Label.TabIndex = 34;
            this.SetGamemode_Label.Text = "Setzte den Spielmodus von";
            // 
            // Player
            // 
            this.Player.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Player.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Player.FormattingEnabled = true;
            this.Player.Location = new System.Drawing.Point(203, 0);
            this.Player.Margin = new System.Windows.Forms.Padding(0);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(160, 28);
            this.Player.Sorted = true;
            this.Player.TabIndex = 33;
            // 
            // GameMode
            // 
            this.GameMode.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.GameMode.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GameMode.FormattingEnabled = true;
            this.GameMode.Location = new System.Drawing.Point(396, 0);
            this.GameMode.Margin = new System.Windows.Forms.Padding(0);
            this.GameMode.Name = "GameMode";
            this.GameMode.Size = new System.Drawing.Size(160, 28);
            this.GameMode.Sorted = true;
            this.GameMode.TabIndex = 37;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.flowLayoutPanel1.Controls.Add(this.SetGamemode_Label);
            this.flowLayoutPanel1.Controls.Add(this.Player);
            this.flowLayoutPanel1.Controls.Add(this.to);
            this.flowLayoutPanel1.Controls.Add(this.GameMode);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 25);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(574, 30);
            this.flowLayoutPanel1.TabIndex = 38;
            // 
            // Command_GameMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.Run);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Command_GameMode";
            this.Size = new System.Drawing.Size(655, 80);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button Run;
        private System.Windows.Forms.Label to;
        private System.Windows.Forms.Label SetGamemode_Label;
        public System.Windows.Forms.ComboBox Player;
        public System.Windows.Forms.ComboBox GameMode;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}
