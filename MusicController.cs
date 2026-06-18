using System;

namespace Predify
{
    public class MusicController
    {
        public void AskSong(MusicPlayer player)
        {
            Console.WriteLine("Enter 's' to stop or 'p' to pause:");
            string input = Console.ReadLine();
            if (input == "s")
            {
                player.Stop();
            }
            else if (input == "p")
            {
                player.Pause();
            }
        }
    }
}
