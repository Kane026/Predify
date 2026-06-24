using System;
using System.Collections.Generic;

namespace Predify
{
    public class Album
    {
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

        public void ShowAlbums()
        {
            List<string> albums = new List<string>(albumSongs.Keys);

            Console.WriteLine("Albums");
            for (int i = 0; i < albums.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {albums[i]}");
            }

            Console.Write("\nKies een album: ");
            string input = Console.ReadLine();

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

        private void ShowSongsFromAlbum(string albumNaam)
        {
            List<Song> nummers = albumSongs[albumNaam];

            for (int i = 0; i < nummers.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {nummers[i].Title}");
            }

            Console.Write("\nKies een nummer om af te spelen: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int keuze) && keuze >= 1 && keuze <= nummers.Count)
            {
                Song gekozen = nummers[keuze - 1];
                Console.WriteLine($"\n Nu speelt: {gekozen.Title} - {gekozen.Artist}");
            }
            else
            {
                Console.WriteLine("Ongeldige keuze.");
            }
        }
    }
}