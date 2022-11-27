using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSaver2
{
    public class GameManager
    {
        internal List<Game> Games { get => games; set => games = value; }
        private List<Game> games;
        
        public GameManager()
        {
            games = new List<Game>();
        }

        public void AddGame(Game game)
        {
            games.Add(game);
        }

        public void RemoveGame(Game game)
        {
            games.Remove(game);
        }

        public void Save()
        {

        }

        public void Load()
        {

        }
    }
}
