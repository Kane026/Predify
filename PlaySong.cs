using System;

namespace Predify
{
    public class PlaySong
    {
        // Track if the song is currently playing
        public bool isPlaying = false;
        // Track if the song is currently paused
        public bool isPaused = false;
        // Store the current song name
        public string currentSong = "";

        public void Play(string song)
        {
            // Set the song as playing and store the song name
            isPlaying = true;
            isPaused = false;
            currentSong = song;
            Console.WriteLine("Now playing: " + currentSong);
        }
    }
}