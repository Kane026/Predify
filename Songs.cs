using System;
using System.Collections.Generic;
using System.Text;

namespace Predify
{
    class Song
    {
        public String Title { get; set; }
        public String Artist { get; set; }

            public Song(String title, String artist)
            {
                Title = title;
                Artist = artist;
            }

       
    }
}
