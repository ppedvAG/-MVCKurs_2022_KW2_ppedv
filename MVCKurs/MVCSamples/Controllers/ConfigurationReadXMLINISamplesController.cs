using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace MVCSamples.Controllers
{
    public class ConfigurationReadXMLINISamplesController : Controller
    {
       
        public ContentResult Index([FromServices] IOptionsSnapshot<PositionOptions> position)
        {
            PositionOptions positionOptions = position.Value;
            return Content(positionOptions.Name + " - " + positionOptions.Title);
        }
    }
}
