using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSaver2
{
    public class Game
    {
        public string GUID { get; set; }
        public string Title { get; set; }
        public string SaveLocation { get; set; }
        public bool IsWatcher { get; set; }
        public int Frequency { get; set; }
        public int KeepCount { get; set; }
    }
}
