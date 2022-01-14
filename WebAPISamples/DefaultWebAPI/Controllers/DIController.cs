using DefaultWebAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApiExplorer;

namespace DefaultWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiConventionType(typeof(DefaultApiConventions))]
    [ApiController]
    public class DIController : ControllerBase
    {
        private ITimeService _service;

        //Variante 1 via Contructor
        public DIController(ITimeService service)
        {
            _service = service;
        }
        

        [HttpGet] //http://localhost:12345/api/DI 

        [ProducesResponseType(typeof(string), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(string), StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(typeof(string), StatusCodes.Status503ServiceUnavailable)]
        public string GetCurrentTime ()
        {
            //Wenn hier ein Bug de´n ablauf beeinflusst wird ein 500er Fehler ausgeben

           return _service.GetCurrentTime();
        }


        //Variante 2 FromService
        [ApiConventionMethod(typeof(DefaultApiConventions), nameof(DefaultApiConventions.Get))]
        [HttpGet("/AlternativesDISample")]
        public string GetCurrentTimeAlternative([FromServices] ITimeService myTimeService)
        {
            return myTimeService.GetCurrentTime();
        }


        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ApiConventionNameMatch(ApiConventionNameMatchBehavior.Prefix)]
        [HttpGet("/Find")]
        public  IActionResult Find([ApiConventionNameMatch(ApiConventionNameMatchBehavior.Suffix)] int id)
        {


            return Ok();
        }

        [HttpPost("/InsertTime")] // Hinzufügen von Datensätzen
        [HttpPut("/UpdateTime")]  //Aktualalisieren von Datensätzen 
        [ApiConventionMethod(typeof(DefaultApiConventions), nameof(DefaultApiConventions.Post))]
        
        public IActionResult InsertOrUpdate(string param)
        {
            return base.Ok();
        }
    }
}
