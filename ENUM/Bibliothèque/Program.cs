Database.Initialize();

User utilisateur = new User("Cherrier", "Cyril");

Database.DisplayBookAvailable();

utilisateur.AddToBorrowedList("Shining");
utilisateur.AddToBorrowedList("Ça");

utilisateur.DisplayBorrowedBookByUser();

Database.DisplayBookAvailable();

utilisateur.ReturnABook("Shining");

utilisateur.DisplayBorrowedBookByUser();

Database.DisplayBookAvailable();

//Database.DisplayBooksByGenre(Genre.Fantastique);
//Database.DisplayBooksByAuthor("Stephen King");
//Database.DisplayBooksByTitle("Shining");

Console.ReadLine();
