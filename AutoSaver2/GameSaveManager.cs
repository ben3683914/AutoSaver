using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSaver2
{
    internal class GameSaveManager
    {
        public event EventHandler OnGameSaveAdded;

        public GameSaveManager() {

        }

        public void BuildSaveList(Game game, bool forceRebuild = false)
        {
            if (!forceRebuild)
            {
                Logger.Info($"building save list for game: {game.Title}");
                if (Directory.Exists(game.ArchiveLocation))
                {
                    Logger.Debug($"looking in archive location: {game.ArchiveLocation}");
                    string[] files = Directory.GetFiles(game.ArchiveLocation, "*");
                    foreach (var file in files)
                    {
                        game.AddSave(new Save()
                        {
                            Path = file,
                            FileName = file.Split(Path.DirectorySeparatorChar).Last(),
                            Modified = File.GetLastWriteTime(file)

                        });
                    }
                }
                else
                {
                    Logger.Info($"not build save list, couldn't find directory for game: {game.ArchiveLocation}");
                }
            }
            else
            {
                Logger.Info($"not building save list for game (already done): {game.Title}");
            }

            Manager.Instance.UI.SavesBox.Refresh();
        }
    }
}
