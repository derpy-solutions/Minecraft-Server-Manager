
namespace Minecraft_Server_Manager.Custom_Controls
{
    partial class FavoritesMenu
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.FavoritesPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.Add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(45, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Favoriten";
            // 
            // FavoritesPanel
            // 
            this.FavoritesPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FavoritesPanel.AutoScroll = true;
            this.FavoritesPanel.Location = new System.Drawing.Point(9, 36);
            this.FavoritesPanel.Margin = new System.Windows.Forms.Padding(0);
            this.FavoritesPanel.Name = "FavoritesPanel";
            this.FavoritesPanel.Size = new System.Drawing.Size(700, 353);
            this.FavoritesPanel.TabIndex = 2;
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.Color.Transparent;
            this.Add.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.Add.FlatAppearance.BorderSize = 0;
            this.Add.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Add.ForeColor = System.Drawing.Color.Transparent;
            this.Add.Image = global::Minecraft_Server_Manager.Properties.Resources.add;
            this.Add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Add.Location = new System.Drawing.Point(9, 2);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(30, 30);
            this.Add.TabIndex = 24;
            this.Add.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.Run_Click);
            // 
            // FavoritesMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(720, 400);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.FavoritesPanel);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1000000, 900);
            this.MinimumSize = new System.Drawing.Size(715, 35);
            this.Name = "FavoritesMenu";
            this.Text = "FavoritesMenu";
            this.Deactivate += new System.EventHandler(this.FavoritesMenu_Deactivate);
            this.Load += new System.EventHandler(this.FavoritesMenu_Load);
            this.VisibleChanged += new System.EventHandler(this.FavoritesMenu_VisibleChanged);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FavoritesMenu_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.FlowLayoutPanel FavoritesPanel;
        public System.Windows.Forms.Button Add;
    }
}