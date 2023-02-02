using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.ListViewItem;

namespace AutoSaver2
{
    internal class SavesListBoxManager
    {
        private ListView savesListBox;
        public SavesListBoxManager(ListView _savesListBox) {
            savesListBox = _savesListBox;
            Manager.Instance.GameManager.OnSaveAdded += GameManager_OnSaveAdded;
        }

        private void GameManager_OnSaveAdded(object? sender, EventArgs e)
        {
            Refresh();
        }

        private void Load()
        {
            Logger.Info("loading game into saves list view");
            var game = Manager.Instance.UI.GamesBox.GetCurrentItem();

            try
            {
                foreach (var item in game.GetSaves())
                {
                    var listItem = new ListViewItem();
                    var subItem = new ListViewSubItem();
                    listItem.SubItems.Add(subItem);
                    listItem.Text = item.FileName.Split(Path.DirectorySeparatorChar).Last();
                    subItem.Text = item.Modified.ToString();

                    savesListBox.Items.Add(listItem);
                }
            }
            catch(Exception ex)
            {
                Logger.Debug($"couldn't load saves into list view: {ex.Message}");
            }
        }

        public void Show()
        {
            Logger.Debug("showing saves list view");
            savesListBox.Visible = true;
        }

        public void Hide()
        {
            Logger.Debug("hiding saves list view");
            savesListBox.Visible = false;
        }

        public void Clear()
        {
            Logger.Debug("clearing saves list view");
            savesListBox.Items.Clear();
        }

        public void Refresh()
        {
            Logger.Debug("refreshing saves list view");
            Clear();
            Load();
        }

        public string GetSelectedFileName()
        {
            var selectedItems = savesListBox.SelectedItems;

            if(selectedItems.Count > 0)
            {
                return selectedItems[0].Text;
            }

            return null;
        }
    }
}
