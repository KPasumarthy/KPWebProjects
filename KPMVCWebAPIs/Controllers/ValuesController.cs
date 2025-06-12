using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KPMVCWebAPIs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]   // GET /api/values
        public IActionResult ListProducts()
        {
            string currentDate = DateTime.Now.ToString("MM/dd/yyyy HH:mm:sss tt");
            string input = "KP : KPMVCWebAPIs : ValuesController : Today's Date : " + currentDate;
            Console.WriteLine("KP : KPMVCWebAPIs : ValuesController : Today's Date : " + currentDate);

            return Ok(new { Message = input, RouteData = ControllerContext.RouteData.Values });
        }

        [HttpGet("{id}")]   // GET /api/values/xyz
        public IActionResult GetProduct(string id)
        {
            string currentDate = DateTime.Now.ToString("MM/dd/yyyy HH:mm:sss tt");
            string input = "KP : KPMVCWebAPIs : ValuesController : Today's Date : " + currentDate;
            Console.WriteLine("KP : KPMVCWebAPIs : ValuesController : Today's Date : " + currentDate);

            return Ok(new { Message = input, RouteData = ControllerContext.RouteData.Values, Id = id });
        }

        [HttpGet("int/{id:int}")] // GET /api/values/int/3
        public IActionResult GetIntProduct(int id)
        {
            string currentDate = DateTime.Now.ToString("MM/dd/yyyy HH:mm:sss tt");
            string input = "KP : KPMVCWebAPIs : ValuesController : Today's Date : " + currentDate;
            Console.WriteLine("KP : KPMVCWebAPIs : ValuesController : Today's Date : " + currentDate);

            return Ok(new { Message = input, RouteData = ControllerContext.RouteData.Values, Id = id });
        }

        [HttpGet("int2/{id}")]  // GET /api/values/int2/3
        public IActionResult GetInt2Product(int id)
        {
            string currentDate = DateTime.Now.ToString("MM/dd/yyyy HH:mm:sss tt");
            string input = "KP : KPMVCWebAPIs : ValuesController : Today's Date : " + currentDate;
            Console.WriteLine("KP : KPMVCWebAPIs : ValuesController : Today's Date : " + currentDate);

            return Ok(new { Message = input, RouteData = ControllerContext.RouteData.Values, Id = id });
        }
    }
}
