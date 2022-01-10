using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using MVCSamples.Models;

namespace MVCSamples.Controllers
{
    //Eisntieg und Configuration -> OptionPatternSample.cs 
    public class ConfigurationSampleWithoutIConfigurationController : Controller
    {
        private readonly PositionOptions _positionOptions;

        private readonly ArrayExample arrayExample;

        //IOptionsSnapshot wird verwendet, damit die Datanstrutur neu geladen wird, wenn die Konfigurations-Datei bearbeitet wurde 

        public ConfigurationSampleWithoutIConfigurationController(IOptionsSnapshot<PositionOptions> positionOptions, IOptionsSnapshot<ArrayExample> array) //Konstruktor Injections = wenn man Controllerweit(jede Action-MEthode)  eine Instanz verwenden möchte
        {
            _positionOptions = positionOptions.Value;
            arrayExample = array.Value;
        }


        public IActionResult Index([FromServices] PositionOptions options) //wäre Methodenweit
        {
            return View();
        }

        public ContentResult OptionPatternSample1 ()
        {
            return Content(_positionOptions.Name + " - " + _positionOptions.Title);
        }


        public ContentResult ShowArray()
        {
            string str = string.Empty;

            foreach (string arrayEntry in arrayExample.Entries)
                str = str + arrayEntry + "\n";

            return Content(str); //Ausgabe des kompletten Arrays 
        }

    }
}
