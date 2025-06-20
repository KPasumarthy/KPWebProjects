using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using KPMVCWebAPIs.Database;
using KPMVCWebAPIs.Models;
namespace KPMVCWebAPIs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        [HttpGet]   // GET /api/person
        public IActionResult ListPersons()
        {
            string currentDate = DateTime.Now.ToString("MM/dd/yyyy HH:mm:sss tt");
            string input = "KP : KPMVCWebAPIs PersonsController : Today's Date : " + currentDate;
            Console.WriteLine("KP : KPMVCWebAPIs ! : Today's Date : " + currentDate);


            KPMVCWebAPIs.Database.AdventureWorks2022DAL dbDAL = new AdventureWorks2022DAL();
            List<Person> lstPerson = new List<Person>();
            
            lstPerson = dbDAL.SelectAllPersons();

            string jsonString =  System.Text.Json.JsonSerializer.Serialize(lstPerson);
            //return lstPerson;
            //return Ok(new { Message = input, RouteData = ControllerContext.RouteData.Values });
            //return Ok(new { Message = lstPerson.ToString(), RouteData = ControllerContext.RouteData.Values });
            //return Ok(new { Message = jsonString, RouteData = ControllerContext.RouteData.Values });
            return Ok(new { Message = lstPerson, RouteData = ControllerContext.RouteData.Values });
        }

        [HttpGet("{id}")]     // GET /api/persons/xyz
        public IActionResult GetPerson(string id)
        {
            string currentDate = DateTime.Now.ToString("MM/dd/yyyy HH:mm:sss tt");
            string input = "KP : KPMVCWebAPIs PersonsController : Today's Date : " + currentDate;
            Console.WriteLine("KP : KPMVCWebAPIs ! : Today's Date : " + currentDate);


            KPMVCWebAPIs.Database.AdventureWorks2022DAL dbDAL = new AdventureWorks2022DAL();
            Person person = new Person();

            person = dbDAL.GetPerson(id);
            return Ok(new { Message = person, RouteData = ControllerContext.RouteData.Values });
        }


        //[HttpGet("{id}")]   // GET /api/persons/xyz
        //public IActionResult GetProduct(string id)
        //{
        //    string currentDate = DateTime.Now.ToString("MM/dd/yyyy HH:mm:sss tt");
        //    string input = "KP : Today's Date : " + currentDate;
        //    Console.WriteLine("KP : KPMVCWebAPIs ! : Today's Date : " + currentDate);

        //    return Ok(new { Message = input, RouteData = ControllerContext.RouteData.Values, Id = id });
        //}

        [HttpGet("int/{id:int}")] // GET /api/persons/int/3
        public IActionResult GetIntProduct(int id)
        {
            string currentDate = DateTime.Now.ToString("MM/dd/yyyy HH:mm:sss tt");
            string input = "KP : Today's Date : " + currentDate;
            Console.WriteLine("KP : KPMVCWebAPIs ! : Today's Date : " + currentDate);

            return Ok(new { Message = input, RouteData = ControllerContext.RouteData.Values, Id = id });
        }

        [HttpGet("int2/{id}")]  // GET /api/persons/int2/3
        public IActionResult GetInt2Product(int id)
        {
            string currentDate = DateTime.Now.ToString("MM/dd/yyyy HH:mm:sss tt");
            string input = "KP : Today's Date : " + currentDate;
            Console.WriteLine("KP : KPMVCWebAPIs ! : Today's Date : " + currentDate);

            return Ok(new { Message = input, RouteData = ControllerContext.RouteData.Values, Id = id });
        }
    }
}








//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Net;
//using System.Net.Http;
//using System.Web.Http;
//using System.Data.Sql;
//using System.Data.Entity;
//using KPMVCWebAPIs.Database;
//using System.Data.SqlClient;
//using KPMVCWebAPIs.Models;
//using System.Threading.Tasks;


//namespace KPMVCWebAPIs.Controllers
//{
//    public class PersonsController :  ApiController
//    {

//        // GET api/Person/5 : Synchronous GET
//        public Person Get(int id)
//        {
//            AdventureWorksDAL dbDAL = new AdventureWorksDAL();
//            Person person = new Person();
//            person = dbDAL.SelectPerson(id);
//            return person;
//        }

//        // GET api/Person/ : Synchronous GET
//        public List<Person> Get()
//        {
//            AdventureWorksDAL dbDAL = new AdventureWorksDAL();
//            List<Person> lstPerson = new List<Person>();
//            lstPerson = dbDAL.SelectAllPersons();
//            return lstPerson;
//        }

//        ///// <summary>
//        ///// ASyncProgramming GET moved to ASyncPerson Controller
//        ///// </summary>
//        ///// <param name="id"></param>
//        ///// <returns></returns>
//        //// GET api/Person/5 : ASynchronous GET
//        //public async Task<Person> Get(int id)
//        //{
//        //    AdventureWorksDAL dbDAL = new AdventureWorksDAL();
//        //    Person person = new Person();
//        //    person = await dbDAL.SelectPersonAsync(id);
//        //    return person;
//        //}

//        //// GET api/Persons/ : ASynchronous GET
//        //public async Task<List<Person>> Get()
//        //{
//        //    AdventureWorksDAL dbDAL = new AdventureWorksDAL();
//        //    List<Person> lstPerson = new List<Person>();
//        //    lstPerson = await dbDAL.SelectAllPersonsAsync();
//        //    return lstPerson;
//        //}


//        // POST api/Persons/5
//        public bool Post(Person person)
//        {
//            AdventureWorksDAL dbDAL = new AdventureWorksDAL();
//            bool flag = dbDAL.PostPerson(person);
//            return flag;
//        }

//    }
//}