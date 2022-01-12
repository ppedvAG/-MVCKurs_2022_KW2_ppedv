namespace HollywoodMovieApp.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public GenreType Genre { get; set; }

        public int? ReggiseurId { get; set; }

    }


    public enum GenreType { Action, Thriller, Drama, Comdedy, Romance, Horror, Documentary}
}
