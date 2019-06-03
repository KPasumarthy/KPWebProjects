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
    public class PersonController :  ApiController
    {

        // GET api/Person/5
        //public Person Get(int id)
        //private static async Task<Person> Get(int id)
        private async Task<Person> Get(int id)
        {
            AdventureWorksDAL dbDAL = new AdventureWorksDAL();
            Person person = new Person();
            //person = dbDAL.SelectPerson(id);
            //KP : Use SelectPersonAsync Method to get Person
            person = await dbDAL.SelectPersonAsync(id);
            return person;
        }

        // GET api/Person/
        //public List<Person> Get()
        public async Task<List<Person>> Get()
        {
            AdventureWorksDAL dbDAL = new AdventureWorksDAL();
            List<Person> lstPerson = new List<Person>();
            //lstPerson = dbDAL.SelectAllPersons();
            lstPerson = await dbDAL.SelectAllPersonsAsync();
            return lstPerson;
        }

        // POST api/Person/5
        public bool Post(Person person)
        {
            AdventureWorksDAL dbDAL = new AdventureWorksDAL();
            bool flag = dbDAL.PostPerson(person);
            return flag;
        }

    }
}