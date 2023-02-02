using System.Diagnostics;
using AutoSaver2.Forms;

namespace AutoSaver2
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

            Utilities.Setup();

            Logger.SetFolder();
            Logger.LogFileName = "AutoSaver.log";

            var controls = new Dictionary<string, Object>();
            controls.Add("ServiceControlButton", ServiceControlButton);
            controls.Add("ServiceStatusLabel", ServiceStatusLabel);
            controls.Add("SelectedGameLabel", SelectedGameLabel);
            controls.Add("MonitorStatusLabel", MonitorStatusLabel);
            controls.Add("GamesListBox", GamesListBox);
            controls.Add("SavesListBox", SavesListBox);
            controls.Add("RestoreButton", RestoreButton);
            controls.Add("RestoreLatestButton", RestoreLatestButton);
            controls.Add("MainStatusStrip", MainStatusStrip);
            controls.Add("MainStatusStripIndicatorLabel", ToolStripServiceStatusIndicator);
            controls.Add("MainStatusStripMonitoredGamelabel", ToolStripMonitoredGameLabel);


            Manager.Instance.Initialize(controls, SaveFileWatcher);
            Manager.Instance.GameManager.Load();
            Manager.Instance.UI.Refresh();
        }

        private void ServiceControlButton_Click(object sender, EventArgs e)
        {
            Manager.Instance.ServiceControl.Toggle();
        }

        private void MenuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void GamesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedGame = Manager.Instance.UI.GamesBox.GetCurrentItem();
            Manager.Instance.UI.SelectedGame = selectedGame;
            Manager.Instance.SaveManager.BuildSaveList(selectedGame);
            Manager.Instance.UI.Refresh();
        }

        private void MenuLoadDefaultList_Click(object sender, EventArgs e)
        {
            var defaultGames = Utilities.GetDefaultGamesList();
            foreach (var game in defaultGames)
            {
                if (Manager.Instance.GameManager.GetGameByGuid(game.GUID) == null)
                {
                    Manager.Instance.GameManager.AddGame(game);
                    Logger.Info($"added default game {game.Title}");
                }
            }
        }

        private void MenuAddGame_Click(object sender, EventArgs e)
        {
            var newGameForm = new NewGameForm();
            newGameForm.ShowDialog(this);
        }

        private void MenuDeleteGame_Click(object sender, EventArgs e)
        {
            Game game = (Game)GamesListBox.SelectedItem;
            if (game != null)
            {
                Manager.Instance.GameManager.RemoveGame(game);
            }
        }

        private void MenuEditGame_Click(object sender, EventArgs e)
        {
            try {
                Game game = (Game)GamesListBox.SelectedItem;
                var editGameForm = new EditGameForm(game);
                var result = editGameForm.ShowDialog(this);
                if(result == DialogResult.OK)
                {
                    Manager.Instance.UI.GamesBox.RefreshGamesList();
                }
            } catch {
                throw;
            }
            
        }

        private void MenuOpenLogs_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(Logger.FolderLocation))
            {
                Process.Start("explorer.exe", Logger.FolderLocation);
            }
        }

        private void RestoreButton_Click(object sender, EventArgs e)
        {
            var selectedSave = Manager.Instance.UI.SavesBox.GetSelectedFileName();
            if(selectedSave != null)
            {
                try
                {
                    var game = Manager.Instance.UI.SelectedGame;
                    var save = game.GetSaveByFileName(selectedSave);
                    Logger.Info(save.FileName);
                    game.Restore(save);
                }
                catch { }
            }
        }

        private void RestoreLatestButton_Click(object sender, EventArgs e)
        {
            try
            {
                var game = Manager.Instance.UI.SelectedGame;
                var save = game.GetLatestSave();
                Logger.Info(save.FileName);
                game.Restore(save);
            }
            catch { }
        }
    }
}