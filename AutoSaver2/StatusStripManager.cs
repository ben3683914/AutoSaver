using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSaver2
{
    internal class StatusStripManager
    {
        ToolStripStatusLabel IndicatorLabel;
        ToolStripStatusLabel MonitoredGameLabel;

        public StatusStripManager(StatusStrip _strip, ToolStripStatusLabel _indicatorLabel, ToolStripStatusLabel _monitoredGameLabel)
        {
            Manager.Instance.ServiceControl.OnServiceStatusChanged += ServiceControl_ServiceStatusChanged;
            IndicatorLabel = _indicatorLabel;
            MonitoredGameLabel = _monitoredGameLabel;

            Refresh();
        }

        private void ServiceControl_ServiceStatusChanged(object? sender, EventArgs e)
        {
            Refresh();
        }

        public void Refresh()
        {
            var serviceControl = Manager.Instance.ServiceControl;

            if(serviceControl.CurrentStatus == ServiceControl.Status.Running)
            {
                IndicatorLabel.ForeColor = Color.Green;
                MonitoredGameLabel.Text = $"Monitoring: {serviceControl.CurrentGame.Title}";
            }
            else
            {
                IndicatorLabel.ForeColor = Color.Red;
                MonitoredGameLabel.Text = "Monitoring: None";
            }
        }
    }
}
