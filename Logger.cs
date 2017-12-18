using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AutoSaver
{
    public class Logger
    {
        public string FolderLocation;
        public Logger(string folderLocation)
        {
            FolderLocation = folderLocation;
        }

        public void Add(LogLevel level, string log)
        {
            string path = Path.Combine(FolderLocation, "log.txt");
            string dt = DateTime.Now.ToString("YYYY-MM-dd hh:mm:ss:fftt");
            string logLine = String.Format("{0} | {1} | {2}", level.ToString().PadRight(6), dt.PadRight(23), log);

            if(!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    string line = "File created: " + dt;
                    sw.WriteLine(line);
                    Console.WriteLine(line);
                }
            }

            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine(logLine);
                Console.WriteLine(logLine);
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
