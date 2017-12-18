# AutoSaver
This is a Windows Service that will automatically back up a folder structure. This was originally created as an autosave function for the game [They Are Billions](http://store.steampowered.com/app/644930/They_Are_Billions/). The game deletes the save files if you lose so you have no way of continuing if you make a small mistake.

### Installing
You need to place what's in the release folder to a location and run the exe using the command below. For example I created a folder on my C drive called AutoSaver and placed all of the release files into there.

```
C:\AutoSaver\AutoSaver.exe install -username "WindowsUsername" -password "WindowsPassword"
```

The service needs to run under your user account in order for it to automatically determine where your "They Are Billions" save files are located in Windows (Confirmed working in Windows 10). If you have a different location for your save files then you will need to open the project and modify the code to look there by default. It's a pretty simple project. If you do this then it will be a static location and you then won't need to provide the username or password and can run as LocalService by default.

### Usage
Once installed the service you will need to open up Windows Services and start the AutoSaver service. I recommend you stop the service once you are finished playing.

When the service is running it will copy your saved games into a folder inside of the game directory (see Locations below) every 60 seconds. It will keep 60 saves and then start deleting the oldest autosave. This is due to the way the game works where it only saves every so often in game, or if you Save and Exit. The best usage is for you to periodically Save and Exit while playing in order to force the game to save and therefore the service can autosave it for you just in case.

If you lose the game and want to restore to a previous spot just copy the the contents of one of the Autosave folders into the Saves folder

### Locations
* Save files for They Are Billions is by default in your My Games folder in your Documents.
  * Example: C:\Users\[username]\Documents\My Games\They Are Billions\Saves
* Autosave folder is created on the first autosave attempt
  * Example: C:\Users\[username]\Documents\My Games\They Are Billions\Autosave


### Modify Save Locations
If you have a custom Save location or if for some reason the save locations are not working, you can modify the code to look at a specific location. You can also modify how many autosaves are kept and how often it creates a save.

Open Program.cs and modify the following lines to what you want
```c#
string saveLocation = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "My Games", "They Are Billions", "Saves");
string autoSaveLocation = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "My Games", "They Are Billions", "Autosave");
int frequency = 60;
int keep = 60;
```

## License
This project is licensed under the MIT License - see the [LICENSE.md](LICENSE.md) file for details

## Links
[They Are Billions](http://store.steampowered.com/app/644930/They_Are_Billions/)
[TopShelf](http://topshelf-project.com/)
