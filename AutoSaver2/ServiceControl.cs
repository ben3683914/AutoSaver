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
            }
        }

        public void Stop()
        {
            if(CurrentStatus != Status.Stopped)
            {
                CurrentStatus = Status.Stopped;
                UpdateCurrentGame();
                OnServiceStatusChanged(null, new EventArgs());
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
    }
}
