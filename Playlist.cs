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
        }

        // Toon een menu om een nummer te kiezen en toe te voegen
        public void AddSong()
        {
            // Beschikbare nummers
            List<string> availableSongs = new List<string>
            {
                "Never See Me Again - Kanye West - Hip Hop",
                "Mama's Boyfriend - Kanye West - Hip Hop",
                "Flashing Light - Kanye West - Hip Hop"
            };

            // Toon de beschikbare nummers
            Console.WriteLine("Kies een nummer om toe te voegen:");
            for (int i = 0; i < availableSongs.Count; i++)
            {
                Console.WriteLine((i + 1) + ". " + availableSongs[i]);
            }

            // Voeg het gekozen nummer toe aan de playlist
            int choice = int.Parse(Console.ReadLine());
            Songs.Add(availableSongs[choice - 1]);
            Console.WriteLine("Nummer toegevoegd aan playlist '" + Name + "'.");
        }
    }
}