using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoSaver2.Forms
{
    public partial class NewGameForm : Form
    {
        public NewGameForm()
        {
            InitializeComponent();
            var gamesFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "My Games");
            SaveLocationDialog.InitialDirectory = gamesFolder;
            SaveLocationTextBox.Text = gamesFolder;
        }

        private void NewGameForm_Load(object sender, EventArgs e)
        {
            ArchiveSaveFrequencyLabel.Visible= false;
            ArchiveSaveFrequencyNumber.Visible= false;
            ArchiveSaveFrequencySecondsLabel.Visible= false;
        }

        private void PickButton_Click(object sender, EventArgs e)
        {
            var result = SaveLocationDialog.ShowDialog(this);
            SaveLocationTextBox.Text = SaveLocationDialog.SelectedPath.Trim();
        }

        private void IsWatchSaveFolder_CheckedChanged(object sender, EventArgs e)
        {
            if(!IsWatchSaveFolder.Checked)
            {
                ArchiveSaveFrequencyLabel.Visible= true;
                ArchiveSaveFrequencyNumber.Visible= true;
                ArchiveSaveFrequencySecondsLabel.Visible= true;
            }
            else
            {
                ArchiveSaveFrequencyLabel.Visible= false;
                ArchiveSaveFrequencyNumber.Visible= false;
                ArchiveSaveFrequencySecondsLabel.Visible= false;
            }
        }

        private void AddGameButton_Click(object sender, EventArgs e)
        {
            var game = new Game(GameNameTextbox.Text.Trim());
            game.IsWatcher = IsWatchSaveFolder.Checked;
            game.SaveLocation = SaveLocationTextBox.Text.Trim();
            game.Frequency = ((int)ArchiveSaveFrequencyNumber.Value);
            game.KeepCount = ((int)KeepAmountNumber.Value);
            Manager.Instance.GameManager.AddGame(game);
            this.Close();
        }
    }
}
