using System;
using System.Collections.Generic;

namespace Predify
{
    public class Album
    {
        // Dictionary of albums with their songs
        private Dictionary<string, List<Song>> albumSongs = new Dictionary<string, List<Song>>
        {
            {
                "Graduation - Kanye West - Hip Hop", new List<Song>
                {
                    new Song("Good Morning", "Kanye West", "Hip Hop"),
                    new Song("Champion", "Kanye West", "Hip Hop"),
                    new Song("Stronger", "Kanye West", "Hip Hop"),
                    new Song("I Wonder", "Kanye West", "Hip Hop"),
                    new Song("Good Life", "Kanye West", "Hip Hop")
                }
            },
            {
                "The College Dropout - Kanye West - Hip Hop", new List<Song>
                {
                    new Song("We Don't Care", "Kanye West", "Hip Hop"),
                    new Song("All Falls Down", "Kanye West", "Hip Hop"),
                    new Song("Jesus Walks", "Kanye West", "Hip Hop"),
                    new Song("Through the Wire", "Kanye West", "Hip Hop")
                }
            },
            {
                "Late Registration - Kanye West - Hip Hop", new List<Song>
                {
                    new Song("Heard 'Em Say", "Kanye West", "Hip Hop"),
                    new Song("Gold Digger", "Kanye West", "Hip Hop"),
                    new Song("Diamonds from Sierra Leone", "Kanye West", "Hip Hop"),
                    new Song("Gone", "Kanye West", "Hip Hop")
                }
            }
        };

        // Show all available albums and let the user pick one
        public void ShowAlbums()
        {
            List<string> albums = new List<string>(albumSongs.Keys);

            Console.WriteLine("Albums");
            for (int i = 0; i < albums.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {albums[i]}");
            }

            // Ask the user to pick an album
            Console.Write("\nKies een album: ");
            string input = Console.ReadLine();

            // Check if the choice is valid
            if (int.TryParse(input, out int keuze) && keuze >= 1 && keuze <= albums.Count)
            {
                string gekozenAlbum = albums[keuze - 1];
                ShowSongsFromAlbum(gekozenAlbum);
            }
            else
            {
                Console.WriteLine("Ongeldige keuze.");
            }
        }

        // Show all songs from the selected album and let the user pick one
        private void ShowSongsFromAlbum(string albumNaam)
        {
            List<Song> nummers = new List<Song>(albumSongs[albumNaam]);

            // Ask the user if they want to shuffle the songs
            Console.WriteLine("Shufflen? (ja/nee)");
            string shuffleInput = Console.ReadLine();

            // Shuffle the songs if the user wants to
            if (shuffleInput?.ToLower() == "ja")
            {
                Random random = new Random();
                List<Song> shuffled = nummers.OrderBy(nummer => random.Next()).ToList();
                Console.WriteLine("je nummers zijn nu shuffled!");
            }

            // Display all songs
            for (int i = 0; i < nummers.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {nummers[i].Title}");
            }

            // Ask the user to pick a song
            Console.Write("\nKies een nummer om af te spelen: ");
            string input = Console.ReadLine();

            // Play the selected song
            if (int.TryParse(input, out int keuze) && keuze >= 1 && keuze <= nummers.Count)
            {
                Song gekozen = nummers[keuze - 1];
                Console.WriteLine($"\nNu speelt: {gekozen.Title} - {gekozen.Artist}");
            }
            else
            {
                Console.WriteLine("Ongeldige keuze.");
            }
        }
    }
}