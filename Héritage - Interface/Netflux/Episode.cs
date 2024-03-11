public class Episode : Content {
    public string? Serie { get; set; }
    public int Number { get; set; }

    public Episode(TvShow serie, string name, int duration, int number) : base (name, duration)
    {
        Number = number;
        serie.ListOfEpisodes.Add(this);
    }

    public override string ToString()
    {
        return "Nom de la série: " + Serie 
        + "\nNom de l'épisode : " + Name
        + "\nNuméro de l'épisode : " + Number
        + "\nNombre de vues : " + Views 
        + "\n";
    }
}