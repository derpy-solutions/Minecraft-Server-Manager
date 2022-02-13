
namespace Minecraft_Server_Manager.Custom_Controls
{
    partial class FavoriteCommand
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
            this.Delete = new System.Windows.Forms.Button();
            this.Run = new System.Windows.Forms.Button();
            this.Command = new System.Windows.Forms.TextBox();
            this.CommandNameEdit = new System.Windows.Forms.TextBox();
            this.CommandName = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Delete
            // 
            this.Delete.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Delete.BackColor = System.Drawing.Color.Transparent;
            this.Delete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.Delete.FlatAppearance.BorderSize = 0;
            this.Delete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Delete.ForeColor = System.Drawing.Color.Transparent;
            this.Delete.Image = global::Minecraft_Server_Manager.Properties.Resources.delete;
            this.Delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Delete.Location = new System.Drawing.Point(611, 2);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(30, 30);
            this.Delete.TabIndex = 24;
            this.Delete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Run
            // 
            this.Run.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Run.BackColor = System.Drawing.Color.Transparent;
            this.Run.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.Run.FlatAppearance.BorderSize = 0;
            this.Run.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.Run.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Run.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Run.ForeColor = System.Drawing.Color.Transparent;
            this.Run.Image = global::Minecraft_Server_Manager.Properties.Resources.start;
            this.Run.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Run.Location = new System.Drawing.Point(647, 2);
            this.Run.Name = "Run";
            this.Run.Size = new System.Drawing.Size(30, 30);
            this.Run.TabIndex = 25;
            this.Run.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Run.UseVisualStyleBackColor = false;
            this.Run.Click += new System.EventHandler(this.Run_Click);
            // 
            // Command
            // 
            this.Command.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Command.Location = new System.Drawing.Point(182, 4);
            this.Command.Name = "Command";
            this.Command.Size = new System.Drawing.Size(423, 26);
            this.Command.TabIndex = 23;
            this.Command.TextChanged += new System.EventHandler(this.Command_TextChanged);
            // 
            // CommandNameEdit
            // 
            this.CommandNameEdit.Location = new System.Drawing.Point(0, 2);
            this.CommandNameEdit.Name = "CommandNameEdit";
            this.CommandNameEdit.Size = new System.Drawing.Size(172, 26);
            this.CommandNameEdit.TabIndex = 22;
            this.CommandNameEdit.Visible = false;
            this.CommandNameEdit.Leave += new System.EventHandler(this.CommandNameEdit_Leave);
            // 
            // CommandName
            // 
            this.CommandName.FlatAppearance.BorderSize = 0;
            this.CommandName.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.CommandName.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.CommandName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CommandName.Location = new System.Drawing.Point(0, 2);
            this.CommandName.Name = "CommandName";
            this.CommandName.Size = new System.Drawing.Size(173, 26);
            this.CommandName.TabIndex = 26;
            this.CommandName.Text = "Empty Command";
            this.CommandName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CommandName.UseVisualStyleBackColor = true;
            this.CommandName.Click += new System.EventHandler(this.CommandName_Click);
            // 
            // FavoriteCommand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.CommandName);
            this.Controls.Add(this.CommandNameEdit);
            this.Controls.Add(this.Command);
            this.Controls.Add(this.Run);
            this.Controls.Add(this.Delete);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "FavoriteCommand";
            this.Size = new System.Drawing.Size(680, 35);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Button Delete;
        public System.Windows.Forms.Button Run;
        public System.Windows.Forms.TextBox Command;
        private System.Windows.Forms.TextBox CommandNameEdit;
        public FavoriteCommands.Command favCommand;
        private System.Windows.Forms.Button CommandName;
    }
}
