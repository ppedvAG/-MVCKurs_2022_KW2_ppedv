using Microsoft.AspNetCore.Mvc;
using RazorAndFormularSampels.Models;

namespace RazorAndFormularSampels.Controllers
{

    //Hier zeigen wir Beispiele -> Wie wir Daten an eine View übergeben 
    public class ShowModelsInViewSampleController : Controller
    {
        public IActionResult WithoutModelsDeclaration()
        {
            //Native Datentypen benötoigen keine Modelangabe

            //Was ist ein Nativer Datentyp -> int / string / float / decimal 
            //Was gibt es noch? -> string[] 

            IList<string> stringListe = new List<string>();
            stringListe.Add("Max");
            stringListe.Add("Moritz");
            stringListe.Add("Gretel");
            

            return View(stringListe); //Hier werden Datensätze für die View angegben, die in View dargestellt werden. 
        }

        public IActionResult WithModelWithoutDeclaration()
        {
            //Erstellen eines komplexen Objektes 
            Employee employee = new();
            employee.FirstName = "Max";
            employee.LastName = "Mustermann";
            employee.Birthday = DateTime.Now;
            employee.Address = "Köln";


            return View(employee);
        }

        public IActionResult WithModelDeclaration()
        {
            Employee employee = new();
            employee.FirstName = "Max";
            employee.LastName = "Mustermann";
            employee.Birthday = DateTime.Now;
            employee.Address = "Köln";


            return View(employee);
        }

        public IActionResult WithScaffoldingGenerator()
        {
            Employee employee = new();
            employee.FirstName = "Max";
            employee.LastName = "Mustermann";
            employee.Birthday = DateTime.Now;
            employee.Address = "Köln";


            return View(employee);
        }

        public IActionResult WithViewModelDeclaration()
        {
            return View();
        }
    }
}
