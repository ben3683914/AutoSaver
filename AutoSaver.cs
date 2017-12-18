using System;
using System.IO;
using System.Linq;
using System.Timers;

namespace AutoSaver
{
    public class AutoSaver
    {
        readonly Timer _timer;
        public string SaveLocation;
        public string AutoSaveLocation;
        public int Keep;
        Logger Log;


        public AutoSaver(string saveLocation, string autoSaveLocation, int frequency, int keep)
        {
            _timer = new Timer(frequency * 1000) { AutoReset = true };
            _timer.Elapsed += (sender, eventArgs) =>
            {
                Log = new Logger(autoSaveLocation);
                SaveLocation = saveLocation;
                AutoSaveLocation = autoSaveLocation;
                Keep = keep;
                Do();
            };
        }

        public void Start()
        {
            _timer.Start();
        }

        public void Stop()
        {
            _timer.Stop();
        }

        public void Do()
        {
            string folder;
            try
            {
                folder = CreateSaveFolder();
                Save(folder);
                Log.Add(LogLevel.Info, "Save successful");
                PurgeOldFiles(10);
            }
            catch (Exception e)
            {
                Log.Add(LogLevel.Error, e.StackTrace);
            }
        }

        public string CreateSaveFolder()
        {
            string timeFormat = DateTime.Now.ToString("MM-dd-yyyy-hhmmsstt");
            string folder = Path.Combine(AutoSaveLocation, timeFormat);

            if (!Directory.Exists(folder))
            {
                Directory.CreateDirectory(folder);
                Log.Add(LogLevel.Info, "Save folder created at:" + folder);
            }

            return folder;
        }

        public void Save(string folder)
        {
            string[] files = Directory.GetFiles(SaveLocation);
            foreach(string file in files)
            {
                var fileName = Path.GetFileName(file);
                var destFile = Path.Combine(folder, fileName);

                File.Copy(file, destFile, true);
            }
        }

        public void PurgeOldFiles(int amountToKeep)
        {
            int count = Directory.GetDirectories(AutoSaveLocation).Length;
            if (count > Keep)
            {
                FileSystemInfo fileInfo = new DirectoryInfo(AutoSaveLocation).GetFileSystemInfos().OrderBy(fi => fi.CreationTime).Where(fi => fi.Name != "log.txt").First();
                Directory.Delete(fileInfo.FullName, true);
                Log.Add(LogLevel.Info, String.Format("{0} deleted", fileInfo.Name));
            }
        }
    }
}
