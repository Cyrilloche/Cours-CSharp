public class Movie : Content , ISelectable {
    public Movie(string name, int duration) : base (name, duration)
    {
        
    }

    public void Selected(User user){
        user.Watch(this);
    }
}