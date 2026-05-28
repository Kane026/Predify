using Spectre.Console;
using Predify;

class Program
{
    static void Main()
    {
        Console.WriteLine("1. Muziek afspelen");
        Console.WriteLine("2. Nummers");
        Console.WriteLine("3. Playlist");
        Console.WriteLine("4. Albums");
        Console.WriteLine("5. Afsluiten");

        Console.Write ("Maak een keuze: ");

        string choice = Console.ReadLine();

        if (choice == "1") { 
            Console.WriteLine("Muziek afspelen gekozen");
        }
        else if (choice == "2")
        {
            Console.WriteLine("Nummers gekozen");
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
            Console.WriteLine("Geen geldige keuze");
        }
    }
}
