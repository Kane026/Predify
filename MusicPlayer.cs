using System;
using System.Collections.Generic;

namespace Predify
{
    public class MusicPlayer
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

        public void Stop()
        {
            // Set isPlaying to false and clear the current song
            isPlaying = false;
            currentSong = "";
            Console.WriteLine("The song has stopped. No song is currently playing.");
        }

        public bool Skip(List<string> songs)
        {
            if (isPlaying)
            {
                // Find the index of the current song
                int currentIndex = songs.IndexOf(currentSong);
                // Calculate the index of the next song
                int nextIndex = currentIndex + 1;
                if (nextIndex >= songs.Count)
                {
                    nextIndex = 0;
                }
                Console.WriteLine("You skipped the song.");
                // Play the next song
                Play(songs[nextIndex]);
                return true;
            }
            else
            {
                Console.WriteLine("No song is currently playing. Cannot skip.");
                return false;
            }
        }

        public void Pause()
        {
            // Pause the song and set isPaused to true
            isPlaying = false;
            isPaused = true;
            Console.WriteLine("The song is paused.");

            // Ask the user if they want to resume
            Console.WriteLine("Enter 'r' to resume:");
            string resume = Console.ReadLine();

            // If the user enters 'r', resume the song
            if (resume == "r")
            {
                isPaused = false;
                isPlaying = true;
                Console.WriteLine("Now playing: " + currentSong);
            }
        }
    }
}   