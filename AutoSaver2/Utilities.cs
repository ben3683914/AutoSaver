using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSaver2
{
    internal static class Utilities
    {
        public static string RootFolder = "";
        public static string GamesSavePath = "";
        public static string ArchivePath = "";
        public static string RoamingPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        public static string LocalLowPath = RoamingPath.Replace("Roaming", "LocalLow");
        public static string LocalAppDataPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
        public static string MyGamesPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),"My Games");

        public static void Setup()
        {
            SetRootFolder();
            SetGamesSavePath();
            SetArchivePath();
        }

        private static void SetRootFolder()
        {
            RootFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "AutoSaver2");
        }

        private static void SetGamesSavePath()
        {
            GamesSavePath = Path.Combine(RootFolder, "gamesList.as2");
        }

        private static void SetArchivePath()
        {
            ArchivePath = Path.Combine(RootFolder, "Saves");

            if (!Directory.Exists(ArchivePath))
            {
                Directory.CreateDirectory(ArchivePath);
            }
        }

        public static List<Game> GetDefaultGamesList()
        {
            var defaultGames = new List<Game>();
            defaultGames.Add(new Game("PlateUp! (Default)", "1ad4e5b3-b7b5-42e3-badc-d02e444759ea")
            {
                SaveLocation = Path.Combine(LocalLowPath, "It's Happening", "PlateUp", "Full"),
                IsWatcher = true,
                Frequency = 30,
                KeepCount = 60,
            });

            defaultGames.Add(new Game("They Are Billions (Default)", "3c36d8c1-5b05-465b-90eb-ef5fe20f39ec")
            {
                SaveLocation = Path.Combine(MyGamesPath, "They Are Billions", "Saves"),
                IsWatcher = true,
                Frequency = 30,
                KeepCount = 60,
            });

            return defaultGames;
        }

        public static void Wait(int milliseconds)
        {
            var timer1 = new System.Windows.Forms.Timer();
            if (milliseconds == 0 || milliseconds < 0) return;

            timer1.Interval = milliseconds;
            timer1.Enabled = true;
            timer1.Start();

            timer1.Tick += (s, e) =>
            {
                timer1.Enabled = false;
                timer1.Stop();
            };

            while (timer1.Enabled)
            {
                Application.DoEvents();
            }
        }
    }
}
