using Spectre.Console;
using Predify;

class Program
{
    static void Main()
    {
        var MainMenuChoice = AnsiConsole.Prompt(
            new SelectionPrompt<string>()
                .Title("Wat wil je doen")
                .AddChoices(new[]
                {
                    "Muziek afspelen",
                    "Nummers",
                    "Playlist",
                    "Albums",
                    "Afsluiten"
                })
        );

        if (MainMenuChoice == "Nummers")
        {
            var songList = new SongList();
            songList.ShowSongs();
        }
    }
}