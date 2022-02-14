using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Minecraft_Server_Manager.Custom_Controls
{
    public partial class FavoritesMenu : Form
    {
        public FavoritesMenu()
        {
            InitializeComponent();
            G.favoritesPanel = this.FavoritesPanel;

            FavoritesLabel.Text = Main.rm.GetString("Favorites");
        }

        private void FavoritesMenu_Deactivate(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void FavoritesMenu_Load(object sender, EventArgs e)
        {
            var pos = new Point(Math.Min(MousePosition.X, Screen.FromControl(this).Bounds.Width - this.Width), Math.Min(MousePosition.Y, Screen.FromControl(this).Bounds.Height - this.Height));
            this.Location = pos;
            this.Update();
        }

        private void FavoritesMenu_Paint(object sender, PaintEventArgs e)
        {
           e.Graphics.DrawRectangle(new Pen(Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74))))), 2), new Rectangle(0, 0, this.ClientSize.Width - 1, this.ClientSize.Height - 1));
        }

        private void Run_Click(object sender, EventArgs e)
        {
            FavoriteCommands.Add();
        }

        private void FavoritesMenu_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                var pos = new Point(Math.Min(MousePosition.X, Screen.FromControl(this).Bounds.Width - this.Width), Math.Min(MousePosition.Y, Screen.FromControl(this).Bounds.Height - this.Height));
                this.Location = pos;
                this.Update();
            }
        }
    }
}
