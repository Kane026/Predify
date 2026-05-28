using System;
using System.Collections.Generic;
using System.Text;

namespace Predify
{
    class Song
    {
        public String Title { get; set; }
        public String Artist { get; set; }

        public String Genre { get; set; }

            public Song(String title, String artist, String genre)
            {
                Title = title;
                Artist = artist;
                Genre = genre;
                
            }

       
    }
}
