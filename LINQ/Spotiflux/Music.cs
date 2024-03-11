using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Spotiflux
{
    public class Music
    {
        public string Artist { get; set; }
        
        public string Title { get; set; }
        
        public Genre Genre { get; set; }

        public int Duration { get; set; }
        
        public int NumberOfStreams { get; set; }
        
        public Music(Database playlist, string artist, string title, Genre genre, int duration, int numberOfStreams)
        {
            Artist = artist;
            Title = title;
            Genre = genre;
            Duration = duration;
            NumberOfStreams = numberOfStreams;

            Database.PlayList.Add(this);
        }

        public override string ToString()
        {
            return "Artiste :" + Artist + "\nTitre : " + Title + "\nGenre : " + Genre + "\nDurée : " + Duration + "\nNombre de stream : " + NumberOfStreams + "\n";
        }


    }
}