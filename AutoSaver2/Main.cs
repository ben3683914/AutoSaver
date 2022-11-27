using System.Diagnostics;
using AutoSaver2.Forms;

namespace AutoSaver2
{
    public partial class Main : Form
    {
        public GameManager GameManager;

        public Main()
        {
            InitializeComponent();
            Logger.FolderLocation = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "AutoSaver2");
            Logger.LogFileName = "AutoSaver.log";

            GameManager = new GameManager();
        }

        private void ServiceControlButton_Click(object sender, EventArgs e)
        {
            var newGameForm = new NewGameForm();
            newGameForm.ShowDialog(this);
        }

        private void MenuSave_Click(object sender, EventArgs e)
        {

        }

        private void MenuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MenuNewGame_Click(object sender, EventArgs e)
        {

        }
    }
}