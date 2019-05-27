using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using KPMVCWebAPIs.Models;


namespace KPMVCWebAPIs.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "KP : Value1", "KP : Value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "KP : Value " + id;
        }

        //// GET api/values/5
        //public IEnumerable<Person> Get(int id)
        //{
        //    return new Person[] {  };
        //}

        // POST api/values
        public void Post([FromBody]string value)
        {

        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
