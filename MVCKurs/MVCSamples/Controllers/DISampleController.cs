using Microsoft.AspNetCore.Mvc;
using MyInterface;

namespace MVCSamples.Controllers
{
    public class DISampleController : Controller
    {
        //private readonly IServiceScope _service; // Jede in Controller.cs kann hier drauf zugreifen

        //public DISampleController(IServiceScope serviceScope) //Konstroktor Injection 
        //{
        //    _service = serviceScope;
        //}
        private readonly ILogger<DISampleController> _logger;   
        
        public DISampleController(ILogger<DISampleController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index([FromServices] ICarServiceScoped carServiceScoped)
        {
            carServiceScoped.Repair(new MockCar());

            _logger.LogInformation("Auto wurde repariert");
            return View();
        }

        public IActionResult Index2([FromServices] ICarScoped car)
        {
            return View(car); //Dieses Car-Objekt können wir auch in Razor ermitteln. Warum macht Car eine Touristen-Tour-Durch die Get-Action Methode, wird an View überreicht und dort ausgegeben. 
        }

        public IActionResult BetterThanIndex2()
        {
            return View();
        }
    }
}
