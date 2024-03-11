public class Team
{
    public string Name { get; set; }
    public List<Players> ListOfPlayers { get; set; }

    public Team(string name)
    {
        Name = name;
        ListOfPlayers = new List<Players>();
    }


    public void DisplayComposition()
    {
        System.Console.WriteLine("\nEquipe : {0}\nLes titulaires : \n", Name);
        foreach (Players player in ListOfPlayers)
        {
            if (player.Status == PlayerStatus.holder)
                player.DisplayPlayer();
        }
        System.Console.WriteLine("\nLes replaçants :");
        foreach (Players player in ListOfPlayers)
        {
            if (player.Status == PlayerStatus.substitute)
                player.DisplayPlayer();
        }
        System.Console.WriteLine();
    }


    public void DisplaySubstitute()
    {
        System.Console.WriteLine("Un de vos joueurs doit se faire remplacer. Voici la liste des remplaçcants disponibles :");
        foreach (Players player in ListOfPlayers)
        {
            if (player.Status == PlayerStatus.substitute)
            {
                player.DisplayPlayer();
            }
        }
        System.Console.WriteLine("\nChoisissez le remplaçant ! \nNom:");
        string choice = Console.ReadLine();
        System.Console.WriteLine("Numéro de maillot");
        int choiceByNumber = int.Parse(Console.ReadLine());
        Replacement(choice, choiceByNumber);
    }


    public void DisplayOutAndHurt()
    {
        System.Console.WriteLine("Liste des joueurs rentrés au vestiaire :");
        foreach (Players player in ListOfPlayers)
        {
            if (player.Status == PlayerStatus.hurt || player.Status == PlayerStatus.off)
            {
                player.DisplayPlayer();
            }
        }
    }


    public void GiveACard(string name, int number, Cards cards)
    {
        foreach (Players player in ListOfPlayers)
        {
            if (player.Lastname == name && player.Number == number)
            {
                switch (cards)
                {
                    case Cards.Jaune:
                        player.YellowCard++;
                        System.Console.WriteLine("Carton jaune pour {0}", player.Lastname);
                        break;
                    case Cards.Rouge:
                        player.RedCard++;
                        System.Console.WriteLine("Carton rouge pour {0}", player.Lastname);
                        break;
                    default:
                        break;
                }
            }
        }
    }

    public void Hurting(string name, int number)
    {
        foreach (Players player in ListOfPlayers)
        {
            if (player.Lastname == name && player.Number == number)
            {
                System.Console.WriteLine("Catastrophe !! {0} s'est blessé au pouce..", player.Lastname);
                player.Status = PlayerStatus.hurt;
                player.Historic.Add("Sortis sur blessure, j'éspère que ce n'est pas trop grave");
                Console.ReadLine();
                DisplaySubstitute();
                break;
            }
        }
    }

    public void Replacement(string choice, int number)
    {
        foreach (Players player in ListOfPlayers)
        {
            if (choice == player.Lastname && player.Number == number)
            {
                player.Status = PlayerStatus.holder;
                System.Console.WriteLine("OK {0} c'est à ton tour de rentrer !", player.Lastname);
                break;
            }
        }
        Console.Clear();
    }


    public void CheckCards()
    {
        foreach (Players player in ListOfPlayers)
        {
            if (player.YellowCard == 2)
            {
                System.Console.WriteLine("Le joueur {0} {1} a reçu 2 cartons jaunes, il est exclus de la partie",
                    player.Lastname, player.Firstname);
                player.Status = PlayerStatus.off;
                player.Historic.Add("Exclusion à cause du nombre de cartons jaunes reçus");
                DisplaySubstitute();
            }
            if (player.RedCard == 1)
            {
                System.Console.WriteLine("Le joueur {0} {1} a reçu un rouge, il est exclus de la partie",
                    player.Lastname, player.Firstname);
                player.Historic.Add("Expulsion pour carton rouge");
                player.Status = PlayerStatus.off;
                DisplaySubstitute();
            }
        }
    }

    public static void Transferts(string firstPlayer, int numberOfPlayer, Team firstTeam, Team secondTeam)
    {
        foreach (Players player in firstTeam.ListOfPlayers)
        {
            if (player.Lastname == firstPlayer && player.Number == numberOfPlayer)
            {
                firstTeam.ListOfPlayers.Remove(player);
                player.Historic.Add($"Le joueur a quitté son club de {firstTeam.Name} pour rejoindre sa nouvelle équipe : {secondTeam.Name}");
                secondTeam.ListOfPlayers.Add(player);
                break;
            }
        }

    }

}