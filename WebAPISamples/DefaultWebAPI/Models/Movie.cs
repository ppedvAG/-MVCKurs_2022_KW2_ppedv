namespace DefaultWebAPI.Models
{
    public class Movie
    {
        public int Id { get; set; } 
        public string Title { get; set; }
        public string Description { get; set; } 

        public GenreTyp Genre { get; set; }
    }

    public enum GenreTyp { Action, Drama, Thriller, Comedy, Romance, Docu}
}
