using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Drawing.Text;
using System.Xml;
using System.Xml.Linq;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Runtime.InteropServices;
using System.Reflection;

namespace Minecraft_Server_Manager
{
    public class G
    {        public static bool ProcessExists(int id)
        {
            return Process.GetProcesses().Any(x => x.Id == id);
        }
        public static string Language = "EN";
        public static List<Server> ServerList = new List<Server>();
        public static List<Server> Servers = new List<Server>();
        public static List<string> ServerFoldersList = new List<string>();
        public static string[] ServerFolders;
        public static bool running = true;
        public static Control CardPanel;
        public static ListBox serverList;
        public static Font defaultHeaderFont;
        public static Font defaultSubHeaderFont;
        public static Font defaultTextFont;
        public static Font defaultButtonFont;
        public static Form Favorites { get; set; }
        public static FlowLayoutPanel favoritesPanel;
        public static Server selectedServer;

        public class Ver
        {
            public static Version current { get; set; }
            public static Version newest { get; set; }
            public static string url;
        }
    }
    public static class StringExtensions
    {
        public static bool Contains(this string source, string toCheck, StringComparison comp)
        {
            return source?.IndexOf(toCheck, comp) >= 0;
        }
    }
}
