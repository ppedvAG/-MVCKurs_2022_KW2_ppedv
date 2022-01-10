using Microsoft.AspNetCore.Mvc;
using MVCSamples.Models;

namespace MVCSamples.Controllers
{
    //Was passiert, wenn eine Webseite in MVC angezeigt wird

    // 1.) Client-Browser gibt eine URl in Brpwser ein und sendet diese ab (Request) 

    // 2.) WebApp (bzw MVC-Middleware (Endpunkt) versteht, URL ist so aufgebaut, dass diese nur eine HTML Seite aufrufen möchte
    // 2a.) MVC-Middleware leitet Request an Controller und seiner Action-Methode weiter 

    // 2aa.) DefaultControllerFactory wird aufggerufen und ConfigurationSamplesController wird als Instanz uns zurückgeliefert 


    //ALLE BEISPIELE verwenden -> private readonly IConfiguration _configuration; 

    public class ConfigurationSamplesController : Controller
    {
        //IConfiguration beinhaltet ALLE Konfigurationen (auch wenn Konfigurationen aus mehreren ConfigProvider stammen (mehre Konfigquellen)) 
        private readonly IConfiguration _configuration;


        //Konstruktor-Injection -> bzw Konstruktor fordert eine Instanz vom Typ IConfiguration
        public ConfigurationSamplesController (IConfiguration configuration) //Hier lesen wir IConfiguration aus dem IOC Container heraus 
            => _configuration = configuration; 
        
        //Beispiel 1: 
        //Was ist ContentResult -> gibt einen string zurück 
        public ContentResult DisplayAllEnvironmentVariables()
        {
            string str = string.Empty;

            foreach (KeyValuePair<string, string> c in _configuration.AsEnumerable())
            {
                str = str + $"{c.Key} = {c.Value} + \n";
            }

            return Content(str); //Inhalt von str wird als einfacher String ausgegben
        }


        //Beispiel 2: 
        public ContentResult DisplayAllProvider()
        {
            IConfigurationRoot configRoot = (IConfigurationRoot)_configuration;

            string str = "";
            foreach (var provider in configRoot.Providers.ToList())
            {
                str += provider.ToString() + "\n";
            }

            return Content(str);
        }

        //Beispiel 3:
        //Zeige alle Provider an
        public ContentResult IConfigurationExplicietRead()
        {
            var myKeyValue = _configuration["MyKey"]; //AppSettings ->MyKey -> Value wird ausgelesen 

            var title = _configuration["Position:Title"]; //AppSettings ->Position->Title -> Value wird ausgelesen 
            var name = _configuration["Position:Name"]; //AppSettings ->Position->Name -> Value wird ausgelesen 

            var defaultLogLevel = _configuration["Logging:LogLevel:Default"];//AppSettings ->Logging->LogLevel->Default-> Value wird ausgelesen 


            return Content($"MyKey value: {myKeyValue} \n + " +
                                   $"Title: {title} \n + " +
                                   $"Name: { name} \n" +
                                   $"DefaultLogLevel: {defaultLogLevel}");
        }

        //Beispiel 4:
        //IOption-Pattern Sample 1
        public ContentResult ShowTypisiertesAuslesenMitPositionOptionClassAsStructure()
        {
            PositionOptions positionOptions = new(); //Strutktur 

            _configuration.GetSection(PositionOptions.Position) //Auslesen der kompleten Sektion "Position"
                .Bind(positionOptions); //Hier wird das Ergebnis an die Struktur übertragen + Tipp: Key-Names (AppSettings) und Properties (PositionOptions) müssen vom Namen her gleich sein. Sonst kein Mapping der Werte möglich

            return Content($"Title: {positionOptions.Title} \n" +
                          $"Name: {positionOptions.Name}");
        }


        //Beispiel 4:
        //IOption-Pattern Sample 1
        public ContentResult ShowTypisiertesAuslesenMitPositionOptionClassAsStructureVariante2()
        {
            PositionOptions positionOptions = new(); //Strutktur 

            _configuration.GetSection(PositionOptions.Position) //Auslesen der kompleten Sektion "Position"
                .Get<PositionOptions>();

            return Content($"Title: {positionOptions.Title} \n" +
                          $"Name: {positionOptions.Name}");
        }
    }
}
