using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSaver2
{
    internal class ServiceControl
    {
        public event EventHandler OnServiceStatusChanged;
        private FileSystemWatcher watcher;

        public enum Status
        {
            Running,
            Stopped
        }

        public Status CurrentStatus = Status.Stopped;
        public Game CurrentGame = null;

        public ServiceControl()
        {
            Manager.Instance.GameManager.Games.CollectionChanged += Games_CollectionChanged;
            watcher = Manager.Instance.SaveFileWatcher;
        }

        private void Games_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs e)
        {
            if (Manager.Instance.GameManager.Games.Count <= 0)
                Stop();
        }

        public void Start()
        {
            if(CurrentStatus != Status.Running)
            {
                CurrentStatus = Status.Running;
                UpdateCurrentGame();
                OnServiceStatusChanged(null, new EventArgs());
                Monitor();
            }
        }

        public void Stop()
        {
            if(CurrentStatus != Status.Stopped)
            {
                CurrentStatus = Status.Stopped;
                UpdateCurrentGame();
                OnServiceStatusChanged(null, new EventArgs());
                watcher.EnableRaisingEvents = false;
            }
        }

        public void UpdateCurrentGame()
        {
            if (CurrentStatus == Status.Running)
                CurrentGame = Manager.Instance.UI.SelectedGame;
            else
                CurrentGame = null;

            Manager.Instance.UI.Refresh();
        }

        public void Toggle()
        {
            if(CurrentStatus == Status.Running)
                Stop();
            else
                Start();
        }

        private void Monitor()
        {
            if (CurrentGame.IsWatcher)
                Watch();
            else
                Timer();
        }

        private void Watch()
        {
            watcher.Path = CurrentGame.SaveLocation;
            watcher.EnableRaisingEvents = true;

            watcher.NotifyFilter = NotifyFilters.Attributes
                                 | NotifyFilters.CreationTime
                                 | NotifyFilters.DirectoryName
                                 | NotifyFilters.FileName
                                 | NotifyFilters.LastAccess
                                 | NotifyFilters.LastWrite
                                 | NotifyFilters.Security
                                 | NotifyFilters.Size;

            watcher.Changed += OnFileWatcherEvent;
            watcher.Created += OnFileWatcherEvent;
            watcher.Deleted += OnFileWatcherEvent;
            watcher.Renamed += OnFileWatcherEvent;

            watcher.Filter = "*";
            watcher.IncludeSubdirectories = false;
            watcher.EnableRaisingEvents = true;
        }

        private void OnFileWatcherEvent(object sender, FileSystemEventArgs e)
        {
            if(e.ChangeType == WatcherChangeTypes.Created || e.ChangeType == WatcherChangeTypes.Changed)
            {
                string newFilePath = e.FullPath;
                var fi = new FileInfo(newFilePath);
                long fileSize = 0;
                int elapsedWait = 0;
                int waitTime = 1000;

                while (true)
                {
                    fi = new FileInfo(newFilePath);
                    elapsedWait += waitTime;
                    if (elapsedWait >= 30000)
                        break;

                    Utilities.Wait(waitTime);

                    try
                    {
                        
                        if (fi.Length > fileSize)
                        {
                            Logger.Debug($"checking file: {newFilePath}");
                            Logger.Debug($"{fi.Length} vs {fileSize}");
                            fileSize = fi.Length;
                        }
                        else
                        {
                            break;
                        }
                    } catch
                    {
                        break;
                    }
                }

                CurrentGame.CreateSave(newFilePath, fi.LastWriteTime);
            }

        }

        private void Timer()
        {

        }
    }
}
