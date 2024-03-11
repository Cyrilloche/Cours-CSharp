User cyril = new User("Cyril", "cyril-du54@hotmail.fr");
User jessica = new User("Jessica", "jessica@gmail.com");
User mathias = new User("Mathias", "mathias@gmail.com");

TvShow dragonBall = new TvShow("Dragon Ball");

Episode dbS01E01 = new Episode(dragonBall, "Le Secret des Dragon Balls", 24, 1);
Episode dbS01E02 = new Episode(dragonBall, "Le Mont Paozu", 24, 2);
Episode dbS01E03 = new Episode(dragonBall, "Le Nuage Supersonique", 24, 3);
Episode dbS01E04 = new Episode(dragonBall, "L'Oolong le tout-puissant", 24, 4);
Episode dbS01E05 = new Episode(dragonBall, "Yamcha, le bandit du désert", 24, 5);
Episode dbS01E06 = new Episode(dragonBall, "La Terreur invisible", 24, 6);
Episode dbS01E07 = new Episode(dragonBall, "Le Vœu exaucé", 24, 7);
Episode dbS01E08 = new Episode(dragonBall, "Le Monstre aux huit membres", 24, 8);
Episode dbS01E09 = new Episode(dragonBall, "Le Mystère de la forêt", 24, 9);
Episode dbS01E10 = new Episode(dragonBall, "Le Mont Fry-Pan", 24, 10);

Movie movie01 = new Movie("Inception", 148);
Movie movie02 = new Movie("The Shawshank Redemption", 142);
Movie movie03 = new Movie("The Dark Knight", 152);
Movie movie04 = new Movie("Pulp Fiction", 154);
Movie movie05 = new Movie("Forrest Gump", 142);
Movie movie06 = new Movie("The Godfather", 175);
Movie movie07 = new Movie("Titanic", 195);
Movie movie08 = new Movie("Avatar", 162);
Movie movie09 = new Movie("Jurassic Park", 127);
Movie movie10 = new Movie("The Matrix", 136);



movie01.Selected(mathias);
dragonBall.Selected(cyril);
cyril.DisplayWatchingList();
dragonBall.Selected(cyril);


System.Console.WriteLine(cyril);
System.Console.WriteLine(jessica);
System.Console.WriteLine(mathias);
cyril.DisplayWatchingList();


Console.ReadLine();
