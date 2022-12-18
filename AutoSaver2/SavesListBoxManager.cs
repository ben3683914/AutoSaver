using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSaver2
{
    internal class SavesListBoxManager
    {
        private ListView savesListBox;
        public SavesListBoxManager(ListView _savesListBox) {
            savesListBox = _savesListBox;
        }

        public void Load(Game game)
        {
            Logger.Info("loading game into saves");
        }

        public void Show()
        {
            savesListBox.Visible = true;
        }

        public void Hide()
        {
            savesListBox.Visible = false;
        }
    }
}
