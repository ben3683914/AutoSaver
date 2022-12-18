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
    public partial class EditGameForm : Form
    {
        private Game game;
        public EditGameForm(Game game)
        {
            InitializeComponent();

            this.game = game;

            GameNameTextbox.Text = game.Title;
            SaveLocationDialog.InitialDirectory = game.SaveLocation;
            SaveLocationTextBox.Text = game.SaveLocation;
            IsWatchSaveFolder.Checked = game.IsWatcher;
            ArchiveSaveFrequencyNumber.Value = Convert.ToDecimal(game.Frequency);
            KeepAmountNumber.Value = Convert.ToDecimal(game.KeepCount);

            
        }

        private void EditGameForm_Load(object sender, EventArgs e)
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

        private void SaveGameButton_Click(object sender, EventArgs e)
        {
            game.Title = GameNameTextbox.Text;
            game.IsWatcher = IsWatchSaveFolder.Checked;
            game.SaveLocation = SaveLocationTextBox.Text;
            game.Frequency = ((int)ArchiveSaveFrequencyNumber.Value);
            game.KeepCount = ((int)KeepAmountNumber.Value);
            this.DialogResult = DialogResult.OK;

            this.Close();
        }
    }
}
