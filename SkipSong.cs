using System;
using System.Collections.Generic;
using System.Text;

namespace Predify
{
    internal class SkipSong
    {
        public bool Skip(PlaySong player, List<string> songs)
        {
            if (player.isPlaying)
            {
                // Find the index of the current song
                int currentIndex = songs.IndexOf(player.currentSong);
                // Calculate the index of the next song
                int nextIndex = currentIndex + 1;

                if (nextIndex >= songs.Count)
                {
                    nextIndex = 0;
                }
                Console.WriteLine("You skipped the song.");
                // Play the next song
                player.Play(songs[nextIndex]);
                return true;
            }
            else
            {
                Console.WriteLine("No song is currently playing. Cannot skip.");
                return false;
            }
        }
    }
}
