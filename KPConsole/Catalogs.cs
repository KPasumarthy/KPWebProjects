using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using Newtonsoft.Json;

namespace KPConsole
{
    class Catalogs
    {
        /// <summary>
        /// KP : Class Constructor : Catalogs !
        /// </summary>
        public Catalogs()
        {
            Console.WriteLine("KP : Catalogs !");
        }


        // KP : KPPrintCatalogs : Gets catalog data from the store.
        public static void KPPrintCatalogs(Int64 n)
        {

            Console.WriteLine("KP : Catalogs : PrintCatalogs !");

            Int64 x = 1;
            while (x <= n)
            {
                Int64 r3 = (Int64)x % 3;
                Int64 r5 = (Int64)x % 5;
                Console.Write(x + " ");
                if (r3 == 0)
                    Console.Write("KP : Catalogs : PrintCatalogs : Fizz");

                if (r5 == 0)
                    Console.Write("KP : Catalogs : PrintCatalogs : Buzz");

                Console.WriteLine();
                x++;
            }
        }



        // KP : KPBuildNOrganizeCatalogs : Build & Organize Catalogs
        public static void KPBuildNOrganizeCatalogs()
        {

            Console.WriteLine("KP : Catalogs : KPBuildNOrganizeCatalogs !");

        }






        // Gets catalog data from the store.

        private static object GetResource(string uri, WebHeaderCollection headers, Type resourceType)
        {
            object resource = null;
            var request = (HttpWebRequest)WebRequest.Create(uri);
            request.Method = "GET";
            request.Headers = headers;
            request.Accept = "application/json";
            var response = (HttpWebResponse)request.GetResponse();

            using (Stream responseStream = response.GetResponseStream())
            {
                var reader = new StreamReader(responseStream);
                string json = reader.ReadToEnd();
                reader.Close();
                resource = JsonConvert.DeserializeObject(json, resourceType);
            }

            return resource;
        }

        // Adds a catalog to the store.

        private static Catalog AddResource(string uri, WebHeaderCollection headers, Catalog catalog)
        {
            var request = (HttpWebRequest)WebRequest.Create(uri);
            request.Method = "POST";
            request.Headers = headers;
            request.ContentType = "application/json";

            var json = JsonConvert.SerializeObject(catalog);
            request.ContentLength = json.Length;
            using (Stream requestStream = request.GetRequestStream())
            {
                StreamWriter writer = new StreamWriter(requestStream);
                writer.Write(json);
                writer.Close();
            }

            var response = (HttpWebResponse)request.GetResponse();

            Catalog catalogOut = null;

            using (Stream responseStream = response.GetResponseStream())
            {
                var reader = new StreamReader(responseStream);
                var jsonOut = reader.ReadToEnd();
                reader.Close();
                catalogOut = JsonConvert.DeserializeObject<Catalog>(jsonOut);
            }

            return catalogOut;
        }

        // Updates a catalog's attributes.

        private static ulong UpdateResource(string uri, WebHeaderCollection headers, Catalog catalog)
        {
            var request = (HttpWebRequest)WebRequest.Create(uri);
            request.Method = "PUT";
            request.Headers = headers;
            request.ContentType = "application/json";

            var json = JsonConvert.SerializeObject(catalog);
            request.ContentLength = json.Length;
            using (Stream requestStream = request.GetRequestStream())
            {
                StreamWriter writer = new StreamWriter(requestStream);
                writer.Write(json);
                writer.Close();
            }

            var response = (HttpWebResponse)request.GetResponse();

            Catalog catalogOut = null;

            using (Stream responseStream = response.GetResponseStream())
            {
                var reader = new StreamReader(responseStream);
                var jsonOut = reader.ReadToEnd();
                reader.Close();
                catalogOut = JsonConvert.DeserializeObject<Catalog>(jsonOut);
            }

            return catalogOut.Id;
        }

        // Deletes a catalog from the store.

        private static ContentError DeleteResource(string uri, WebHeaderCollection headers)
        {
            var request = (HttpWebRequest)WebRequest.Create(uri);
            request.Method = "DELETE";
            request.ContentType = "application/json";
            request.Headers = headers;

            var response = (HttpWebResponse)request.GetResponse();

            ContentError error = null;

            using (Stream responseStream = response.GetResponseStream())
            {
                var reader = new StreamReader(responseStream);
                var jsonOut = reader.ReadToEnd();
                reader.Close();
                error = JsonConvert.DeserializeObject<ContentError>(jsonOut);
            }

            return error;
        }

        private static List<Catalog> AddCatalogs(string url, WebHeaderCollection headers)
        {
            var catalogs = new List<Catalog>();

            Console.WriteLine("*** Adding Catalogs ***\n");

            // This catalog is not enabled for publishing.

            var catalog = new Catalog()
            {
                Name = "Mens Apparel",
                Market = "en-US",
                IsPublishingEnabled = false
            };

            catalogs.Add(AddResource(url, headers, catalog));

            // This catalog is enabled for publishing.

            catalog = new Catalog()
            {
                Name = "Womens Apparel",
                Market = "en-US",
                IsPublishingEnabled = true
            };

            catalogs.Add(AddResource(url, headers, catalog));

            return catalogs;
        }

        private static void DeleteCatalogs(string uri, WebHeaderCollection headers, ulong merchantId, List<Catalog> catalogs)
        {
            Console.WriteLine("*** Deleting Catalogs ***\n");

            foreach (var catalog in catalogs)
            {
                // Build the endpoint URL.

                var url = string.Format(uri, merchantId, catalog.Id);

                // Delete the catalog from the store.

                var errors = DeleteResource(url, headers);

                if (errors != null)
                {
                    Console.WriteLine("Error deleting catalog: " + catalog.Id);
                    PrintErrors(errors);
                }
                else
                {
                    Console.WriteLine("Deleted catalog: " + catalog.Id);
                }
            }

            Console.WriteLine();
        }

        private static void PrintCatalogs(CatalogCollection collection)
        {
            Console.WriteLine("There are " + collection.Catalogs.Count + " catalogs.\n");

            foreach (Catalog catalog in collection.Catalogs)
            {
                PrintCatalogDetails(catalog);
            }
        }

        // Print catalog details.

        private static void PrintCatalogDetails(Catalog catalog)
        {
            Console.WriteLine("Name: " + catalog.Name);
            Console.WriteLine("ID: " + catalog.Id);
            Console.WriteLine("Market: " + catalog.Market);
            Console.WriteLine("IsDefault: " + catalog.IsDefault);
            Console.WriteLine("IsPublishingEnabled: " + catalog.IsPublishingEnabled);
            Console.WriteLine();
        }

        // Print errors.

        private static void PrintErrors(ContentError contentError)
        {
            Console.WriteLine("HTTP status code: " + contentError.Error.Code);

            foreach (Error error in contentError.Error.Errors)
            {
                Console.WriteLine("reason: {0}\nmessage: {1}\nlocation type: {2}\nlocation: {3}\n",
                    error.Reason, error.Message, error.LocationType, error.Location);
            }
        }


        public class Catalog
        {
            [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Ignore)]
            public ulong Id { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("market", DefaultValueHandling = DefaultValueHandling.Ignore)]
            public string Market { get; set; }

            [JsonProperty("isPublishingEnabled")]
            public Boolean IsPublishingEnabled { get; set; }

            [JsonProperty("isDefault", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
            public Boolean IsDefault { get; set; }
        }

        public class CatalogCollection
        {
            [JsonProperty("catalogs")]
            public List<Catalog> Catalogs { get; set; }
        }

        // Classes used to handle errors.
        public class Error
        {
            [JsonProperty("location")]
            public string Location { get; set; }

            [JsonProperty("locationType")]
            public string LocationType { get; set; }

            [JsonProperty("domain")]
            public string Domain { get; set; }

            [JsonProperty("message")]
            public string Message { get; set; }

            [JsonProperty("reason")]
            public string Reason { get; set; }
        }

        public class ErrorCollection
        {
            [JsonProperty("code")]
            public string Code { get; set; }

            [JsonProperty("errors")]
            public List<Error> Errors { get; set; }

            [JsonProperty("message")]
            public string Message { get; set; }

        }

        public class ContentError
        {
            [JsonProperty("error")]
            public ErrorCollection Error { get; set; }
        }

    }
}
