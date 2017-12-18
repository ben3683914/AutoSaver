using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Topshelf;

namespace AutoSaver
{
    class Program
    {
        static void Main(string[] args)
        {
            string saveLocation = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "My Games", "They Are Billions", "Saves");
            string autoSaveLocation = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "My Games", "They Are Billions", "Autosave");
            int frequency = 60;
            int keep = 60;

            HostFactory.Run(x =>
            {
                x.AddCommandLineDefinition("saveLocation", v => saveLocation = v);
                x.AddCommandLineDefinition("autoSaveLocation", v => autoSaveLocation = v);
                x.AddCommandLineDefinition("frequency", v => frequency = Int32.Parse(v));
                x.AddCommandLineDefinition("keep", v => keep = Int32.Parse(v));
                x.ApplyCommandLine();

                x.Service<AutoSaver>(s =>
                {
                    
                    s.ConstructUsing(name => new AutoSaver(saveLocation, autoSaveLocation, frequency, keep));
                    s.WhenStarted(tc => tc.Start());
                    s.WhenStopped(tc => tc.Stop());
                });

                x.RunAsLocalSystem();
                x.SetDescription("Folder autosaver");
                x.SetDisplayName("AutoSaver");
                x.SetServiceName("AutoSaver");
                x.StartManually();
            });
        }        
    }
}
