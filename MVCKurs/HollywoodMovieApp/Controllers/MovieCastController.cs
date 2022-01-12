using HollywoodMovieApp.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace HollywoodMovieApp.Controllers
{
    public class MovieCastController : Controller
    {




        public IActionResult CreateMovieCast()
        {
            MovieCastViewModel movieCastViewModel = new MovieCastViewModel();



            return View();
        }
    }
}
