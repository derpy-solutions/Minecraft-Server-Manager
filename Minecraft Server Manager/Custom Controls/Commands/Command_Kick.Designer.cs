
namespace Minecraft_Server_Manager.Custom_Controls.Commands
{
    partial class Command_Kick
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Command_Kick));
            this.Run = new System.Windows.Forms.Button();
            this.of_Server = new System.Windows.Forms.Label();
            this.Kick_Label = new System.Windows.Forms.Label();
            this.Player = new System.Windows.Forms.ComboBox();
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
            this.Run.Location = new System.Drawing.Point(576, 0);
            this.Run.Name = "Run";
            this.Run.Size = new System.Drawing.Size(80, 80);
            this.Run.TabIndex = 32;
            this.Run.Text = "Run";
            this.Run.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Run.UseVisualStyleBackColor = false;
            this.Run.Click += new System.EventHandler(this.Run_Click);
            // 
            // of_Server
            // 
            this.of_Server.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.of_Server.AutoSize = true;
            this.of_Server.BackColor = System.Drawing.Color.Transparent;
            this.of_Server.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.of_Server.ForeColor = System.Drawing.Color.White;
            this.of_Server.Location = new System.Drawing.Point(209, 4);
            this.of_Server.Margin = new System.Windows.Forms.Padding(0);
            this.of_Server.Name = "of_Server";
            this.of_Server.Size = new System.Drawing.Size(97, 20);
            this.of_Server.TabIndex = 31;
            this.of_Server.Text = "vom Server.";
            // 
            // Kick_Label
            // 
            this.Kick_Label.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Kick_Label.AutoSize = true;
            this.Kick_Label.BackColor = System.Drawing.Color.Transparent;
            this.Kick_Label.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Kick_Label.ForeColor = System.Drawing.Color.White;
            this.Kick_Label.Location = new System.Drawing.Point(0, 4);
            this.Kick_Label.Margin = new System.Windows.Forms.Padding(0);
            this.Kick_Label.Name = "Kick_Label";
            this.Kick_Label.Size = new System.Drawing.Size(49, 20);
            this.Kick_Label.TabIndex = 30;
            this.Kick_Label.Text = "Kicke";
            // 
            // Player
            // 
            this.Player.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Player.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Player.FormattingEnabled = true;
            this.Player.Location = new System.Drawing.Point(49, 0);
            this.Player.Margin = new System.Windows.Forms.Padding(0);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(160, 28);
            this.Player.Sorted = true;
            this.Player.TabIndex = 29;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.flowLayoutPanel1.Controls.Add(this.Kick_Label);
            this.flowLayoutPanel1.Controls.Add(this.Player);
            this.flowLayoutPanel1.Controls.Add(this.of_Server);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 25);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(574, 30);
            this.flowLayoutPanel1.TabIndex = 40;
            // 
            // Command_Kick
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.Run);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "Command_Kick";
            this.Size = new System.Drawing.Size(655, 80);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Button Run;
        private System.Windows.Forms.Label of_Server;
        private System.Windows.Forms.Label Kick_Label;
        public System.Windows.Forms.ComboBox Player;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}
