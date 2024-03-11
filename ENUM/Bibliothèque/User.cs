public class User
{
    public string Lastname { get; set; }
    public string FirstName { get; set; }
    public List<Book> BorrowedBooks { get; set; }

    public User(string lastname, string firstname)
    {
        Lastname = lastname;
        FirstName = firstname;
        BorrowedBooks = new List<Book>();
    }
    public void AddToBorrowedList(string title)
    {
        foreach (Book book in Database.ListOfBooks)
        {
            if (title == book.Title)
            {
                BorrowedBooks.Add(book);
                Database.ListOfBooks.Remove(book);
                break;
            }
        }
    }

    public void ReturnABook(string title)
    {
        foreach (Book book in BorrowedBooks)
        {
            if (title == book.Title)
            {
                Database.ListOfBooks.Add(book);
                BorrowedBooks.Remove(book);
                break;
            }
        }
    }

    public void DisplayBorrowedBookByUser()
    {
        System.Console.WriteLine("L'utilisateur : {0} {1} a emprunté :", Lastname, FirstName);
        foreach (Book book in BorrowedBooks)
        {
            book.DisplayBook();
        }
    }

}