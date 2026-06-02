using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Text;
using Predify;
using System.Xml.Serialization;
using System.Text.Json;

namespace Predify
{
    public class SongList
    {

        int i = 0;  
        public void ShowSongs()
        {
            List<string> songs = new List<string>
            {
            "Never See Me Again - Kanye West - Hip Hop",
            "Mama's Boyfriend - Kanye West - Hip Hop",
            "Flashing Light - Kanye West - Hip Hop"
        };

           


            foreach (var song in songs)
            {
                Console.WriteLine($"{i + 1}. {song}");
                i++;
            }
            Console.WriteLine("Welk nummer wilt u kiezen:");
            int choice = int.Parse(Console.ReadLine());


            PlaySong player = new PlaySong();
            player.Play(songs[choice - 1]);
        }

    }
}