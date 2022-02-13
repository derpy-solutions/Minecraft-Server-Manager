using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Minecraft_Server_Manager.Custom_Controls
{
    public partial class TitleBar : UserControl
    {
        private bool mouseDown;
        private Point lastLocation;

        public TitleBar()
        {
            InitializeComponent();

            //Set Fonts
            if (Fonts.setFonts)
            {
#if !DEBUG
                    label2.Font = Fonts.MenuButton();
#endif
            }
            }
        private void MainMove_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void MainMove_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                ParentForm.Location = new Point(
                    (ParentForm.Location.X - lastLocation.X) + e.X, (ParentForm.Location.Y - lastLocation.Y) + e.Y);

                ParentForm.Update();
            }
        }

        private void MainMove_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }


        private void TopBar_Minimize_Click(object sender, EventArgs e)
        {
            ParentForm.WindowState = FormWindowState.Minimized;
        }

        private void TopBar_Fullscreen_Click(object sender, EventArgs e)
        {
            ParentForm.WindowState = FormWindowState.Maximized;
        }

        private void TopBar_Close_Click(object sender, EventArgs e)
        {
            ParentForm.Close();
        }
    }
}
