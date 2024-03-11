using Spotiflux;

internal class Program
{
    private static void Main(string[] args)
    {
       Database playList = new Database();

        Music music1 = new Music(playList, "Ludwig van Beethoven", "Symphony No.5", Genre.Classique, 330, 0);
        Music music2 = new Music(playList, "Wolfgang Amadeus Mozart", "Eine kleine Nachtmusik", Genre.Classique, 320, 0);
        Music music3 = new Music(playList, "Johann Sebastian Bach", "Toccata and Fugue in D minor", Genre.Classique, 540, 0);
        Music music4 = new Music(playList, "Antonio Vivaldi", "The Four Seasons", Genre.Classique, 2520, 0);
        Music music5 = new Music(playList, "Pyotr Ilyich Tchaikovsky", "Swan Lake", Genre.Classique, 4620, 0);

        Music music6 = new Music(playList, "The Beatles", "Come Together", Genre.Rock, 259, 0);
        Music music7 = new Music(playList, "Led Zeppelin", "Stairway to Heaven", Genre.Rock, 480, 0);
        Music music8 = new Music(playList, "Queen", "Bohemian Rhapsody", Genre.Rock, 355, 0);
        Music music9 = new Music(playList, "Pink Floyd", "Comfortably Numb", Genre.Rock, 384, 0);
        Music music10 = new Music(playList, "The Rolling Stones", "Paint It Black", Genre.Rock, 202, 0);

        Music music11 = new Music(playList, "Tupac Shakur", "California Love", Genre.Rap, 262, 0);
        Music music12 = new Music(playList, "Notorious B.I.G.", "Juicy", Genre.Rap, 300, 0);
        Music music13 = new Music(playList, "Eminem", "Lose Yourself", Genre.Rap, 326, 0);
        Music music14 = new Music(playList, "Kendrick Lamar", "HUMBLE.", Genre.Rap, 177, 0);
        Music music15 = new Music(playList, "Jay-Z", "99 Problems", Genre.Rap, 207, 0);

        Music music16 = new Music(playList, "Édith Piaf", "La Vie en rose", Genre.Variété, 192, 0);
        Music music17 = new Music(playList, "Charles Aznavour", "La Bohème", Genre.Variété, 240, 0);
        Music music18 = new Music(playList, "Jacques Brel", "Ne me quitte pas", Genre.Variété, 232, 0);
        Music music19 = new Music(playList, "Claude François", "Comme d'habitude", Genre.Variété, 240, 0);
        Music music20 = new Music(playList, "Jean-Jacques Goldman", "Je te donne", Genre.Variété, 250, 0);


        Database.SearchByGenre(Database.PlayList, Genre.Rock);

        Database.Search(Database.PlayList, "Symph");

        Console.ReadLine();
    }
}