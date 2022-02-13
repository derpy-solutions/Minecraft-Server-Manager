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

    public class FavoriteCommands
    {
        public static bool loaded;
        public class Command
        {
            public string name;
            public string command;
            public Custom_Controls.FavoriteCommand control;
        }

        public static List<Command> Commands = new List<Command>();
        public static void Load()
        {
            Console.WriteLine("Loading Favorites...");
            Commands.Clear();
            MyControls.FavoritesMenu.FavoritesPanel.Controls.Clear();
            string xmlFileName = Properties.Settings.Default.DataPath + @"\MyCommands.xml";

            if (File.Exists(xmlFileName))
            {
                XDocument xdoc = XDocument.Load(xmlFileName);

                foreach (XElement elem in xdoc.Descendants("Command"))
                {
                    var name = elem.Element("name")?.Value;
                    var command = elem.Element("command")?.Value;

                    if (name != null && command != null)
                    {
                        var cmd = new Command()
                        {
                            name = name,
                            command = command,
                        };

                        cmd.control = new Custom_Controls.FavoriteCommand(cmd);
                        MyControls.FavoritesMenu.FavoritesPanel.Controls.Add(cmd.control);

                        Commands.Add(cmd);
                    }
                }
            }

            loaded = true;
        }
        public static void Save()
        {
            if (loaded)
            {
                Console.WriteLine("Saving Favorites...");
                XmlWriterSettings settings = new XmlWriterSettings();
                settings.Indent = true;
                settings.IndentChars = ("\t");
                settings.OmitXmlDeclaration = true;

                using (XmlWriter writer = XmlWriter.Create(Properties.Settings.Default.DataPath + @"\MyCommands.xml", settings))
                {

                    writer.WriteStartElement("Commands");

                    foreach (Command command in Commands)
                    {
                        Console.WriteLine("Name: " + command.name + "; " + "Command: " + command.command);
                        if (command.name != "New Command" || command.command.Length > 2)
                        {
                            if (command.command == "")
                            {
                                command.name = "Unnamed Command";
                            }

                            writer.WriteStartElement("Command");
                            writer.WriteElementString("name", command.name);
                            writer.WriteElementString("command", command.command);
                            writer.WriteEndElement();
                        }

                    }

                    writer.WriteEndElement();
                    writer.Flush();
                }
            }
        }
        public static void RefreshPanel()
        {
        }
        public static void Add()
        {
            Command cmd = new Command()
            {
                command = "",
                name = "New Command",
            };
            cmd.control = new Custom_Controls.FavoriteCommand(cmd);

            MyControls.FavoritesMenu.FavoritesPanel.Controls.Add(cmd.control);
            Commands.Add(cmd);
        }
    }
}