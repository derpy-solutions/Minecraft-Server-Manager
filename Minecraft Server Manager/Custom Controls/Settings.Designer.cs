
namespace Minecraft_Server_Manager.Custom_Controls
{
    partial class Settings
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.Header = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.DataPath_Browse = new System.Windows.Forms.Button();
            this.ServerPath_Browse = new System.Windows.Forms.Button();
            this.CMDCommand_TextBox = new System.Windows.Forms.TextBox();
            this.CMDCommand_Label = new System.Windows.Forms.Label();
            this.DataPath_TextBox = new System.Windows.Forms.TextBox();
            this.ResetSettings = new System.Windows.Forms.Button();
            this.DataPath_Label = new System.Windows.Forms.Label();
            this.ServerPath_Label = new System.Windows.Forms.Label();
            this.ServerPath_TextBox = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.JavaPath_Browse = new System.Windows.Forms.Button();
            this.JavaPath_TextBox = new System.Windows.Forms.TextBox();
            this.JavaPath_Label = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.CheckForUpdates = new System.Windows.Forms.CheckBox();
            this.LanguageSelect = new System.Windows.Forms.ComboBox();
            this.LanguageLabel = new System.Windows.Forms.Label();
            this.show_Tooltips = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.AutoSize = true;
            this.Header.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Header.ForeColor = System.Drawing.Color.White;
            this.Header.Location = new System.Drawing.Point(2, 2);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(170, 30);
            this.Header.TabIndex = 18;
            this.Header.Text = "Einstellungen";
            // 
            // DataPath_Browse
            // 
            this.DataPath_Browse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DataPath_Browse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DataPath_Browse.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.DataPath_Browse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.DataPath_Browse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DataPath_Browse.ForeColor = System.Drawing.Color.Transparent;
            this.DataPath_Browse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DataPath_Browse.Location = new System.Drawing.Point(390, 148);
            this.DataPath_Browse.Name = "DataPath_Browse";
            this.DataPath_Browse.Size = new System.Drawing.Size(36, 26);
            this.DataPath_Browse.TabIndex = 27;
            this.DataPath_Browse.Text = "...";
            this.DataPath_Browse.UseVisualStyleBackColor = false;
            this.DataPath_Browse.Click += new System.EventHandler(this.DataPath_Browse_Click);
            // 
            // ServerPath_Browse
            // 
            this.ServerPath_Browse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ServerPath_Browse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ServerPath_Browse.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.ServerPath_Browse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.ServerPath_Browse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ServerPath_Browse.ForeColor = System.Drawing.Color.Transparent;
            this.ServerPath_Browse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ServerPath_Browse.Location = new System.Drawing.Point(390, 80);
            this.ServerPath_Browse.Name = "ServerPath_Browse";
            this.ServerPath_Browse.Size = new System.Drawing.Size(36, 26);
            this.ServerPath_Browse.TabIndex = 26;
            this.ServerPath_Browse.Text = "...";
            this.ServerPath_Browse.UseVisualStyleBackColor = false;
            this.ServerPath_Browse.Click += new System.EventHandler(this.ServerPath_Browse_Click);
            // 
            // CMDCommand_TextBox
            // 
            this.CMDCommand_TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CMDCommand_TextBox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CMDCommand_TextBox.Location = new System.Drawing.Point(7, 284);
            this.CMDCommand_TextBox.Name = "CMDCommand_TextBox";
            this.CMDCommand_TextBox.Size = new System.Drawing.Size(419, 26);
            this.CMDCommand_TextBox.TabIndex = 25;
            this.CMDCommand_TextBox.TextChanged += new System.EventHandler(this.CMDCommand_TextBox_TextChanged);
            // 
            // CMDCommand_Label
            // 
            this.CMDCommand_Label.AutoSize = true;
            this.CMDCommand_Label.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CMDCommand_Label.ForeColor = System.Drawing.Color.White;
            this.CMDCommand_Label.Location = new System.Drawing.Point(7, 261);
            this.CMDCommand_Label.Name = "CMDCommand_Label";
            this.CMDCommand_Label.Size = new System.Drawing.Size(128, 20);
            this.CMDCommand_Label.TabIndex = 24;
            this.CMDCommand_Label.Text = "CMD Command";
            // 
            // DataPath_TextBox
            // 
            this.DataPath_TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataPath_TextBox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DataPath_TextBox.Location = new System.Drawing.Point(7, 148);
            this.DataPath_TextBox.Name = "DataPath_TextBox";
            this.DataPath_TextBox.Size = new System.Drawing.Size(382, 26);
            this.DataPath_TextBox.TabIndex = 23;
            this.DataPath_TextBox.TextChanged += new System.EventHandler(this.DataPath_TextBox_TextChanged);
            // 
            // ResetSettings
            // 
            this.ResetSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ResetSettings.AutoSize = true;
            this.ResetSettings.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ResetSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ResetSettings.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.ResetSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResetSettings.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ResetSettings.ForeColor = System.Drawing.Color.Transparent;
            this.ResetSettings.Image = ((System.Drawing.Image)(resources.GetObject("ResetSettings.Image")));
            this.ResetSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ResetSettings.Location = new System.Drawing.Point(182, 553);
            this.ResetSettings.Name = "ResetSettings";
            this.ResetSettings.Size = new System.Drawing.Size(244, 30);
            this.ResetSettings.TabIndex = 22;
            this.ResetSettings.Text = "Einstellungen zurücksetzten";
            this.ResetSettings.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ResetSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ResetSettings.UseVisualStyleBackColor = false;
            this.ResetSettings.Click += new System.EventHandler(this.ResetSettings_Click);
            // 
            // DataPath_Label
            // 
            this.DataPath_Label.AutoSize = true;
            this.DataPath_Label.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DataPath_Label.ForeColor = System.Drawing.Color.White;
            this.DataPath_Label.Location = new System.Drawing.Point(7, 125);
            this.DataPath_Label.Name = "DataPath_Label";
            this.DataPath_Label.Size = new System.Drawing.Size(83, 20);
            this.DataPath_Label.TabIndex = 21;
            this.DataPath_Label.Text = "Data Pfad";
            // 
            // ServerPath_Label
            // 
            this.ServerPath_Label.AutoSize = true;
            this.ServerPath_Label.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ServerPath_Label.ForeColor = System.Drawing.Color.White;
            this.ServerPath_Label.Location = new System.Drawing.Point(7, 57);
            this.ServerPath_Label.Name = "ServerPath_Label";
            this.ServerPath_Label.Size = new System.Drawing.Size(94, 20);
            this.ServerPath_Label.TabIndex = 20;
            this.ServerPath_Label.Text = "Server Pfad";
            // 
            // ServerPath_TextBox
            // 
            this.ServerPath_TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ServerPath_TextBox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ServerPath_TextBox.Location = new System.Drawing.Point(7, 80);
            this.ServerPath_TextBox.Name = "ServerPath_TextBox";
            this.ServerPath_TextBox.Size = new System.Drawing.Size(382, 26);
            this.ServerPath_TextBox.TabIndex = 19;
            this.ServerPath_TextBox.TextChanged += new System.EventHandler(this.ServerPath_TextBox_TextChanged);
            // 
            // JavaPath_Browse
            // 
            this.JavaPath_Browse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.JavaPath_Browse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.JavaPath_Browse.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.JavaPath_Browse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.JavaPath_Browse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.JavaPath_Browse.ForeColor = System.Drawing.Color.Transparent;
            this.JavaPath_Browse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.JavaPath_Browse.Location = new System.Drawing.Point(390, 215);
            this.JavaPath_Browse.Name = "JavaPath_Browse";
            this.JavaPath_Browse.Size = new System.Drawing.Size(36, 26);
            this.JavaPath_Browse.TabIndex = 30;
            this.JavaPath_Browse.Text = "...";
            this.JavaPath_Browse.UseVisualStyleBackColor = false;
            this.JavaPath_Browse.Click += new System.EventHandler(this.JavaPath_Browse_Click);
            // 
            // JavaPath_TextBox
            // 
            this.JavaPath_TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.JavaPath_TextBox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.JavaPath_TextBox.Location = new System.Drawing.Point(7, 215);
            this.JavaPath_TextBox.Name = "JavaPath_TextBox";
            this.JavaPath_TextBox.Size = new System.Drawing.Size(382, 26);
            this.JavaPath_TextBox.TabIndex = 29;
            this.JavaPath_TextBox.TextChanged += new System.EventHandler(this.JavaPath_TextBox_TextChanged);
            // 
            // JavaPath_Label
            // 
            this.JavaPath_Label.AutoSize = true;
            this.JavaPath_Label.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.JavaPath_Label.ForeColor = System.Drawing.Color.White;
            this.JavaPath_Label.Location = new System.Drawing.Point(7, 192);
            this.JavaPath_Label.Name = "JavaPath_Label";
            this.JavaPath_Label.Size = new System.Drawing.Size(84, 20);
            this.JavaPath_Label.TabIndex = 28;
            this.JavaPath_Label.Text = "Java Pfad";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // CheckForUpdates
            // 
            this.CheckForUpdates.Appearance = System.Windows.Forms.Appearance.Button;
            this.CheckForUpdates.AutoCheck = false;
            this.CheckForUpdates.AutoSize = true;
            this.CheckForUpdates.BackColor = System.Drawing.Color.Transparent;
            this.CheckForUpdates.FlatAppearance.BorderSize = 0;
            this.CheckForUpdates.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.CheckForUpdates.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.CheckForUpdates.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.CheckForUpdates.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CheckForUpdates.ForeColor = System.Drawing.Color.White;
            this.CheckForUpdates.Image = global::Minecraft_Server_Manager.Properties.Resources.checkbox_unchecked;
            this.CheckForUpdates.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CheckForUpdates.Location = new System.Drawing.Point(7, 340);
            this.CheckForUpdates.Name = "CheckForUpdates";
            this.CheckForUpdates.Size = new System.Drawing.Size(295, 30);
            this.CheckForUpdates.TabIndex = 31;
            this.CheckForUpdates.Text = "Automatisch nach Updates suchen";
            this.CheckForUpdates.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CheckForUpdates.UseVisualStyleBackColor = false;
            this.CheckForUpdates.CheckedChanged += new System.EventHandler(this.CheckForUpdates_CheckedChanged);
            this.CheckForUpdates.Click += new System.EventHandler(this.CheckForUpdates_Click);
            // 
            // LanguageSelect
            // 
            this.LanguageSelect.FormattingEnabled = true;
            this.LanguageSelect.Items.AddRange(new object[] {
            "Deutsch",
            "English"});
            this.LanguageSelect.Location = new System.Drawing.Point(7, 443);
            this.LanguageSelect.Name = "LanguageSelect";
            this.LanguageSelect.Size = new System.Drawing.Size(137, 28);
            this.LanguageSelect.TabIndex = 32;
            this.LanguageSelect.Text = "Deutsch";
            this.LanguageSelect.SelectedIndexChanged += new System.EventHandler(this.LanguageSelect_SelectedIndexChanged);
            // 
            // LanguageLabel
            // 
            this.LanguageLabel.AutoSize = true;
            this.LanguageLabel.Location = new System.Drawing.Point(7, 420);
            this.LanguageLabel.Name = "LanguageLabel";
            this.LanguageLabel.Size = new System.Drawing.Size(70, 20);
            this.LanguageLabel.TabIndex = 33;
            this.LanguageLabel.Text = "Sprache";
            // 
            // show_Tooltips
            // 
            this.show_Tooltips.Appearance = System.Windows.Forms.Appearance.Button;
            this.show_Tooltips.AutoCheck = false;
            this.show_Tooltips.AutoSize = true;
            this.show_Tooltips.BackColor = System.Drawing.Color.Transparent;
            this.show_Tooltips.FlatAppearance.BorderSize = 0;
            this.show_Tooltips.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.show_Tooltips.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.show_Tooltips.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.show_Tooltips.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.show_Tooltips.ForeColor = System.Drawing.Color.White;
            this.show_Tooltips.Image = global::Minecraft_Server_Manager.Properties.Resources.checkbox_unchecked;
            this.show_Tooltips.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.show_Tooltips.Location = new System.Drawing.Point(7, 376);
            this.show_Tooltips.Name = "show_Tooltips";
            this.show_Tooltips.Size = new System.Drawing.Size(211, 30);
            this.show_Tooltips.TabIndex = 34;
            this.show_Tooltips.Text = "Zeige Kurzinfos (Tooltips)";
            this.show_Tooltips.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.show_Tooltips.UseVisualStyleBackColor = false;
            this.show_Tooltips.CheckedChanged += new System.EventHandler(this.show_Tooltips_CheckedChanged);
            this.show_Tooltips.Click += new System.EventHandler(this.show_Tooltips_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.show_Tooltips);
            this.Controls.Add(this.LanguageLabel);
            this.Controls.Add(this.LanguageSelect);
            this.Controls.Add(this.CheckForUpdates);
            this.Controls.Add(this.Header);
            this.Controls.Add(this.DataPath_Browse);
            this.Controls.Add(this.ServerPath_Browse);
            this.Controls.Add(this.CMDCommand_TextBox);
            this.Controls.Add(this.CMDCommand_Label);
            this.Controls.Add(this.DataPath_TextBox);
            this.Controls.Add(this.ResetSettings);
            this.Controls.Add(this.DataPath_Label);
            this.Controls.Add(this.ServerPath_Label);
            this.Controls.Add(this.ServerPath_TextBox);
            this.Controls.Add(this.JavaPath_Browse);
            this.Controls.Add(this.JavaPath_TextBox);
            this.Controls.Add(this.JavaPath_Label);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Settings";
            this.Size = new System.Drawing.Size(429, 584);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label Header;
        public System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        public System.Windows.Forms.Button DataPath_Browse;
        public System.Windows.Forms.Button ServerPath_Browse;
        public System.Windows.Forms.TextBox CMDCommand_TextBox;
        public System.Windows.Forms.Label CMDCommand_Label;
        public System.Windows.Forms.TextBox DataPath_TextBox;
        public System.Windows.Forms.Button ResetSettings;
        public System.Windows.Forms.Label DataPath_Label;
        public System.Windows.Forms.Label ServerPath_Label;
        public System.Windows.Forms.TextBox ServerPath_TextBox;
        public System.Windows.Forms.ToolTip toolTip1;
        public System.Windows.Forms.Button JavaPath_Browse;
        public System.Windows.Forms.TextBox JavaPath_TextBox;
        public System.Windows.Forms.Label JavaPath_Label;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        public System.Windows.Forms.CheckBox CheckForUpdates;
        private System.Windows.Forms.ComboBox LanguageSelect;
        private System.Windows.Forms.Label LanguageLabel;
        public System.Windows.Forms.CheckBox show_Tooltips;
    }
}
