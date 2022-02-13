
namespace Minecraft_Server_Manager.Custom_Controls
{
    partial class TitleBar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TitleBar));
            this.TopBar_Fullscreen = new System.Windows.Forms.Button();
            this.TopBar_Minimize = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TopBar_Close = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TopBar = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.TopBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopBar_Fullscreen
            // 
            this.TopBar_Fullscreen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TopBar_Fullscreen.BackColor = System.Drawing.Color.Transparent;
            this.TopBar_Fullscreen.FlatAppearance.BorderSize = 0;
            this.TopBar_Fullscreen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.TopBar_Fullscreen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.TopBar_Fullscreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TopBar_Fullscreen.Image = ((System.Drawing.Image)(resources.GetObject("TopBar_Fullscreen.Image")));
            this.TopBar_Fullscreen.Location = new System.Drawing.Point(833, -3);
            this.TopBar_Fullscreen.Margin = new System.Windows.Forms.Padding(0);
            this.TopBar_Fullscreen.Name = "TopBar_Fullscreen";
            this.TopBar_Fullscreen.Size = new System.Drawing.Size(50, 30);
            this.TopBar_Fullscreen.TabIndex = 3;
            this.TopBar_Fullscreen.UseVisualStyleBackColor = false;
            this.TopBar_Fullscreen.Click += new System.EventHandler(this.TopBar_Fullscreen_Click);
            // 
            // TopBar_Minimize
            // 
            this.TopBar_Minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TopBar_Minimize.BackColor = System.Drawing.Color.Transparent;
            this.TopBar_Minimize.FlatAppearance.BorderSize = 0;
            this.TopBar_Minimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.TopBar_Minimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.TopBar_Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TopBar_Minimize.Image = global::Minecraft_Server_Manager.Properties.Resources.minimize1;
            this.TopBar_Minimize.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.TopBar_Minimize.Location = new System.Drawing.Point(783, -3);
            this.TopBar_Minimize.Margin = new System.Windows.Forms.Padding(0);
            this.TopBar_Minimize.Name = "TopBar_Minimize";
            this.TopBar_Minimize.Size = new System.Drawing.Size(50, 30);
            this.TopBar_Minimize.TabIndex = 2;
            this.TopBar_Minimize.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.TopBar_Minimize.UseVisualStyleBackColor = false;
            this.TopBar_Minimize.Click += new System.EventHandler(this.TopBar_Minimize_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 2);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Minecraft Server Manager";
            this.label2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainMove_MouseDown);
            this.label2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainMove_MouseMove);
            this.label2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainMove_MouseUp);
            // 
            // TopBar_Close
            // 
            this.TopBar_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TopBar_Close.BackColor = System.Drawing.Color.Transparent;
            this.TopBar_Close.FlatAppearance.BorderSize = 0;
            this.TopBar_Close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.TopBar_Close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.TopBar_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TopBar_Close.Image = global::Minecraft_Server_Manager.Properties.Resources.close;
            this.TopBar_Close.Location = new System.Drawing.Point(883, -3);
            this.TopBar_Close.Margin = new System.Windows.Forms.Padding(0);
            this.TopBar_Close.Name = "TopBar_Close";
            this.TopBar_Close.Size = new System.Drawing.Size(50, 30);
            this.TopBar_Close.TabIndex = 0;
            this.TopBar_Close.UseVisualStyleBackColor = false;
            this.TopBar_Close.Click += new System.EventHandler(this.TopBar_Close_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Minecraft_Server_Manager.Properties.Resources.derpy;
            this.pictureBox1.Location = new System.Drawing.Point(0, -2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainMove_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainMove_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainMove_MouseUp);
            // 
            // TopBar
            // 
            this.TopBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TopBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.TopBar.Controls.Add(this.TopBar_Fullscreen);
            this.TopBar.Controls.Add(this.TopBar_Minimize);
            this.TopBar.Controls.Add(this.label2);
            this.TopBar.Controls.Add(this.TopBar_Close);
            this.TopBar.Controls.Add(this.pictureBox1);
            this.TopBar.Location = new System.Drawing.Point(3, 3);
            this.TopBar.Margin = new System.Windows.Forms.Padding(0);
            this.TopBar.Name = "TopBar";
            this.TopBar.Size = new System.Drawing.Size(934, 27);
            this.TopBar.TabIndex = 10;
            this.TopBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainMove_MouseDown);
            this.TopBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainMove_MouseMove);
            this.TopBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainMove_MouseUp);
            // 
            // TitleBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.TopBar);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "TitleBar";
            this.Size = new System.Drawing.Size(937, 30);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.TopBar.ResumeLayout(false);
            this.TopBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button TopBar_Fullscreen;
        private System.Windows.Forms.Button TopBar_Minimize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button TopBar_Close;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel TopBar;
    }
}
