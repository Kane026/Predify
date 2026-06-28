using System;

namespace Predify
{
    public class MusicController
    {
        public void AskSong(MusicPlayer player)
        {
            // Ask the user if they want to stop or pause the song
            Console.WriteLine("Enter 's' to stop or 'p' to pause:");
            string input = Console.ReadLine();

            // If the user enters 's', stop the song
            if (input == "s")
            {
                player.SongStop();
            }
            // If the user enters 'p', pause the song
            else if (input == "p")
            {
                player.SongPause();
            }
        }
    }
}