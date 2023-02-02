using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoSaver2
{
    internal sealed class Manager
    {
        #region singleton
        static readonly Manager instance = new Manager();
        public static Manager Instance
        {
            get
            {
                return instance;
            }
        }
        #endregion singleton

        public UIManager UI;
        public GameManager GameManager;
        public ServiceControl ServiceControl;
        public GameSaveManager SaveManager;
        public FileSystemWatcher SaveFileWatcher;

        public void Initialize(Dictionary<string, Object> _controls, FileSystemWatcher _watcher)
        {
            SaveFileWatcher = _watcher;
            GameManager = new GameManager();
            ServiceControl = new ServiceControl();
            SaveManager= new GameSaveManager();
            UI = new UIManager(_controls);
        }
    }
}
