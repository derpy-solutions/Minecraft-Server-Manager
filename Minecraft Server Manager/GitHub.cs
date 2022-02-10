using System;
using System.Net;
using System.Collections.Generic;
using Newtonsoft.Json;


namespace GitHub {
    class Run
    {
        public static bool UpdateAvailable()
        {
            string GetReleases(string username, string repoName)
            {
                const string GITHUB_API = "https://api.github.com/repos/{0}/{1}/releases";
                WebClient webClient = new WebClient();
                // Added user agent
                webClient.Headers.Add("User-Agent", "Unity web player");
                Uri uri = new Uri(string.Format(GITHUB_API, username, repoName));
                string releases = webClient.DownloadString(uri);

                return releases;
            }

            var str = GetReleases("derpy-solutions", "Minecraft-Server-Manager");

            var releases = JsonConvert.DeserializeObject<List<Root>>(str);

            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
            System.Diagnostics.FileVersionInfo fvi = System.Diagnostics.FileVersionInfo.GetVersionInfo(assembly.Location);
            string version = fvi.FileVersion;
            Console.WriteLine(version);
            Minecraft_Server_Manager.G.Ver.current = Version.Parse(version);
            var update = false;

            foreach (Root release in releases)
            {
                Version ver = null;

                if (Version.TryParse(release.tag_name, out ver))
                {
                    if (Minecraft_Server_Manager.G.Ver.newest == null || ver > Minecraft_Server_Manager.G.Ver.newest)
                    {
                        Minecraft_Server_Manager.G.Ver.newest = ver;

                        if (ver > Version.Parse(version))
                        {
                            update = true;
                        }
                    }
                }
            }

            if (update)
            {
                Console.WriteLine("There is an update available!");
                return true;
            }
            if (Minecraft_Server_Manager.G.Ver.newest == null)
            {
                Minecraft_Server_Manager.G.Ver.newest = Minecraft_Server_Manager.G.Ver.current;
            }

            Console.WriteLine("You are currently using the newest version!");
            return false;
        }        
    }

    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Author
    {
        public string login { get; set; }
        public int id { get; set; }
        public string node_id { get; set; }
        public string avatar_url { get; set; }
        public string gravatar_id { get; set; }
        public string url { get; set; }
        public string html_url { get; set; }
        public string followers_url { get; set; }
        public string following_url { get; set; }
        public string gists_url { get; set; }
        public string starred_url { get; set; }
        public string subscriptions_url { get; set; }
        public string organizations_url { get; set; }
        public string repos_url { get; set; }
        public string events_url { get; set; }
        public string received_events_url { get; set; }
        public string type { get; set; }
        public bool site_admin { get; set; }
    }
    public class Uploader
    {
        public string login { get; set; }
        public int id { get; set; }
        public string node_id { get; set; }
        public string avatar_url { get; set; }
        public string gravatar_id { get; set; }
        public string url { get; set; }
        public string html_url { get; set; }
        public string followers_url { get; set; }
        public string following_url { get; set; }
        public string gists_url { get; set; }
        public string starred_url { get; set; }
        public string subscriptions_url { get; set; }
        public string organizations_url { get; set; }
        public string repos_url { get; set; }
        public string events_url { get; set; }
        public string received_events_url { get; set; }
        public string type { get; set; }
        public bool site_admin { get; set; }
    }
    public class Asset
    {
        public string url { get; set; }
        public int id { get; set; }
        public string node_id { get; set; }
        public string name { get; set; }
        public object label { get; set; }
        public Uploader uploader { get; set; }
        public string content_type { get; set; }
        public string state { get; set; }
        public int size { get; set; }
        public int download_count { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
        public string browser_download_url { get; set; }
    }
    public class Root
    {
        public string url { get; set; }
        public string assets_url { get; set; }
        public string upload_url { get; set; }
        public string html_url { get; set; }
        public int id { get; set; }
        public Author author { get; set; }
        public string node_id { get; set; }
        public string tag_name { get; set; }
        public string target_commitish { get; set; }
        public string name { get; set; }
        public bool draft { get; set; }
        public bool prerelease { get; set; }
        public DateTime created_at { get; set; }
        public DateTime published_at { get; set; }
        public List<Asset> assets { get; set; }
        public string tarball_url { get; set; }
        public string zipball_url { get; set; }
        public string body { get; set; }
    }
}
