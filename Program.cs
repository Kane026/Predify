using Predify;

Playlist playlist = new Playlist("");
Users users = new Users();

while (true)
{
    Console.WriteLine("1. Nummers");
    Console.WriteLine("2. Playlist aanmaken");
    Console.WriteLine("3. Nummer toevoegen aan playlist");
    Console.WriteLine("4. Playlist inkijken");
    Console.WriteLine("5. Nummer verwijderen uit playlist");
    Console.WriteLine("6. Albums");
    Console.WriteLine("7. Users");
    Console.WriteLine("8. Add Friend");
    Console.WriteLine("9. Remove Friend");
    Console.WriteLine("10. Friends");
    Console.WriteLine("11. Afsluiten");

    Console.Write("Maak een keuze: ");
    string choice = Console.ReadLine();

    if (choice == "1")
    {
        var songList = new SongList();
        songList.ShowSongs();
        Console.WriteLine();
    }
    else if (choice == "2")
    {
        playlist.CreatePlaylist();
        Console.WriteLine();
    }
    else if (choice == "3")
    {
        playlist.AddSongMenu();
        Console.WriteLine();
    }
    else if (choice == "4")
    {
        playlist.ViewPlaylist();
        Console.WriteLine();
    }
    else if (choice == "5")
    {
        playlist.RemoveSong();
        Console.WriteLine();
    }
    else if (choice == "6")
    {
        Album album = new Album();
        album.ShowAlbums();
        Console.WriteLine();
    }
    else if (choice == "7")
    {
        users.ShowUsers();
        Console.WriteLine();
    }
    else if (choice == "8")
    {
        users.AddFriend();
        Console.WriteLine();
    }
    else if (choice == "9")
    {
        users.RemoveFriend();
        Console.WriteLine();
    }
    else if (choice == "10")
    {
        users.ShowFriends();
        Console.WriteLine();
    }
    else if (choice == "11")
    {
        Console.WriteLine("Afsluiten...");
        break;
    }
    else
    {
        Console.WriteLine("Geen geldige keuze");
        Console.WriteLine();
    }
}