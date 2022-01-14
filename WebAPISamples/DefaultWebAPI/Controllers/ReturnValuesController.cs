using DefaultWebAPI.Data;
using DefaultWebAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DefaultWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReturnValuesController : ControllerBase
    {
        private readonly DefaultWebAPIContext _context;

        public ReturnValuesController(DefaultWebAPIContext context)
        {
            _context = context;
        }


        #region Native Datentypen

        [HttpGet("/GetNativeDatatype")]
        public string SayHello()
        {
            return "Hello";
        }

        //int, float, string wird immer als String zurück gegeben....bzw es wird nicht in JSON/XML serialisiert

        //Auch hier bekmme ich einen string zurückgegeben -> (Kein JSON)
        [HttpGet("/SayHalloWithContentResult")]
        public ContentResult SayHalloWithContentResult()
        {
            return Content("Say Hello");
        }
        #endregion


        #region Einfache komplexe Objekte

        [HttpGet("/GetEmployeeObj")]
        public Employee GetEmployee()
        {
            //Nachteil dieses Methodenaufbaus -> Es ist nicht möglich Fehlercodes manuell auszugeben 
            return _context.Employee.FirstOrDefault(); //hier sendet er einen 200er Code
        }


        [HttpGet("/GetEmployeeListObj")]
        public List<Employee> GetEmployeeList()
        {
            return _context.Employee.ToList();
        }
        #endregion

        #region IActionResult / ActionResult

        //Mit IActionResult kann man Daten auch zurück gegben. Vielfältiger wäre ActionResult mit seinen abgeleiteten Klassen
        //Sonst wird IAcitonResult bei PUT / POST '/ Delete verwedet um lediglich einen Statuscode zurück zusenden -> Ok(employee) /  BadRequest()

        [HttpGet("/GetEmployeeWithIActionResult")]
        public IActionResult GetEmployeeWithIActionResult ()
        {
            //Eine Validierung die einen Fehler provosieren soll
            if (_context.Employee.Count() > 5)
            {
                return BadRequest();
            }
            return Ok(_context.Employee.FirstOrDefault());
        }


        //IActionResult wird eignetlich bei POST /PUT / Delete verwendet

        [HttpPost()]
        public IActionResult CreateEmployee(Employee employee)
        {
            if (employee.LastName == "Reichelt")
                return BadRequest();


            _context.Employee.Add(employee);
            _context.SaveChanges();

            return Ok();
        }


        //ActionResult
        [HttpGet("/GetEmployeeWithActionResult")]
        public ActionResult GetEmployeeWithActionResult()
        {
            if (_context.Employee.Count() > 1)
                return BadRequest(); 


            return Ok(_context.Employee.FirstOrDefault());
        }



        [HttpGet("syncsale")]
        public IEnumerable<Employee> GetOnSaleProducts()
        {
            IList<Employee> employees = _context.Employee.ToList();

            foreach (var employee in employees)
            {
                yield return employee;
            }
        }

        [HttpGet("asyncsale")]
        public async IAsyncEnumerable<Employee> GetOnSaleProductsAsync()
        {
            IAsyncEnumerable<Employee> employees = _context.Employee.AsAsyncEnumerable(); 

            await foreach (var employee in employees)
            {
                yield return employee;
            }
        }
        #endregion
    }
}
