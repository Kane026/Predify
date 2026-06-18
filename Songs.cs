    using System;

    namespace Predify
    {
        class Song
        {
            // Properties of a song
            public string Title { get; set; }
            public string Artist { get; set; }
            public string Genre { get; set; }

            // Constructor to create a song
            public Song(string title, string artist, string genre)
            {
                Title = title;
                Artist = artist;
                Genre = genre;
            }
        }
    }