Team france = new Team("France");

// Titulaire
france.ListOfPlayers.Add(new Players("Fabien", "Barthez", 16, PlayerStatus.holder));
france.ListOfPlayers.Add(new Players("Lilian", "Thuram", 15, PlayerStatus.holder));
france.ListOfPlayers.Add(new Players("Marcel", "Desailly", 5, PlayerStatus.holder));
france.ListOfPlayers.Add(new Players("Frank", "Leboeuf", 8, PlayerStatus.holder));
france.ListOfPlayers.Add(new Players("Bixente", "Lizarazu", 3, PlayerStatus.holder));
france.ListOfPlayers.Add(new Players("Emmanuel", "Petit", 17, PlayerStatus.holder));
france.ListOfPlayers.Add(new Players("Zinedine", "Zidane", 10, PlayerStatus.holder));
france.ListOfPlayers.Add(new Players("Didier", "Deschamps", 7, PlayerStatus.holder));
france.ListOfPlayers.Add(new Players("Youri", "Djorkaeff", 14, PlayerStatus.holder));
france.ListOfPlayers.Add(new Players("Stéphane", "Guivarc'h", 12, PlayerStatus.holder));
france.ListOfPlayers.Add(new Players("Zinedine", "Zidane", 10, PlayerStatus.holder));

// Remplaçant
france.ListOfPlayers.Add(new Players("Bernard", "Diomède", 21, PlayerStatus.substitute));
france.ListOfPlayers.Add(new Players("Christian", "Karembeu", 6, PlayerStatus.substitute));
france.ListOfPlayers.Add(new Players("Stéphane", "Porato", 1, PlayerStatus.substitute));
france.ListOfPlayers.Add(new Players("Frank", "Djorkaeff", 19, PlayerStatus.substitute));
france.ListOfPlayers.Add(new Players("Marcel", "Djorkaeff", 20, PlayerStatus.substitute));
france.ListOfPlayers.Add(new Players("Lionel", "Charbonnier", 22, PlayerStatus.substitute));
france.ListOfPlayers.Add(new Players("Vincent", "Candela", 2, PlayerStatus.substitute));



Team brazil = new Team("Brésil");

// Titulaire
brazil.ListOfPlayers.Add(new Players("Cláudio", "Taffarel", 1, PlayerStatus.holder));
brazil.ListOfPlayers.Add(new Players("Cafu", "Cafu", 2, PlayerStatus.holder));
brazil.ListOfPlayers.Add(new Players("Junior", "Aldair", 4, PlayerStatus.holder));
brazil.ListOfPlayers.Add(new Players("Roberto", "Carlos", 6, PlayerStatus.holder));
brazil.ListOfPlayers.Add(new Players("Cézar", "Sampaio", 5, PlayerStatus.holder));
brazil.ListOfPlayers.Add(new Players("Ronaldo", "Nazário", 9, PlayerStatus.holder));
brazil.ListOfPlayers.Add(new Players("Roberto", "Rivaldo", 11, PlayerStatus.holder));
brazil.ListOfPlayers.Add(new Players("Ricardinho", "Ricardinho", 16, PlayerStatus.holder));
brazil.ListOfPlayers.Add(new Players("Rivaldo", "Ferreira", 10, PlayerStatus.holder));
brazil.ListOfPlayers.Add(new Players("Romário", "Romário", 11, PlayerStatus.holder));
brazil.ListOfPlayers.Add(new Players("Cafu", "Cafu", 2, PlayerStatus.holder));


// Remplaçant
brazil.ListOfPlayers.Add(new Players("Zé Carlos", "José Carlos", 21, PlayerStatus.substitute));
brazil.ListOfPlayers.Add(new Players("Aldair", "Aldair", 3, PlayerStatus.substitute));
brazil.ListOfPlayers.Add(new Players("Amaral", "Amarildo", 15, PlayerStatus.substitute));
brazil.ListOfPlayers.Add(new Players("Bebeto", "Roberto", 7, PlayerStatus.substitute));
brazil.ListOfPlayers.Add(new Players("Carlos Germano", "Carlos Germano", 12, PlayerStatus.substitute));
brazil.ListOfPlayers.Add(new Players("Dunga", "Carlos", 8, PlayerStatus.substitute));
brazil.ListOfPlayers.Add(new Players("Edmundo", "Edmundo", 13, PlayerStatus.substitute));



Match.Announcement();
france.DisplayComposition();
brazil.DisplayComposition();
Match.Start();


Console.ReadLine();
france.GiveACard("Deschamps", 7, Cards.Rouge);
Console.ReadLine();
france.CheckCards();
france.Hurting("Zidane", 10);

Team.Transferts("Aldair", 3, brazil, france);

france.DisplayComposition();
brazil.DisplayComposition();

france.DisplayOutAndHurt();


Console.ReadLine();
