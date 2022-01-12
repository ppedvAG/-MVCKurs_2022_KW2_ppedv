using Microsoft.AspNetCore.Mvc;

namespace BuildUpMVCApp.Controllers
{
    public class MusicStoreController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
