using System;

namespace Predify
{
    public class StopSong
    {
        public void SongStop(PlaySong player)
        {
            // Set isPlaying to false and clear the current song
            player.isPlaying = false;
            player.currentSong = "";
            Console.WriteLine("The song has stopped. No song is currently playing.");
        }
    }
}