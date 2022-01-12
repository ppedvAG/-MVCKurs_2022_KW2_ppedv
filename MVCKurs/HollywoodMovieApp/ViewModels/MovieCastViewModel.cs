using HollywoodMovieApp.Models;

namespace HollywoodMovieApp.ViewModels
{
    public class MovieCastViewModel
    {
        public int Id { get; set; }

        //Auswahllisten 
        public IList<Actor> AvailableActors { get; set; } = new List<Actor>();
        public IList<Reggiseur> AvailableReggiseurs { get; set; } = new List<Reggiseur>();
        public IList<Movie> AvailableMovies { get; set; } = new List<Movie>();

        public int SelectedMovieId { get; set; } 
        public int SelectedReggiseurId { get;set; }

        public IList<int> ActorIdList { get; set; } = new List<int>();
    }
}
