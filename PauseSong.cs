using System;

namespace Predify
{
    public class PauseSong
    {
        public void SongPause(PlaySong player)
        {
            // Pause the song and set isPaused to true
            player.isPlaying = false;
            player.isPaused = true;
            Console.WriteLine("The song is paused.");

            // Ask the user if they want to resume
            Console.WriteLine("Enter 'r' to resume:");
            string resume = Console.ReadLine();

            // If the user enters 'r', resume the song
            if (resume == "r")
            {
                player.isPaused = false;
                player.isPlaying = true;
                Console.WriteLine("Now playing: " + player.currentSong);
            }
        }
    }
}