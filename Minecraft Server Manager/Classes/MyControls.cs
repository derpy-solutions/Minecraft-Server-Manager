using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Drawing.Text;
using System.Xml;
using System.Xml.Linq;

namespace Minecraft_Server_Manager
{
    public class MyControls
    {
        public static Main Main;
        public static Custom_Controls.SideBar SideBar;
        public static Custom_Controls.Settings Settings;
        public static Custom_Controls.Servers Servers;
        public static Custom_Controls.FavoritesMenu FavoritesMenu;        
    }
    public class Inits
    {
       public static List<Action> Voids = new List<Action>();  
    }
}