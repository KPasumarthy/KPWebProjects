using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using KPMVCWebAPIs.Models;
using System.Threading.Tasks;
using KPMVCWebAPIs.KPWCFServiceReference;

namespace KPMVCWebAPIs.Controllers
{
    public class KPWCFServiceClientController : ApiController
    {

        private static string FetchKPWCFServiceClient(int id)
        {
            //KP : Create a WCF Service Client 
            KPWCFServiceClient kpWCFServiceClient = new KPWCFServiceClient();
     

            //Makes a first async service call
            //var task1 = await kpWCFServiceClient.GetDataAsync(27);
            string data = kpWCFServiceClient.GetData(id);

            //Now awaits for task1
            Console.WriteLine("KP : FetchKPWCFServiceClient : " + data);

            return data;

        }


        //// GET api/values : Synchronous GET
        public IEnumerable<string> Get()
        {
            return new string[] { "KP : Value1", "KP : Value2" };
        }

        //// GET api/values/5 : Synchronous GET
        //public string Get(int id)
        //{
        //    return "KP : Value " + id;
        //}

        // GET api/KPWCFServiceClient/5 : Synchronous GET
        // GET api/KPWCFServiceClient/5 : Synchronous GET http://localhost/KPMVCWebAPIs/api/KPWCFServiceClient/9310527
        public string Get(int id)
        {
            //KP : Just for Testing WCF Test Client
            string str =  FetchKPWCFServiceClient(id);

            //return "KP : Value " + id;
            return "KP : Value " + id + " KPWCFServiceClient : " + str;
        }



        ///// <summary>
        ///// ASyncProgramming GET moved to ASyncValuesController
        ///// </summary>
        ///// <param name="id"></param>
        ///// <returns></returns>

        //////TODO : Example ASync : GET Async Method
        ////private static async Task<DateTime> CountToAsync(int num = 10)
        ////{
        ////    await Task.Run(() => { 
        ////          KP : Code goes here
        ////          num++;
        ////      });
        ////    return DateTime.Now;
        ////}

        ////  GET api/Values : ASynchronous GET 
        ////public async Task<IEnumerable<string>> GetVsAsync()
        //public async Task<IEnumerable<string>> Get()
        //{
        //    string[] strArrAsyncVal = null;
        //    await Task.Run(() =>
        //    {
        //        strArrAsyncVal = new string[] { "KP : Async Value1", "KP : Async Value2" };
        //    });
        //    return strArrAsyncVal;
        //}

        //// GET api/values/5 : ASynchronous GET
        //public async Task<string> Get(int id)
        //{
        //    string strAsyncVal = null;
        //    await Task.Run(() =>
        //    {
        //        strAsyncVal = "KP : Async Value " + id;
        //    });
        //    return strAsyncVal;
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
