using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Spotiflux
{
    public class Database
    {
        public static List<Music> PlayList { get; set; }
        public Database()
        {
            PlayList = new List<Music>();
        }
        
        public static void SearchByGenre(List<Music> playList, Genre genre)
        {
            System.Console.WriteLine("Recherche par genre : " + genre + "\n");

            IEnumerable<Music> musics = playList
                                        .Where(g => g.Genre == genre)
                                        .OrderBy(nb => nb.NumberOfStreams);
            
            foreach (var song in musics)
            {
                System.Console.WriteLine(song);
            }
        }

        public static void Search(List<Music> playList,  string research)
        {
            System.Console.WriteLine("Recherche par mot contient : " + research + "\n");

            IEnumerable<Music> musics = playList
                                        .Where(t => t.Title.Contains(research))
                                        .OrderBy(nb => nb.NumberOfStreams);

            foreach (var song in musics)
            {
                System.Console.WriteLine(song);
            }
        }
        
    }
}