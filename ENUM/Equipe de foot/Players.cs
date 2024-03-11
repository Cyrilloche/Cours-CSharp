using System.Collections.Concurrent;

public class Players
{
    public string Lastname { get; set; }
    public string Firstname { get; set; }
    public int Number { get; set; }
    public int YellowCard { get; set; }
    public int RedCard { get; set; }
    public PlayerStatus Status { get; set; }
    public List<string> Historic { get; set; }

    public Players(string firstname, string lastname, int number, PlayerStatus status)
    {
        Lastname = lastname;
        Firstname = firstname;
        Number = number;
        YellowCard = 0;
        RedCard = 0;
        Status = status;
        Historic = new List<string>();
    }

    public void DisplayPlayer()
    {
        System.Console.WriteLine("{0} {1} {2}", Lastname, Firstname, Number);
        bool isNotEmpty = Historic.Any();
        if (isNotEmpty)
            foreach (string historic in Historic)
            {
                System.Console.WriteLine(historic);
            }
    }
}