using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data.Sql;
using System.Data.Entity;
using KPMVCWebAPIs.Database;
using System.Data.SqlClient;
using KPMVCWebAPIs.Models;
using System.Threading.Tasks;

namespace KPMVCWebAPIs.Controllers
{
    public class ASyncPersonsController : ApiController
    {
        // GET api/ASyncPersons/27 : ASynchronous GET Person
        public async Task<Person> Get(int id)
        {
            AdventureWorksDAL dbDAL = new AdventureWorksDAL();
            Person person = new Person();
            person = await dbDAL.SelectPersonAsync(id);
            return person;
        }

        // GET api/ASyncPersons : ASynchronous Get Persons
        public async Task<List<Person>> Get()
        {
            AdventureWorksDAL dbDAL = new AdventureWorksDAL();
            List<Person> lstPerson = new List<Person>();
            lstPerson = await dbDAL.SelectAllPersonsAsync();
            return lstPerson;
        }

    }
}