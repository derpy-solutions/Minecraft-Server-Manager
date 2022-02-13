
namespace Minecraft_Server_Manager.Custom_Controls
{
    partial class ServerSettings
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
            this.Name_EditSave = new System.Windows.Forms.Button();
            this.Name_EditDiscard = new System.Windows.Forms.Button();
            this.Name_Edit = new System.Windows.Forms.TextBox();
            this.Delete = new System.Windows.Forms.Button();
            this.RAM_Amount = new System.Windows.Forms.NumericUpDown();
            this.ShowUI = new System.Windows.Forms.CheckBox();
            this.Discard = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.RAM_Unit = new System.Windows.Forms.ComboBox();
            this.RAM_Label = new System.Windows.Forms.Label();
            this.Name_Label = new System.Windows.Forms.Label();
            this.Close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.RAM_Amount)).BeginInit();
            this.SuspendLayout();
            // 
            // Name_EditSave
            // 
            this.Name_EditSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Name_EditSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.Name_EditSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.Name_EditSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Name_EditSave.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Name_EditSave.ForeColor = System.Drawing.Color.Transparent;
            this.Name_EditSave.Image = global::Minecraft_Server_Manager.Properties.Resources.save;
            this.Name_EditSave.Location = new System.Drawing.Point(363, 13);
            this.Name_EditSave.Margin = new System.Windows.Forms.Padding(4);
            this.Name_EditSave.Name = "Name_EditSave";
            this.Name_EditSave.Size = new System.Drawing.Size(36, 36);
            this.Name_EditSave.TabIndex = 35;
            this.Name_EditSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Name_EditSave.UseVisualStyleBackColor = false;
            this.Name_EditSave.Click += new System.EventHandler(this.Name_EditSave_Click);
            // 
            // Name_EditDiscard
            // 
            this.Name_EditDiscard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Name_EditDiscard.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.Name_EditDiscard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.Name_EditDiscard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Name_EditDiscard.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Name_EditDiscard.ForeColor = System.Drawing.Color.Transparent;
            this.Name_EditDiscard.Image = global::Minecraft_Server_Manager.Properties.Resources.stop;
            this.Name_EditDiscard.Location = new System.Drawing.Point(328, 13);
            this.Name_EditDiscard.Margin = new System.Windows.Forms.Padding(4);
            this.Name_EditDiscard.Name = "Name_EditDiscard";
            this.Name_EditDiscard.Size = new System.Drawing.Size(36, 36);
            this.Name_EditDiscard.TabIndex = 34;
            this.Name_EditDiscard.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Name_EditDiscard.UseVisualStyleBackColor = false;
            this.Name_EditDiscard.Click += new System.EventHandler(this.Name_EditDiscard_Click);
            // 
            // Name_Edit
            // 
            this.Name_Edit.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name_Edit.Location = new System.Drawing.Point(4, 12);
            this.Name_Edit.Name = "Name_Edit";
            this.Name_Edit.Size = new System.Drawing.Size(319, 37);
            this.Name_Edit.TabIndex = 33;
            // 
            // Delete
            // 
            this.Delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Delete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.Delete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Delete.ForeColor = System.Drawing.Color.Transparent;
            this.Delete.Image = global::Minecraft_Server_Manager.Properties.Resources.delete;
            this.Delete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Delete.Location = new System.Drawing.Point(4, 222);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(185, 42);
            this.Delete.TabIndex = 32;
            this.Delete.Text = "  Server Löschen";
            this.Delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // RAM_Amount
            // 
            this.RAM_Amount.Location = new System.Drawing.Point(21, 106);
            this.RAM_Amount.Name = "RAM_Amount";
            this.RAM_Amount.Size = new System.Drawing.Size(130, 26);
            this.RAM_Amount.TabIndex = 31;
            this.RAM_Amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.RAM_Amount.ThousandsSeparator = true;
            // 
            // ShowUI
            // 
            this.ShowUI.Appearance = System.Windows.Forms.Appearance.Button;
            this.ShowUI.AutoCheck = false;
            this.ShowUI.AutoSize = true;
            this.ShowUI.BackColor = System.Drawing.Color.Transparent;
            this.ShowUI.FlatAppearance.BorderSize = 0;
            this.ShowUI.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.ShowUI.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.ShowUI.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.ShowUI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowUI.ForeColor = System.Drawing.Color.White;
            this.ShowUI.Image = global::Minecraft_Server_Manager.Properties.Resources.checkbox_unchecked;
            this.ShowUI.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ShowUI.Location = new System.Drawing.Point(21, 164);
            this.ShowUI.Name = "ShowUI";
            this.ShowUI.Size = new System.Drawing.Size(191, 30);
            this.ShowUI.TabIndex = 30;
            this.ShowUI.Text = "Zeige Java Server UI";
            this.ShowUI.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ShowUI.UseVisualStyleBackColor = false;
            this.ShowUI.CheckedChanged += new System.EventHandler(this.ShowUI_CheckedChanged);
            this.ShowUI.CheckStateChanged += new System.EventHandler(this.ShowUI_CheckStateChanged);
            this.ShowUI.Click += new System.EventHandler(this.ShowUI_Click);
            // 
            // Discard
            // 
            this.Discard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Discard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Discard.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.Discard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.Discard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Discard.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Discard.ForeColor = System.Drawing.Color.Transparent;
            this.Discard.Image = global::Minecraft_Server_Manager.Properties.Resources.stop;
            this.Discard.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Discard.Location = new System.Drawing.Point(386, 222);
            this.Discard.Name = "Discard";
            this.Discard.Size = new System.Drawing.Size(165, 42);
            this.Discard.TabIndex = 29;
            this.Discard.Text = "  Abbrechen";
            this.Discard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Discard.UseVisualStyleBackColor = false;
            this.Discard.Click += new System.EventHandler(this.Discard_Click);
            // 
            // Save
            // 
            this.Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Save.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.Save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Save.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Save.ForeColor = System.Drawing.Color.Transparent;
            this.Save.Image = global::Minecraft_Server_Manager.Properties.Resources.save;
            this.Save.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Save.Location = new System.Drawing.Point(557, 222);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(165, 42);
            this.Save.TabIndex = 28;
            this.Save.Text = "  Speichern";
            this.Save.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Save.UseVisualStyleBackColor = false;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // RAM_Unit
            // 
            this.RAM_Unit.FormattingEnabled = true;
            this.RAM_Unit.Items.AddRange(new object[] {
            "GB",
            "MB"});
            this.RAM_Unit.Location = new System.Drawing.Point(158, 105);
            this.RAM_Unit.Margin = new System.Windows.Forms.Padding(4);
            this.RAM_Unit.Name = "RAM_Unit";
            this.RAM_Unit.Size = new System.Drawing.Size(54, 28);
            this.RAM_Unit.TabIndex = 27;
            this.RAM_Unit.SelectedIndexChanged += new System.EventHandler(this.RAM_Unit_SelectedIndexChanged);
            // 
            // RAM_Label
            // 
            this.RAM_Label.AutoSize = true;
            this.RAM_Label.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RAM_Label.ForeColor = System.Drawing.Color.White;
            this.RAM_Label.Location = new System.Drawing.Point(21, 81);
            this.RAM_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RAM_Label.Name = "RAM_Label";
            this.RAM_Label.Size = new System.Drawing.Size(44, 20);
            this.RAM_Label.TabIndex = 26;
            this.RAM_Label.Text = "RAM";
            // 
            // Name_Label
            // 
            this.Name_Label.AutoSize = true;
            this.Name_Label.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name_Label.ForeColor = System.Drawing.Color.White;
            this.Name_Label.Location = new System.Drawing.Point(4, 12);
            this.Name_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Name_Label.Name = "Name_Label";
            this.Name_Label.Size = new System.Drawing.Size(167, 30);
            this.Name_Label.TabIndex = 25;
            this.Name_Label.Text = "Server Name";
            this.Name_Label.DoubleClick += new System.EventHandler(this.Name_Label_DoubleClick);
            // 
            // Close
            // 
            this.Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Close.BackColor = System.Drawing.Color.Transparent;
            this.Close.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.Close.FlatAppearance.BorderSize = 0;
            this.Close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Close.ForeColor = System.Drawing.Color.Transparent;
            this.Close.Image = global::Minecraft_Server_Manager.Properties.Resources.close;
            this.Close.Location = new System.Drawing.Point(677, 5);
            this.Close.Margin = new System.Windows.Forms.Padding(4);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(44, 37);
            this.Close.TabIndex = 24;
            this.Close.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Close.UseVisualStyleBackColor = false;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // ServerSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.Name_EditSave);
            this.Controls.Add(this.Name_EditDiscard);
            this.Controls.Add(this.Name_Edit);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.RAM_Amount);
            this.Controls.Add(this.ShowUI);
            this.Controls.Add(this.Discard);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.RAM_Unit);
            this.Controls.Add(this.RAM_Label);
            this.Controls.Add(this.Name_Label);
            this.Controls.Add(this.Close);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ServerSettings";
            this.Size = new System.Drawing.Size(726, 268);
            this.VisibleChanged += new System.EventHandler(this.ServerSettings_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.RAM_Amount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button Name_EditSave;
        public System.Windows.Forms.Button Name_EditDiscard;
        public System.Windows.Forms.TextBox Name_Edit;
        public System.Windows.Forms.Button Delete;
        public System.Windows.Forms.NumericUpDown RAM_Amount;
        public System.Windows.Forms.CheckBox ShowUI;
        public System.Windows.Forms.Button Discard;
        public System.Windows.Forms.Button Save;
        public System.Windows.Forms.ComboBox RAM_Unit;
        public System.Windows.Forms.Label RAM_Label;
        public System.Windows.Forms.Label Name_Label;
        public System.Windows.Forms.Button Close;
    }
}
