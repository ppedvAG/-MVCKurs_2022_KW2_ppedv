using Microsoft.AspNetCore.Mvc;

namespace BuildUpMVCApp.Controllers
{
    //Im Browser wird HomeController so angesteuert -> https://localhost:12345/Home     -> In
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}
