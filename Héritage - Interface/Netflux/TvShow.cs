public class TvShow : ISelectable{
    public string Name { get; set; }
    public List<Episode> ListOfEpisodes { get; set; }

    public TvShow(string name)
    {
        Name = name;
        ListOfEpisodes = new List<Episode>();
    }

    public void Selected(User user){
        if (user.WatchListTvShow.ContainsKey(this) ){
            int episode = user.WatchListTvShow[this];
            user.Watch(ListOfEpisodes[episode]);
            user.WatchListTvShow[this] = episode +1;
        } else {
            user.Watch(ListOfEpisodes[0]);
            user.WatchListTvShow.Add(this,1);
        }
    }
}