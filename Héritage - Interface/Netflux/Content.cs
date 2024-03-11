public abstract class Content{
    public string Name { get; set; }
    public int Duration { get; set; }
    public int Views { get; set; }
    
    public Content(string name, int duration)
    {
        Name = name;
        Duration = duration;
        Views = 0;
    }

    public override string ToString()
    {
        return "Nom : " + Name 
        + "\nNombre de vues : " + Views 
        + "\n";
    }
}