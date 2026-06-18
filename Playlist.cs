using System;
using System.Collections.Generic;

namespace Predify
{
    public class Playlist
    {
        public string Name { get; set; }
        public List<string> Songs { get; set; }

        public Playlist(string name)
        {
            Name = name;
            Songs = new List<string>();
        }

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