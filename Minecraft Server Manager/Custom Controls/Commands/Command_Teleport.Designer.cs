
namespace Minecraft_Server_Manager.Custom_Controls.Commands
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
            this.Player_Destination = new System.Windows.Forms.ComboBox();
            this.Run = new System.Windows.Forms.Button();
            this.to_Player = new System.Windows.Forms.Label();
            this.Teleport_Label = new System.Windows.Forms.Label();
            this.Player_Target = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Player_Destination
            // 
            this.Player_Destination.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Player_Destination.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Player_Destination.FormattingEnabled = true;
            this.Player_Destination.Location = new System.Drawing.Point(261, 0);
            this.Player_Destination.Margin = new System.Windows.Forms.Padding(0);
            this.Player_Destination.Name = "Player_Destination";
            this.Player_Destination.Size = new System.Drawing.Size(160, 28);
            this.Player_Destination.Sorted = true;
            this.Player_Destination.TabIndex = 28;
            this.Player_Destination.TabStop = false;
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
            this.Run.TabIndex = 27;
            this.Run.Text = "Run";
            this.Run.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Run.UseVisualStyleBackColor = false;
            this.Run.Click += new System.EventHandler(this.Run_Click);
            // 
            // to_Player
            // 
            this.to_Player.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.to_Player.AutoSize = true;
            this.to_Player.BackColor = System.Drawing.Color.Transparent;
            this.to_Player.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.to_Player.ForeColor = System.Drawing.Color.White;
            this.to_Player.Location = new System.Drawing.Point(237, 4);
            this.to_Player.Margin = new System.Windows.Forms.Padding(0);
            this.to_Player.Name = "to_Player";
            this.to_Player.Size = new System.Drawing.Size(24, 20);
            this.to_Player.TabIndex = 26;
            this.to_Player.Text = "zu";
            // 
            // Teleport_Label
            // 
            this.Teleport_Label.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Teleport_Label.AutoSize = true;
            this.Teleport_Label.BackColor = System.Drawing.Color.Transparent;
            this.Teleport_Label.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Teleport_Label.ForeColor = System.Drawing.Color.White;
            this.Teleport_Label.Location = new System.Drawing.Point(0, 4);
            this.Teleport_Label.Margin = new System.Windows.Forms.Padding(0);
            this.Teleport_Label.Name = "Teleport_Label";
            this.Teleport_Label.Size = new System.Drawing.Size(77, 20);
            this.Teleport_Label.TabIndex = 25;
            this.Teleport_Label.Text = "Teleporte";
            // 
            // Player_Target
            // 
            this.Player_Target.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Player_Target.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Player_Target.FormattingEnabled = true;
            this.Player_Target.Location = new System.Drawing.Point(77, 0);
            this.Player_Target.Margin = new System.Windows.Forms.Padding(0);
            this.Player_Target.Name = "Player_Target";
            this.Player_Target.Size = new System.Drawing.Size(160, 28);
            this.Player_Target.Sorted = true;
            this.Player_Target.TabIndex = 24;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.flowLayoutPanel1.Controls.Add(this.Teleport_Label);
            this.flowLayoutPanel1.Controls.Add(this.Player_Target);
            this.flowLayoutPanel1.Controls.Add(this.to_Player);
            this.flowLayoutPanel1.Controls.Add(this.Player_Destination);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 25);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(574, 30);
            this.flowLayoutPanel1.TabIndex = 39;
            // 
            // Command_Teleport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.Run);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "Command_Teleport";
            this.Size = new System.Drawing.Size(655, 80);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ComboBox Player_Destination;
        public System.Windows.Forms.Button Run;
        private System.Windows.Forms.Label to_Player;
        private System.Windows.Forms.Label Teleport_Label;
        public System.Windows.Forms.ComboBox Player_Target;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}
