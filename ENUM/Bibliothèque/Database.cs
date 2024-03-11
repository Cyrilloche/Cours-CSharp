public class Database
{
    public static List<Book> ListOfBooks { get; set; }

    public static void Initialize()
    {
        ListOfBooks = new List<Book>();
        ListOfBooks.Add(new Book("L'Étranger", "Albert Camus", 123, Genre.Roman));
        ListOfBooks.Add(new Book("L'Écume des jours", "Boris Vian", 315, Genre.Roman));
        ListOfBooks.Add(new Book("Orgueil et Préjugés", "Jane Austen", 432, Genre.Roman));

        ListOfBooks.Add(new Book("Ça", "Stephen King", 1138, Genre.Horreur));
        ListOfBooks.Add(new Book("L'Exorciste", "William Peter Blatty", 385, Genre.Horreur));
        ListOfBooks.Add(new Book("Shining", "Stephen King", 447, Genre.Horreur));

        ListOfBooks.Add(new Book("Harry Potter à l'école des sorciers", "J.K. Rowling", 332, Genre.Fantastique));
        ListOfBooks.Add(new Book("Le Seigneur des Anneaux : La Communauté de l'Anneau", "J.R.R. Tolkien", 527, Genre.Fantastique));
        ListOfBooks.Add(new Book("Chroniques de la Lune Noire - La Marque des démons", "François Froideval", 48, Genre.Fantastique));

        ListOfBooks.Add(new Book("Millénium, tome 1 : Les Hommes qui n'aimaient pas les femmes", "Stieg Larsson", 672, Genre.Policier));
        ListOfBooks.Add(new Book("Le Silence des agneaux", "Thomas Harris", 448, Genre.Policier));
        ListOfBooks.Add(new Book("Gone Girl", "Gillian Flynn", 560, Genre.Policier));

    }

    public static void DisplayBookAvailable()
    {
        System.Console.WriteLine("Les livres disponibles à la location sont :");
        foreach (Book book in ListOfBooks)
        {
            System.Console.WriteLine(book.Title);
        }
        System.Console.WriteLine();
    }

    public static void DisplayBooksByGenre(Genre genre)
    {

        foreach (Book book in ListOfBooks)
        {
            if (genre == book.Genre)
            {
                book.DisplayBook();
            }
        }
    }


    public static void DisplayBooksByAuthor(string authorToDisplay)
    {
        foreach (Book book in ListOfBooks)
        {
            if (book.Author == authorToDisplay)
            {
                book.DisplayBook();
            }
        }
    }
    public static void DisplayBooksByTitle(string bookToDisplay)
    {
        foreach (Book book in ListOfBooks)
        {
            if (book.Title == bookToDisplay)
            {
                book.DisplayBook();
            }
        }
    }

}