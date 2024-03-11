public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int NombreDePages { get; set; }
    public Genre Genre { get; set; }

    public Book(string title, string author, int nombreDePages, Genre genre)
    {
        Title = title;
        Author = author;
        NombreDePages = nombreDePages;
        Genre = genre;
    }

    public void DisplayBook()
    {
        System.Console.WriteLine("Titre : " + Title);
        System.Console.WriteLine("Auteur : " + Author);
        System.Console.WriteLine("Nombres de pages : " + NombreDePages);
        System.Console.WriteLine("Genre : " + Genre);
        System.Console.WriteLine();
    }


}