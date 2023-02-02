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
        public string ArchiveLocation { get; set; }
        public bool IsWatcher { get; set; }
        public int Frequency { get; set; }
        public int KeepCount { get; set; }
        private List<Save> saves { get; set; }

        public Game()
        {
            saves = new List<Save>();
        }

        public Game(string _title, string? _guid = null) {
            Title = _title;
            if (String.IsNullOrEmpty(_guid))
                GUID = CreateGuid();
            else
                GUID = _guid;

            saves = new List<Save>();
            SetupArchiveLocation();
        }

        private string CreateGuid()
        {
            return (new Guid(Guid.NewGuid().ToString())).ToString();
        }

        private void SetupArchiveLocation()
        {
            ArchiveLocation = Path.Combine(Utilities.ArchivePath, Title);
            
            if (!Directory.Exists(ArchiveLocation))
            {
                Directory.CreateDirectory(ArchiveLocation);
            }
        }

        public bool AddSave(Save save)
        {
            if (CheckSaveExists(save))
                return false;

            saves.Add(save);
            return true;
        }

        public bool CheckSaveExists(Save save)
        {
            var matches = saves.Where(p => String.Equals(p.FileName, save.FileName, StringComparison.CurrentCulture));
            if (matches.Count() > 0)
                return true;

            return false;
        }

        public void RemoveSave(Save save)
        {
            saves.Remove(save);
        }

        public IEnumerable<Save> GetSaves()
        {
            return saves.OrderBy(i => i.Modified).Reverse();
        }

        public Save GetLatestSave()
        {
            var saves = GetSaves();
            if(saves.Count() > 0)
                return saves.First();

            throw new Exception($"cannot get latest save because it doesn't exist");
        }

        public Save GetSaveByFileName(string fileName)
        {
            var saves = GetSaves();
            if(saves.Count() > 0)
            {
                var save = saves.Where(i => i.FileName == fileName).First();
                return save;
            }

            throw new Exception($"cannot get save by filename because it doesn't exist: {fileName}");
        }

        public void Restore(Save save)
        {
            File.Copy(save.Path, Path.Combine(SaveLocation, save.FileName));
        }

        public void CreateSave(string path, DateTime modified)
        {
            var fileName = path.Split(Path.DirectorySeparatorChar).Last();
            var result = AddSave(new Save()
            {
                Path = Path.Combine(ArchiveLocation, fileName),
                FileName = fileName,
                Modified = modified
            });

            if(result)
            {
                File.Copy(path, Path.Combine(ArchiveLocation, fileName));
                Manager.Instance.GameManager.FireOnSaveAdded();
            }

        }

        public void CleanupSaves()
        {
            throw new NotImplementedException();
        }
    }
}
