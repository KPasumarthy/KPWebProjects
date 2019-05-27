using System;
using System.Linq;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Core.Objects;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Transactions;
using System.Data.Sql;
using System.Data.SqlTypes;
using System.Data;
using System.Reflection;
using System.Xml;
using KPMVCWebAPIs.Models;


namespace KPMVCWebAPIs.Database
{
    //public class AdventureWorksDBInitialize     {
    public class AdventureWorksDAL  //Adventure Works Data Access Layer 
    {
        //
        public Person SelectPerson(int id)
        {
            SqlDataAdapter sda = null;
            DataTable dt = new DataTable();
            Person person = new Person();
            SqlConnection conn = new SqlConnection();
            //conn.ConnectionString = @"Data Source=P5-SFKNP-LT\MSSQLSERVER01; Initial Catalog=AdventureWorks2014; Integrated Security=True; MultipleActiveResultSets=True";
            //conn.ConnectionString = @"Server=P5-SFKNP-LT\MSSQLSERVER01; Database=AdventureWorks2014; Trusted_Connection=True";
            //conn.ConnectionString = "AdventureWorksConnectionString";
            //using (var conn = new SqlConnection("AdventureWorksConnectionString"))
            conn.ConnectionString = @"Data Source=localhost;Initial Catalog=AdventureWorks2017;Integrated Security=True; MultipleActiveResultSets=True";
            using (conn)
            {
                conn.Open();

                string queryString = "Select * From Person.Person Where BusinessEntityID = " + id;
                sda = new SqlDataAdapter(queryString, conn);
                sda.Fill(dt);
 
                foreach (DataRow row in dt.Rows)
                {             
                    XmlDocument xmlDoc = new System.Xml.XmlDocument();
                    xmlDoc.LoadXml(row[10].ToString());

                    person.BusinessEntityID = (int)row[0];
                    person.PersonType = (row[1] == DBNull.Value) ? string.Empty : (string)row[1];
                    person.NameStyle = (row[2] == DBNull.Value) ? false : (bool)row[2];
                    person.Title = (row[3] == DBNull.Value) ? string.Empty : row[3].ToString();
                    person.FirstName = (row[4] == DBNull.Value) ? string.Empty : (string)row[4];
                    person.MiddleName = (row[5] == DBNull.Value) ? string.Empty : (string)row[5];
                    person.LastName = (row[6] == DBNull.Value) ? string.Empty : (string)row[6];
                    person.Suffix = (row[7] == DBNull.Value) ? string.Empty : row[7].ToString(); ;
                    person.EmailPromotion = (int)row[8];
                    person.AdditionalContactInfo = (row[9] == DBNull.Value) ? string.Empty : row[9].ToString();
                    person.Demographics = xmlDoc.DocumentElement;
                    person.Rowguid = (row[11] == DBNull.Value) ? string.Empty : row[11].ToString();
                }

                conn.Close();
            }
            return person;
        }
        
        public List<Person> SelectAllPersons()
        {
            SqlDataAdapter sda = null;
            DataTable dt = new DataTable();
            List<Person> lstPerson = new List<Person>();
            SqlConnection conn = new SqlConnection();
            //conn.ConnectionString = @"Data Source=P5-SFKNP-LT\MSSQLSERVER01; Initial Catalog=AdventureWorks2014; Integrated Security=True; MultipleActiveResultSets=True";
            //conn.ConnectionString = @"Server=P5-SFKNP-LT\MSSQLSERVER01; Database=AdventureWorks2014; Trusted_Connection=True";
            conn.ConnectionString = @"Data Source=localhost;Initial Catalog=AdventureWorks2017;Integrated Security=True; MultipleActiveResultSets=True";
            //using (var conn = new SqlConnection("AdventureWorksConnectionString"))
            using (conn)
            {
                conn.Open();

                string queryString = "Select * From Person.Person";
                sda = new SqlDataAdapter(queryString, conn);
                sda.Fill(dt);
   
                lstPerson = new List<Person>(dt.Rows.Count);
                foreach (DataRow row in dt.Rows)
                {
                    Person person = new Person();
                    XmlDocument xmlDoc = new System.Xml.XmlDocument();
                    xmlDoc.LoadXml(row[10].ToString());

                    person.BusinessEntityID = (int)row[0];
                    person.PersonType = (row[1] == DBNull.Value) ? string.Empty : (string)row[1];
                    person.NameStyle = (row[2] == DBNull.Value) ? false : (bool)row[2];
                    person.Title = (row[3] == DBNull.Value) ? string.Empty : row[3].ToString();
                    person.FirstName = (row[4] == DBNull.Value) ? string.Empty : (string)row[4];
                    person.MiddleName = (row[5] == DBNull.Value) ? string.Empty : (string)row[5];
                    person.LastName = (row[6] == DBNull.Value) ? string.Empty : (string)row[6];
                    person.Suffix = (row[7] == DBNull.Value) ? string.Empty : row[7].ToString(); ;
                    person.EmailPromotion = (int)row[8];
                    person.AdditionalContactInfo = (row[9] == DBNull.Value) ? string.Empty : row[9].ToString();
                    person.Demographics = xmlDoc.DocumentElement;
                    person.Rowguid = (row[11] == DBNull.Value) ? string.Empty : row[11].ToString();

                    lstPerson.Add(person);
                }

                conn.Close();
            }
            return lstPerson;
        }

        public bool PostPerson(Person person)
        {

            bool isPostPerson = false;
            SqlDataAdapter sda = null;
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=P5-SFKNP-LT\MSSQLSERVER01; Initial Catalog=AdventureWorks2014; Integrated Security=True; MultipleActiveResultSets=True";

            //conn.ConnectionString = @"Server=P5-SFKNP-LT\MSSQLSERVER01; Database=AdventureWorks2014; Trusted_Connection=True";
            //using (var conn = new SqlConnection("AdventureWorksConnectionString"))
            using (conn)
            {
                conn.Open();

                //To Insert a New Person : First we need to obtain a BusinessEntityID from Table : Person.BusinessEntity
                SqlCommand sqlQuery = new SqlCommand(@"Select IDENT_CURRENT('Person.BusinessEntity')", conn);
                //SqlCommand sqlQuery = new SqlCommand(@"Insert Into Person.BusinessEntity (rowguid, ModifiedDate) Values (NEWID(), GETDATE())", conn);
                int businessEntityID = Convert.ToInt32(sqlQuery.ExecuteScalar());

                string queryString = "Select * From Person.BusinessEntity Where BusinessEntityID = " + businessEntityID;
                sda = new SqlDataAdapter(queryString, conn);
                sda.Fill(dt);
                DataRow row = (DataRow)dt.Rows[0];
                person.BusinessEntityID = (int)row[0];
                person.Rowguid = Convert.ToString(row[1]);
                person.ModifiedDate = Convert.ToDateTime(row[2]);

                //XmlDocument xmlDoc = new System.Xml.XmlDocument();
                //xmlDoc.LoadXml(row[10].ToString());
                person.PersonType = (person.PersonType == "") ? DBNull.Value.ToString() : person.PersonType;
                person.NameStyle = Convert.ToBoolean(person.NameStyle);
                person.Title = (person.Title == "") ? DBNull.Value.ToString() : person.Title;
                person.FirstName = (person.FirstName == "") ? DBNull.Value.ToString() : person.FirstName;
                person.MiddleName = (person.MiddleName == "") ? DBNull.Value.ToString() : person.MiddleName;
                person.LastName = (person.LastName == "") ? DBNull.Value.ToString() : person.LastName;
                person.Suffix = (person.Suffix == "") ? DBNull.Value.ToString() : person.Suffix;
                person.EmailPromotion = Convert.ToInt16(person.EmailPromotion);
                //person.AdditionalContactInfo = (row[9] == DBNull.Value) ? string.Empty : row[9].ToString();
                //person.Demographics = xmlDoc.DocumentElement;

                //To Insert a New Person : Get BusinessEntityID from Table Person.BusinessEntity and then insert into : Person.Person
                queryString = @"Insert Into Person.Person (	BusinessEntityID, PersonType, NameStyle, Title, FirstName, MiddleName, LastName, Suffix, 
							EmailPromotion, AdditionalContactInfo, Demographics, rowguid, ModifiedDate ) Values (" +
                            person.BusinessEntityID + ",'" + person.PersonType + "','" + person.NameStyle + "','" +
                            person.Title + "','" + person.FirstName + "','" + person.MiddleName + "','" + person.LastName + "','" +
                            person.Suffix + "','" + person.EmailPromotion + "','" + person.AdditionalContactInfo + "','" + person.Demographics + "','" +
                            person.Rowguid + "','" + person.ModifiedDate + "')";


                sda = new SqlDataAdapter(queryString, conn);
                sda.Fill(dt);
                row = (DataRow)dt.Rows[0];

                conn.Close();

                isPostPerson = true;

            }
            return isPostPerson;
        }

        //TODO : Still Yet to be developed
        public bool DeletePerson(Person person)
        {
            SqlDataAdapter sda = null;
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=P5-SFKNP-LT\MSSQLSERVER01; Initial Catalog=AdventureWorks2014; 
                                      Integrated Security=True; MultipleActiveResultSets=True";

            //conn.ConnectionString = @"Server=P5-SFKNP-LT\MSSQLSERVER01; Database=AdventureWorks2014; Trusted_Connection=True";
            //using (var conn = new SqlConnection("AdventureWorksConnectionString"))
            using (conn)
            {
                conn.Open();

                //string queryString = "Select * From Person.Person Where BusinessEntityID = " + id;
                //sda = new SqlDataAdapter(queryString, conn);
                //sda.Fill(dt);

                //foreach (DataRow row in dt.Rows)
                //{
                //    XmlDocument xmlDoc = new System.Xml.XmlDocument();
                //    xmlDoc.LoadXml(row[10].ToString());

                //    person.BusinessEntityID = (int)row[0];
                //    person.PersonType = (row[1] == DBNull.Value) ? string.Empty : (string)row[1];
                //    person.NameStyle = (row[2] == DBNull.Value) ? false : (bool)row[2];
                //    person.Title = (row[3] == DBNull.Value) ? string.Empty : row[3].ToString();
                //    person.FirstName = (row[4] == DBNull.Value) ? string.Empty : (string)row[4];
                //    person.MiddleName = (row[5] == DBNull.Value) ? string.Empty : (string)row[5];
                //    person.LastName = (row[6] == DBNull.Value) ? string.Empty : (string)row[6];
                //    person.Suffix = (row[7] == DBNull.Value) ? string.Empty : row[7].ToString(); ;
                //    person.EmailPromotion = (int)row[8];
                //    person.AdditionalContactInfo = (row[9] == DBNull.Value) ? string.Empty : row[9].ToString();
                //    person.Demographics = xmlDoc.DocumentElement;
                //    person.Rowguid = (row[11] == DBNull.Value) ? string.Empty : row[11].ToString();
                //}

                conn.Close();
            }
            return false;
        }
        
        public List<Person> AdventureWorksDBConnection()
        {

            //using (var context = new AdventureWorksDBContext())
            //{

            //    context.Database.Connection.Open();
            //    string sqlCommand = "Select * From Person.Person Where BusinessEntityID = 27";

            //    context.Database.ExecuteSqlCommand(sqlCommand);

            //    context.SaveChanges();
            //} 
            string result = "";
            SqlDataReader reader = null;
            SqlDataAdapter sda = null;
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            List<Person> lstPerson = new List<Person>();

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=P5-SFKNP-LT\MSSQLSERVER01; Initial Catalog=AdventureWorks2014; Integrated Security=True; MultipleActiveResultSets=True";
            //conn.ConnectionString = @"Server = P5 - SFKNP - LT\MSSQLSERVER01; Database = AdventureWorks2014; Trusted_Connection = True";
            //using (var conn = new SqlConnection("AdventureWorksConnectionString"))
            using (conn)
            {
                conn.Open();

                var sqlCommand = new SqlCommand();
                sqlCommand.Connection = conn;
                sqlCommand.CommandText = "Select * From Person.Person Where BusinessEntityID = 27";

                string queryString = "Select * From Person.Person Where BusinessEntityID = 27";
                sda = new SqlDataAdapter(queryString, conn);
                sda.Fill(dt);
                sda.Fill(ds);

                
                lstPerson = new List<Person>(dt.Rows.Count);
                foreach (DataRow row in dt.Rows)
                {

                    Person person = new Person();
                    XmlDocument xmlDoc = new System.Xml.XmlDocument();
                    //xmlDoc.Load(row[10].ToString());
                    xmlDoc.LoadXml(row[10].ToString());

                    person.BusinessEntityID = (int)row[0];
                    person.PersonType = (row[1] == null) ? string.Empty : (string)row[1];
                    person.NameStyle = (row[2] == null) ? false : (bool)row[2];
                    //person.Title   = (row[3] == null) ? string.Empty : (string)row[3];
                    person.Title = (row[3] == DBNull.Value) ? string.Empty : row[2].ToString();
                    person.FirstName = (row[4] == null) ? string.Empty : (string)row[4];
                    person.MiddleName = (row[5] == null) ? string.Empty : (string)row[5];
                    person.LastName = (row[6] == null) ? string.Empty : (string)row[6];
                    person.Suffix = (row[7] == DBNull.Value) ? string.Empty : row[7].ToString(); ;
                    person.EmailPromotion = (int)row[8];
                    person.AdditionalContactInfo = (row[9] == DBNull.Value) ? string.Empty : row[9].ToString();
                    person.Demographics = xmlDoc.DocumentElement;

                    //person.Rowguid = (SqlGuid)row[11];
                    person.Rowguid = (row[11] == DBNull.Value) ? string.Empty : row[11].ToString(); 
                    //person.ModifiedDate = (SqlDateTime)row[12];

                    lstPerson.Add(person);
                }

                conn.Close();
            }
            return lstPerson;
        }
    }   
}