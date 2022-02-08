
namespace Minecraft_Server_Manager
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
            this.sCustomCommandRun = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.player = new System.Windows.Forms.ComboBox();
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
            this.sCustomCommandRun.Location = new System.Drawing.Point(343, 27);
            this.sCustomCommandRun.Name = "sCustomCommandRun";
            this.sCustomCommandRun.Size = new System.Drawing.Size(76, 28);
            this.sCustomCommandRun.TabIndex = 12;
            this.sCustomCommandRun.Text = "Run";
            this.sCustomCommandRun.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.sCustomCommandRun.UseVisualStyleBackColor = false;
            this.sCustomCommandRun.Click += new System.EventHandler(this.sCustomCommandRun_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(237, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "vom Server!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Kicke";
            // 
            // player
            // 
            this.player.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.player.FormattingEnabled = true;
            this.player.Location = new System.Drawing.Point(55, 28);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(176, 28);
            this.player.TabIndex = 8;
            // 
            // Command_Kick
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.sCustomCommandRun);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.player);
            this.Name = "Command_Kick";
            this.Size = new System.Drawing.Size(650, 85);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button sCustomCommandRun;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox player;
    }
}
