
namespace Minecraft_Server_Manager
{
    partial class Command_Teleport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Command_Teleport));
            this.player1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.player2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.sCustomCommandRun = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // player1
            // 
            this.player1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.player1.FormattingEnabled = true;
            this.player1.Location = new System.Drawing.Point(75, 28);
            this.player1.Name = "player1";
            this.player1.Size = new System.Drawing.Size(176, 28);
            this.player1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(5, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Teleport";
            // 
            // player2
            // 
            this.player2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.player2.FormattingEnabled = true;
            this.player2.Location = new System.Drawing.Point(285, 28);
            this.player2.Name = "player2";
            this.player2.Size = new System.Drawing.Size(176, 28);
            this.player2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(255, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "zu";
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
            this.sCustomCommandRun.Location = new System.Drawing.Point(467, 28);
            this.sCustomCommandRun.Name = "sCustomCommandRun";
            this.sCustomCommandRun.Size = new System.Drawing.Size(76, 28);
            this.sCustomCommandRun.TabIndex = 7;
            this.sCustomCommandRun.Text = "Run";
            this.sCustomCommandRun.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.sCustomCommandRun.UseVisualStyleBackColor = false;
            this.sCustomCommandRun.Click += new System.EventHandler(this.sCustomCommandRun_Click);
            // 
            // Command_Teleport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.sCustomCommandRun);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.player2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.player1);
            this.Name = "Command_Teleport";
            this.Size = new System.Drawing.Size(650, 85);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ComboBox player1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox player2;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button sCustomCommandRun;
    }
}
