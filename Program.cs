using Predify;

class Program
{
    static void Main()
    {
        bool running = true;

        Users users = new Users();

        while (running)
        {
            // Display the main menu
            Console.WriteLine("1. Muziek afspelen");
            Console.WriteLine("2. Nummers");
            Console.WriteLine("3. Playlist");
            Console.WriteLine("4. Albums");
            Console.WriteLine("5. Users");
            Console.WriteLine("6. Add Friend");
            Console.WriteLine("7. Remove Friend");
            Console.WriteLine("8. Friends");
            Console.WriteLine("9. Afsluiten");

            // Ask the user to make a choice
            Console.Write("Maak een keuze: ");
            string choice = Console.ReadLine();

            // Handle the user's choice
            if (choice == "1")
            {
                Console.WriteLine("Muziek afspelen gekozen");
            }
            else if (choice == "2")
            {
                // Show the song list
                var songList = new SongList();
                songList.ShowSongs();
            }
            else if (choice == "3")
            {
                Playlist playlist = new Playlist("");
                playlist.CreatePlaylist();
            }
            else if (choice == "4")
            {
                Album album = new Album();
                album.ShowAlbums();
            }
            else if (choice == "5")
            {
                users.ShowUsers();
            }
            else if (choice == "6")
            {
                users.AddFriend();
            }
            else if (choice == "7")
            {

                users.RemoveFriend();
            }
            else if (choice == "8")
            {
                users.ShowFriends();
            }
            else if (choice == "9")
            {
                Console.WriteLine("Afsluiten gekozen");
                running = false;
            }
            else
            {
                Console.WriteLine("Geen geldige keuze");
            }
        }
    }
}