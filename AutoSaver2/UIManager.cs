using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSaver2
{
    internal class UIManager
    {
        public Dictionary<string, Object> Controls;
        public GamesListBoxManager GamesBox;
        public SavesListBoxManager SavesBox;
        public StatusStripManager Strip;
        public Game SelectedGame;
        

        public UIManager(Dictionary<string, Object> _controls) {
            Manager.Instance.ServiceControl.OnServiceStatusChanged += ServiceControl_ServiceStatusChanged;
            Manager.Instance.GameManager.Games.CollectionChanged += Games_CollectionChanged;

            GamesBox = new GamesListBoxManager((ListBox)_controls["GamesListBox"]);
            SavesBox = new SavesListBoxManager((ListView)_controls["SavesListBox"]);
            Strip = new StatusStripManager((StatusStrip)_controls["MainStatusStrip"]
                ,(ToolStripStatusLabel)_controls["MainStatusStripIndicatorLabel"]
                ,(ToolStripStatusLabel)_controls["MainStatusStripMonitoredGamelabel"]);
            Controls = _controls;
        }

        private void Games_CollectionChanged(object? sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            if (Manager.Instance.GameManager.Games.Count <= 0)
                SelectedGame = null;

            Refresh();
        }

        public void Refresh()
        {
            RefreshServiceControlBox();
            RefreshSaveControls();
        }

        private void ServiceControl_ServiceStatusChanged(object? sender, EventArgs e)
        {
            RefreshServiceControlBox();
        }

        public void RefreshServiceControlBox()
        {
            Label Statuslabel = (Label)Controls["ServiceStatusLabel"];
            Button ControlButton = (Button)Controls["ServiceControlButton"];
            Label MonitorStatusLabel = (Label)Controls["MonitorStatusLabel"];

            Statuslabel.Text = Manager.Instance.ServiceControl.CurrentStatus.ToString();

            if (Manager.Instance.ServiceControl.CurrentStatus == ServiceControl.Status.Running)
            {
                ControlButton.Text = "Stop";
                Statuslabel.ForeColor = Color.Green;
            }
            else
            {
                ControlButton.Text = "Start";
                Statuslabel.ForeColor = Color.Red;
            }

            if(SelectedGame == null)
                ControlButton.Enabled = false;
            else
                ControlButton.Enabled = true;

            if (Manager.Instance.ServiceControl.CurrentGame == null)
                MonitorStatusLabel.Text = "None";
            else
                MonitorStatusLabel.Text = Manager.Instance.ServiceControl.CurrentGame.Title;

            Strip.Refresh();
        }

        public void RefreshSaveControls()
        {
            if (SelectedGame == null)
            {
                ((Label)Controls["SelectedGameLabel"]).Visible = false;
                ((Button)Controls["RestoreButton"]).Visible = false;
                ((Button)Controls["RestoreLatestButton"]).Visible = false;
                SavesBox.Hide();
            }
            else
            {
                ((Label)Controls["SelectedGameLabel"]).Visible = true;
                ((Label)Controls["SelectedGameLabel"]).Text = SelectedGame.Title;
                ((Button)Controls["RestoreButton"]).Visible = true;
                ((Button)Controls["RestoreLatestButton"]).Visible = true;
                SavesBox.Show();
            }
        }

        
    }
}
