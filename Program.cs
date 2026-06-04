using Predify;

class Program
{
    static void Main()
    {
        // Display the main menu
        Console.WriteLine("1. Muziek afspelen");
        Console.WriteLine("2. Nummers");
        Console.WriteLine("3. Playlist");
        Console.WriteLine("4. Albums");
        Console.WriteLine("5. Afsluiten");

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
            Console.WriteLine("Playlist gekozen");
        }
        else if (choice == "4")
        {
            Console.WriteLine("Albums gekozen");
        }
        else if (choice == "5")
        {
            Console.WriteLine("Afsluiten gekozen");
        }
        else
        {
            // Invalid choice
            Console.WriteLine("Geen geldige keuze");
        }
    }
}