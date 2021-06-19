using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;


namespace KPMVCWebAPIs.Controllers
{
    public class AdventureWorksController : ApiController
    {
        // GET: AdventureWorks
        public string Get()
        {
            return "KP : Adventure Works ApiController";
        }
    }
}