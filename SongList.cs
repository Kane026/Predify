using System;
using System.Collections.Generic;

namespace Predify
{
    public class SongList
    {
        public void ShowSongs()
        {
            // List of available songs
            List<string> songs = new List<string>
            {
                "Never See Me Again - Kanye West - Hip Hop",
                "Mama's Boyfriend - Kanye West - Hip Hop",
                "Flashing Light - Kanye West - Hip Hop"
            };

            // Display all songs
            Console.WriteLine("1. " + songs[0]);
            Console.WriteLine("2. " + songs[1]);
            Console.WriteLine("3. " + songs[2]);

            // Ask the user to pick a song
            Console.WriteLine("Which song would you like to play:");
            int choice = int.Parse(Console.ReadLine());

            // Play the selected song
            MusicPlayer player = new MusicPlayer();
            player.Play(songs[choice - 1]);

            // Ask the user to stop or pause
            MusicController control = new MusicController();
            control.AskSong(player, songs);
        }
    }
}