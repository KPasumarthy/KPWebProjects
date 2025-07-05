using System.Configuration;
using System.Diagnostics.Metrics;
using Elfie.Serialization;
using KPMVCWebAPIs.Models;
using Microsoft.Data.SqlClient;
using NuGet.Configuration;
using static System.Runtime.InteropServices.JavaScript.JSType;
//using ConfigurationManager = System.Configuration.ConfigurationManager;


namespace KPMVCWebAPIs.Database
{
    ////KP : AdventureWorks2022DAL : AdventureWorks2022 Data Access Layer (DAL) Class - SQL Server
    public class AdventureWorks2022DAL
    {

        static private string connectionString = GetConnectionString();
        //static private SqlConnection connection = new SqlConnection(connectionString);


        public AdventureWorks2022DAL()
        {
            string connectionString = GetConnectionString();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                Console.WriteLine("KP : KPMVCWebAPIs.Database : AdventureWorks2022DAL :  ServerVersion: {0}", connection.ServerVersion);
                Console.WriteLine("KP : KPMVCWebAPIs.Database : AdventureWorks2022DAL : State: {0}", connection.State);

                // Do work here; connection closed on following line.
            }

        }

        // Destructor cannot have access modifiers like 'public'.
        ~AdventureWorks2022DAL()
        {

        }

        static private string GetConnectionString()
        {

            foreach (ConnectionStringSettings css in System.Configuration.ConfigurationManager.ConnectionStrings)
            {
                string name = css.Name;
                string connectionString = css.ConnectionString;
                string provider = css.ProviderName;

                // You can now use the 'name', 'connectionString', and 'provider'
                // for each connection string.
                Console.WriteLine($"Name: {name}, ConnectionString: {connectionString}, Provider: {provider}");
            }


            //// Retrieve the connection string from the configuration file  
            //ConnectionStringSettings? settings = System.Configuration.ConfigurationManager.ConnectionStrings["AdventureWorks2022ConnectionString"];

            //// If found, return the connection string; otherwise, throw an exception  
            //if (settings == null || string.IsNullOrEmpty(settings.ConnectionString))
            //{
            //    throw new InvalidOperationException("KP : The connection string 'AdventureWorks2022ConnectionString' is not configured or is empty.");
            //}

            //return settings.ConnectionString;
            //return "Server=SARASWATI;Database=master;Trusted_Connection=True;";
            //return "data source=SARADA;Initial Catalog=AdventureWorks2022;Integrated Security=True;";
            //return "Data Source=SARADA;Initial Catalog=AdventureWorks2022;UID = sa; PWD = KPSQLServer2022sysadmin!; TrustServerCertificate=True";
            //return "Data Source=SARADA;Initial Catalog=AdventureWorks2022;Integrated Security=True; TrustServerCertificate=True";
            return "Data Source=localhost;Initial Catalog=AdventureWorks2022;Integrated Security=True; TrustServerCertificate=True";


        }

        private static void CreateCommand(string queryString)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                    SqlCommand command = new SqlCommand(queryString, connection);
                    command.Connection.Open();
                    command.ExecuteNonQuery();
                }
        }

        public Person GetPerson(string id)
        {
            // Explicitly define the type of the variable instead of using 'var'
            //List<Person> result = new List<Person>();
            Person person = new Person();

            string query = "SELECT BusinessEntityID, FirstName, LastName FROM Person.Person WHERE BusinessEntityID = " + id; // Adjust columns as needed

            try
            {

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int businessEntityID = reader.GetInt32(reader.GetOrdinal("BusinessEntityID"));
                                string firstName = reader.GetString(reader.GetOrdinal("FirstName"));
                                string lastName = reader.GetString(reader.GetOrdinal("LastName"));

                                person.BusinessEntityID = businessEntityID;
                                person.FirstName = firstName;
                                person.LastName = lastName;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            return person; // Return the preson with the id 
        }


        public List<Person> SelectAllPersons()
        {
            // Explicitly define the type of the variable instead of using 'var'
            List<Person> result = new List<Person>();

            string query = "SELECT BusinessEntityID, FirstName, LastName FROM Person.Person"; // Adjust columns as needed

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int businessEntityID = reader.GetInt32(reader.GetOrdinal("BusinessEntityID"));
                                string firstName = reader.GetString(reader.GetOrdinal("FirstName"));
                                string lastName = reader.GetString(reader.GetOrdinal("LastName"));

                                // Add the retrieved data to the result list
                                result.Add(new Person
                                {
                                    BusinessEntityID = businessEntityID,
                                    FirstName = firstName,
                                    LastName = lastName
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            return result; // Return the populated list
        }

    }
}
