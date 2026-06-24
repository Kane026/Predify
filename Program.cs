using Predify;

class Program
{
    static void Main()
    {
        while (true)
        {
            // Display the main menu
            Console.WriteLine("1. Nummers");
            Console.WriteLine("2. Playlist aanmaken");
            Console.WriteLine("3. Albums");
            Console.WriteLine("4. Playlist inkijken");
            Console.WriteLine("5. Afsluiten");

            // Ask the user to make a choice
            Console.Write("Maak een keuze: ");
            string choice = Console.ReadLine();

            // Handle the user's choice
            if (choice == "1")
            {
                var songList = new SongList();
                songList.ShowSongs();
            }
            else if (choice == "2")
            {
                Playlist playlist = new Playlist("");
                playlist.CreatePlaylist();
                playlist.AddSongMenu();
            }
            else if (choice == "3")
            {
                Console.WriteLine("Albums gekozen");
            }
            else if (choice == "4")
            {
                
                Console.WriteLine("Playlist inkijken");
            }
            else if (choice == "5")
            {
                Console.WriteLine("Afsluiten gekozen");
                break;
            }
            else
            {
                Console.WriteLine("Geen geldige keuze");
            }
        }
    }
}