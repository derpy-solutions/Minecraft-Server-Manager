using System;
using System.Windows.Forms;
using System.Linq;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace Minecraft_Server_Manager.Custom_Controls
{
    public partial class Servers : UserControl
    {
        public Servers()
        {
            InitializeComponent();
            this.ServerListBox.DrawMode = DrawMode.OwnerDrawFixed;

            //Set Font
            if (Fonts.setFonts)
            {
#if !DEBUG
                            Search_Input.Font = Fonts.Text();
                            SearchPlaceholder.Font = Fonts.TextItalic();
                            ServerListBox.Font = Fonts.Text();
                            CreateServer.Font = Fonts.Button();
                            StartServer.Font = Fonts.Button();
#endif
            }

                Inits.Voids.Add(Init);
        }

        public void Init()
        {
            RefreshServerList();
        }

            private void Search_Input_Enter(object sender, EventArgs e)
        {
            SearchPlaceholder.Hide();
        }

        private void Search_Input_Leave(object sender, EventArgs e)
        {
            if (Search_Input.Text == null || Search_Input.Text.ToString() == "")
            {
                SearchPlaceholder.Show();
            }
        }

        private void StartServer_Click(object sender, EventArgs e)
        {
            if (this.ServerListBox.SelectedItem != null && this.ServerListBox.SelectedItem.ToString() != "")
            {
                string name = this.ServerListBox.SelectedItem.ToString();
                var running = false;

                foreach (Server rServ in G.Servers)
                {
                    if (string.Equals(rServ.name, name, StringComparison.OrdinalIgnoreCase))
                    {
                        running = true;
                        break;
                    }
                }

                if (!running)
                {
                    Server server = new Server()
                    {
                        path = Properties.Settings.Default.ServerPath + @"\" + name,
                        name = name,
                        status = 1,
                        port = -1,
                        pid = -1,
                        ini = Properties.Settings.Default.DataPath + @"\Status Updates\" + name + ".ini",
                        listIndex = this.ServerListBox.SelectedIndex,
                    };
                    server.settings.Path = Properties.Settings.Default.ServerPath + @"\" + name;
                    server.Start();

                    var MyIni = new IniFile(server.ini);
                    MyIni.Write("Name", server.name);
                    MyIni.Write("Status", server.status.ToString());
                    MyIni.Write("PID", server.pid.ToString());
                    MyIni.Write("Port", server.pid.ToString());
                }
            }
        }
        public void RefreshServerList()
        {
            if (Properties.Settings.Default != null && Properties.Settings.Default.ServerPath != null)
            {
                var serverPath = Properties.Settings.Default.ServerPath.ToString() + @"\";
                if (Directory.Exists(serverPath))
                {
                    var folders = Directory.GetDirectories(serverPath);

                    G.ServerList.Clear();
                    this.ServerListBox.Items.Clear();


                    for (int i = 0; i < folders.Length; i++)
                    {
                        string sName = Regex.Replace(folders[i], @".*\\", "");

                        if (sName.Contains(this.Search_Input.Text, StringComparison.OrdinalIgnoreCase))
                        {
                            var index = this.ServerListBox.Items.Add(sName);

                            Server server = new Server()
                            {
                                path = folders[i],
                                listIndex = index,
                                name = sName,
                                status = 0,
                            };
                            server.settings.Path = folders[i];

                            G.ServerList.Add(server);
                        }
                    }
                }
            }
        }

        private void Search_Input_TextChanged(object sender, EventArgs e)
        {
            RefreshServerList();
        }

        private void ServerListBox_DoubleClick(object sender, EventArgs e)
        {
            if (ServerListBox.SelectedIndex != -1)
            {
                var server = G.ServerList[ServerListBox.SelectedIndex];
                server.settings.Load(true);
                serverSettings.server = server;
                serverSettings.Name_Label.Text = server.name;
                serverSettings.ShowUI.Checked = server.settings.Show_UI;
                serverSettings.RAM_Amount.Value = server.settings.RAM_Amount;
                serverSettings.RAM_Unit.SelectedItem = server.settings.RAM_Unit;

                serverSettings.Name_Edit.Hide();
                serverSettings.Name_EditDiscard.Hide();
                serverSettings.Name_EditSave.Hide();

                serverSettings.Show();
            }       
        }

        private void ServerListBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;

            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
            {
                e = new DrawItemEventArgs(e.Graphics,
                                          e.Font,
                                          e.Bounds,
                                          e.Index,
                                          e.State ^ DrawItemState.Selected,
                                          e.ForeColor,
                                          Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(94))))));//Choose the color

                e.DrawBackground();
                e.Graphics.DrawString(ServerListBox.Items[e.Index].ToString(), e.Font, Brushes.Black, e.Bounds, StringFormat.GenericDefault);
            }
            else
            {
                e.DrawBackground();
                e.Graphics.DrawString(ServerListBox.Items[e.Index].ToString(), e.Font, Brushes.White, e.Bounds, StringFormat.GenericDefault);
            }
            e.DrawFocusRectangle();
        }

        private void CreateServer_Click(object sender, EventArgs e)
        {
            var name = Search_Input.Text.Trim() ;
            var names = ServerListBox.Items.Cast<String>().ToList();

            if (name != "" && !names.Contains(name, StringComparer.OrdinalIgnoreCase))
            {
                Console.WriteLine("[" + DateTime.Now + "]: " + "add Server: " + name);
                Dir.Copy(Properties.Settings.Default.DataPath.ToString() + @"\ServerSource", Properties.Settings.Default.ServerPath.ToString() + @"\" + name);
                RefreshServerList();
            }
        }

        private void Servers_Load(object sender, EventArgs e)
        {
         //   RefreshServerList();
        }
    }
}
