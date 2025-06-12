using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KPMVCWebAPIs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Test2Controller : ControllerBase
    {
        [HttpGet]   // GET /api/test2
        public IActionResult ListProducts()
        {
            string currentDate = DateTime.Now.ToString("MM/dd/yyyy HH:mm:sss tt");
            string input = "KP : KPMVCWebAPIs : Today's Date : " + currentDate;
            Console.WriteLine("KP : KPMVCWebAPIs ! : Today's Date : " + currentDate);

            return Ok(new { Message = input, RouteData = ControllerContext.RouteData.Values });
        }

        [HttpGet("{id}")]   // GET /api/test2/xyz
        public IActionResult GetProduct(string id)
        {
            string currentDate = DateTime.Now.ToString("MM/dd/yyyy HH:mm:sss tt");
            string input = "KP : Today's Date : " + currentDate;
            Console.WriteLine("KP : KPMVCWebAPIs ! : Today's Date : " + currentDate);

            return Ok(new { Message = input, RouteData = ControllerContext.RouteData.Values, Id = id });
        }

        [HttpGet("int/{id:int}")] // GET /api/test2/int/3
        public IActionResult GetIntProduct(int id)
        {
            string currentDate = DateTime.Now.ToString("MM/dd/yyyy HH:mm:sss tt");
            string input = "KP : Today's Date : " + currentDate;
            Console.WriteLine("KP : KPMVCWebAPIs ! : Today's Date : " + currentDate);

            return Ok(new { Message = input, RouteData = ControllerContext.RouteData.Values, Id = id });
        }

        [HttpGet("int2/{id}")]  // GET /api/test2/int2/3
        public IActionResult GetInt2Product(int id)
        {
            string currentDate = DateTime.Now.ToString("MM/dd/yyyy HH:mm:sss tt");
            string input = "KP : Today's Date : " + currentDate;
            Console.WriteLine("KP : KPMVCWebAPIs ! : Today's Date : " + currentDate);

            return Ok(new { Message = input, RouteData = ControllerContext.RouteData.Values, Id = id });
        }
    }
}
