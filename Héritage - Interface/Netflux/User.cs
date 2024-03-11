public class User{
    public string Nickname { get; set; }
    public string Mail { get; set; }
    public int Watchtime { get; set; }
    public List<Content> WatchingList { get; set; }
    public Dictionary<TvShow , int > WatchListTvShow { get; set; }
    
    
    public User(string nickname, string mail)
    {
        Nickname = nickname;
        Mail = mail;
        Watchtime = 0;
        WatchingList = new List<Content>();
        WatchListTvShow = new Dictionary<TvShow, int>();
    }

    public override string ToString()
    {
        return "Pseudo : " + Nickname 
        + "\nMail : " + Mail 
        + "\nTemps de visionnage : " + Watchtime
        + "\n";
    }

    public void Watch(Content content){
        Watchtime += content.Duration;
        content.Views +=1;
        WatchingList.Add(content);
    }

    public void DisplayWatchingList(){
        System.Console.WriteLine($"{Nickname} a regardé :");
        foreach (Content content in WatchingList)
        {
            System.Console.WriteLine(content);
        }
    }
    public void Select(ISelectable content){
        content.Selected(this);
    }


}