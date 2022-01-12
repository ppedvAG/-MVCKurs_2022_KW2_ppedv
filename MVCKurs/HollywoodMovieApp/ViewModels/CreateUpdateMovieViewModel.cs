using HollywoodMovieApp.Models;

namespace HollywoodMovieApp.ViewModels
{
    public class CreateUpdateMovieViewModel
    {
        public Movie CurrentMovie { get; set; } = new Movie();

        public IList<Reggiseur> AvailableReggiseurs = new List<Reggiseur>();
        
        
    }
}
