using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSaver2
{
    internal static class Logger
    {
        public static string FolderLocation = "";
        public static string LogFileName = "";

        public static void SetFolder()
        {
            FolderLocation = Path.Combine(Utilities.RootFolder, "logs");
        }

        public static void Info(string log, LogLevel level = LogLevel.Info)
        {
            Add(log, level);
        }

        public static void Error(string log, LogLevel level = LogLevel.Error)
        {
            Add(log, level);
        }

        public static void Debug(string log, LogLevel level = LogLevel.Debug)
        {
            Add(log, level);
        }

        private static void Add(string log, LogLevel level)
        {
            if(!Directory.Exists(FolderLocation))
            {
                Directory.CreateDirectory(FolderLocation);
            }

            string path = Path.Combine(FolderLocation, Logger.LogFileName);
            string dt = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss:fftt");
            string logLine = String.Format("{0} | {1} | {2}", level.ToString().PadRight(6), dt.PadRight(23), log);

            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    string line = "File created: " + dt;
                    sw.WriteLine(line);
                    System.Diagnostics.Debug.WriteLine(line);
                }
            }

            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine(logLine);
                System.Diagnostics.Debug.WriteLine(logLine);
            }
        }
    }

    public enum LogLevel
    {
        Info,
        Error,
        Debug
    }
}
