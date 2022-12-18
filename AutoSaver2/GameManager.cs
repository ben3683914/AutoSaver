using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Diagnostics;

namespace AutoSaver2
{
    public sealed class GameManager
    {
        internal ObservableCollection<Game> Games { get => games; set => games = value; }
        private ObservableCollection<Game> games;
        
        public GameManager()
        {
            games = new ObservableCollection<Game>();
        }

        public Game GetGameByGuid(string guid)
        {
            Game game = null;
            try
            {
                Logger.Debug($"finding game by guid: {guid}");
                game = Games.First(item => item.GUID == guid);
                Logger.Info($"found game by guid {guid}: {game.Title}");
            } catch
            {
                Logger.Error($"couldn't find game by {guid}");
            }
                
            return game;
        }

        public Game GetGameByTitle(string title)
        {
            Game game = null;

            try
            {
                Logger.Debug($"finding game by guid: {title}");
                game = Games.First(item => item.Title == title);
                Logger.Info($"found game by guid {title}: {game.Title}");
            }
            catch
            {
                Logger.Error($"couldn't find game by {title}");
            }
            return game;
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
            Logger.Debug("starting to save");
            var jsonString = JsonSerializer.Serialize(Games);
            Logger.Debug($"save path: {Utilities.GamesSavePath}");
            File.WriteAllText(Utilities.GamesSavePath, jsonString);
        }

        public void Load()
        {
            try
            {
                var jsonString = File.ReadAllText(Utilities.GamesSavePath);
                var jsonResult = JsonSerializer.Deserialize<List<Game>>(jsonString);

                foreach(var game in jsonResult)
                    Games.Add(game);
                
            }
            catch
            {
                Logger.Info("cannot load. there may not be a saved file");
            }
        }
    }
}
