using Microsoft.AspNetCore.Mvc;
using RazorAndFormularSampels.Models;

namespace RazorAndFormularSampels.Controllers
{
    public class MakeFormularsController : Controller
    {

        [HttpGet]
        public IActionResult Create()
        {
            return View(); //Keine Datenübergabe bei leeren Formular
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Create(Employee employee)
        {

            if (employee.LastName == "Di Caprio")
            {
                ModelState.AddModelError("LastName", "Fragen ob er mit Leonardo Di Caprio verwandt ist");
            }

            //Wir werten das Formular aus -> Validierung
            if (ModelState.IsValid)
            {
                //Speichern wir den Datensatz Richtung DB

                return RedirectToAction("Index", "Home");
                //Redirect zu einer neuen WebSeite -> bzw wir Rufen eine andere Get-Methode (Will neue Webseite sehen, wenn ich auf den Button klicke) 
            }

            //Wenn Datensatz falsch ist, wird dieser an die View mit Fehlermeldungen übergeben 
            return View(employee);
        }
    }
}
