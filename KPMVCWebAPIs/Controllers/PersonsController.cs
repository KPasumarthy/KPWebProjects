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
    public class PersonsController :  ApiController
    {

        // GET api/Person/5 : Synchronous GET
        public Person Get(int id)
        {
            AdventureWorksDAL dbDAL = new AdventureWorksDAL();
            Person person = new Person();
            person = dbDAL.SelectPerson(id);
            return person;
        }

        // GET api/Person/ : Synchronous GET
        public List<Person> Get()
        {
            AdventureWorksDAL dbDAL = new AdventureWorksDAL();
            List<Person> lstPerson = new List<Person>();
            lstPerson = dbDAL.SelectAllPersons();
            return lstPerson;
        }

        ///// <summary>
        ///// ASyncProgramming GET moved to ASyncPerson Controller
        ///// </summary>
        ///// <param name="id"></param>
        ///// <returns></returns>
        //// GET api/Person/5 : ASynchronous GET
        //public async Task<Person> Get(int id)
        //{
        //    AdventureWorksDAL dbDAL = new AdventureWorksDAL();
        //    Person person = new Person();
        //    person = await dbDAL.SelectPersonAsync(id);
        //    return person;
        //}

        //// GET api/Person/ : ASynchronous GET
        //public async Task<List<Person>> Get()
        //{
        //    AdventureWorksDAL dbDAL = new AdventureWorksDAL();
        //    List<Person> lstPerson = new List<Person>();
        //    lstPerson = await dbDAL.SelectAllPersonsAsync();
        //    return lstPerson;
        //}


        // POST api/Person/5
        public bool Post(Person person)
        {
            AdventureWorksDAL dbDAL = new AdventureWorksDAL();
            bool flag = dbDAL.PostPerson(person);
            return flag;
        }

    }
}