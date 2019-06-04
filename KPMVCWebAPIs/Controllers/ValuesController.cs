using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using KPMVCWebAPIs.Models;
using System.Threading.Tasks;

namespace KPMVCWebAPIs.Controllers
{
    public class ValuesController : ApiController
    {
        ////// GET api/values : Synchronous GET
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "KP : Value1", "KP : Value2" };
        //}

        //// GET api/values/5 : Synchronous GET
        //public string Get(int id)
        //{
        //    return "KP : Value " + id;
        //}

        //////TODO : Example ASync : GET Async Method
        ////private static async Task<DateTime> CountToAsync(int num = 10)
        ////{
        ////    await Task.Run(() => { 
        ////          KP : Code goes here
        ////          num++;
        ////      });
        ////    return DateTime.Now;
        ////}

        //  GET api/Values : ASynchronous GET 
        //public async Task<IEnumerable<string>> GetVsAsync()
        public async Task<IEnumerable<string>> Get()
        {
            string[] strArrAsyncVal = null;
            await Task.Run(() => {
                strArrAsyncVal = new string[] { "KP : Async Value1", "KP : Async Value2" };
            } );
            return strArrAsyncVal;
        }

        // GET api/values/5 : ASynchronous GET
        public async Task<string> Get(int id)
        {
            string strAsyncVal = null;
            await Task.Run(() => {
                strAsyncVal = "KP : Async Value " + id; 
            });
            return strAsyncVal;
        }

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
