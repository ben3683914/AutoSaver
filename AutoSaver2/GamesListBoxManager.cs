using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSaver2
{
    internal class GamesListBoxManager
    {
        protected ListBox gamesListBox;
        public GamesListBoxManager(ListBox _listbox) {
            gamesListBox = _listbox;

            #region events
            Manager.Instance.GameManager.Games.CollectionChanged += GamesListChanged;
            #endregion
        }

        public Game GetCurrentItem()
        {
            Game game = null;

            if(gamesListBox.SelectedItem != null)
                game = (Game)gamesListBox.SelectedItem;

            return game;
        }

        public void RefreshGamesList()
        {
            Logger.Debug("updating games list");
            gamesListBox.Items.Clear();

            if (Manager.Instance.GameManager.Games.Count > 0)
            {
                foreach (var game in Manager.Instance.GameManager.Games)
                {
                    gamesListBox.Items.Add(game);
                }
            }

            Manager.Instance.GameManager.Save();
        }

        private void GamesListChanged(object sender, EventArgs e)
        {
            RefreshGamesList();
        }
    }
}
