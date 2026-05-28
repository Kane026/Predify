using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Text;
using Predify;
using System.Xml.Serialization;

namespace Predify
{
    public class SongList
    {
        public void ShowSongs()
        {
            var songs = new[]
            {
            "Never See Me Again - Kanye West - Hip Hop", "Mama's Boyfriend - Kanye West - Hip Hop", "Flashing Light - Kanye West - Hip Hop"
        };

            var songlist = AnsiConsole.Prompt(
            new SelectionPrompt<string>()
            .Title("What song would you like to listen to")
            .AddChoices(songs));

            AnsiConsole.MarkupLine($"You selected: [green]{songlist}[/]");

            if (songs.Contains(songlist))
            {
                var playSong = new PlaySong();
                playSong.Play();
            }
        }
    }
}