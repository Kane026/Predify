using Predify;

Playlist playlist = new Playlist("");

while (true)
{
    // Display the main menu
    Console.WriteLine("1. Nummers");
    Console.WriteLine("2. Playlist aanmaken");
    Console.WriteLine("3. Nummer toevoegen aan playlist");
    Console.WriteLine("4. Playlist inkijken");
    Console.WriteLine("5. Albums");
    Console.WriteLine("6. Afsluiten");

    // Ask the user to make a choice
    Console.Write("Maak een keuze: ");
    string choice = Console.ReadLine();

    // Handle the user's choice
    if (choice == "1")
    {
        var songList = new SongList();
        songList.ShowSongs();
        Console.WriteLine();
    }
    else if (choice == "2")
    {
        // Maak een nieuwe playlist aan
        playlist.CreatePlaylist();
        Console.WriteLine();
    }
    else if (choice == "3")
    {
        // Voeg een nummer toe aan de playlist
        playlist.AddSongMenu();
        Console.WriteLine();
    }
    else if (choice == "4")
    {
        // Toon alle nummers in de playlist
        playlist.ViewPlaylist();
        Console.WriteLine();
    }
    else if (choice == "5")
    {
        Console.WriteLine("Albums gekozen");
        Console.WriteLine();
    }
    else if (choice == "6")
    {
        Console.WriteLine("Afsluiten gekozen");
        break;
    }
    else
    {
        Console.WriteLine("Geen geldige keuze");
        Console.WriteLine();
    }
}