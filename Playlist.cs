using System;
using System.Collections.Generic;

namespace Predify
{
    public class Playlist
    {
        // Naam van de playlist
        public string Name { get; set; }
        // Lijst van nummers in de playlist
        public List<string> Songs { get; set; }

        // Constructor om een playlist aan te maken met een naam
        public Playlist(string name)
        {
            Name = name;
            Songs = new List<string>();
        }

        // Vraag de gebruiker om een naam en maak de playlist aan
        public void CreatePlaylist()
        {
            Console.Write("Geef de naam van de playlist: ");
            string name = Console.ReadLine();
            Name = name;
            Console.WriteLine("Playlist '" + Name + "' aangemaakt.");
            Console.WriteLine("Druk op Enter om terug te gaan.");
            Console.ReadLine();
        }
    }
}