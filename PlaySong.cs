using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using Spectre.Console;

namespace Predify
{
    public class PlaySong
    {
        private bool isPlaying = false;

        public void Play(string song)
        {
            isPlaying = true;
            Console.WriteLine($"Now playing: {song}");
        }
    }
}
