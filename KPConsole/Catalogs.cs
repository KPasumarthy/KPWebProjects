using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
//using Newtonsoft.Json;
using System.Text.Json;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using JsonSerializer = System.Text.Json.JsonSerializer;
//using Newtonsoft.Json;

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


            try
            {
                //KP : Remove the Http Layer
                //var headers = GetCredentialHeaders();

                // Build the catalogs endpoint URL.

                //KP : Remove the Http Layer
                //var url = string.Format(CatalogsUri, merchantId);

                // Get and print the current list of catalogs.



                //KP : Remove the Http Layer
                //var collection = GetResource(url, headers, typeof(CatalogCollection)) as CatalogCollection;
                ///PrintCatalogs(collection);
                //var weatherForecast = new WeatherForecast
                //{
                //    Date = DateTime.Parse("2019-08-01"),
                //    TemperatureCelsius = 25,
                //    Summary = "Hot"
                //};
                //string jsonString = JsonSerializer.Serialize<WeatherForecast>(weatherForecast);
                //Console.WriteLine(jsonString);
                var catalog = new Catalog
                {
                    Id = 1,
                    Name = "KP : Sample Catalog",
                    Market = "KP : Sample Market",
                    IsPublishingEnabled = true,
                    IsDefault = true
                };
                string jsonString = System.Text.Json.JsonSerializer.Serialize<Catalog>(catalog);
                Console.WriteLine("KP : Print Catalog as JSON : ");
                Console.WriteLine(jsonString);

                jsonString = @"{
	                        ""books"": [{
			                        ""isbn"": ""9781593275846"",
			                        ""title"": ""Eloquent JavaScript, Second Edition"",
			                        ""subtitle"": ""A Modern Introduction to Programming"",
			                        ""author"": ""Marijn Haverbeke"",
			                        ""published"": ""2014-12-14T00:00:00.000Z"",
			                        ""publisher"": ""No Starch Press"",
			                        ""pages"": 472,
			                        ""description"": ""JavaScript lies at the heart of almost every modern web application, from social apps to the newest browser-based games. Though simple for beginners to pick up and play with, JavaScript is a flexible, complex language that you can use to build full-scale applications."",
			                        ""website"": ""http://eloquentjavascript.net/""
		                        },
		                        {
			                        ""isbn"": ""9781449331818"",
			                        ""title"": ""Learning JavaScript Design Patterns"",
			                        ""subtitle"": ""A JavaScript and jQuery Developer's Guide"",
			                        ""author"": ""Addy Osmani"",
			                        ""published"": ""2012-07-01T00:00:00.000Z"",
			                        ""publisher"": ""O'Reilly Media"",
			                        ""pages"": 254,
			                        ""description"": ""With Learning JavaScript Design Patterns, you'll learn how to write beautiful, structured, and maintainable JavaScript by applying classical and modern design patterns to the language. If you want to keep your code efficient, more manageable, and up-to-date with the latest best practices, this book is for you."",
			                        ""website"": ""http://www.addyosmani.com/resources/essentialjsdesignpatterns/book/""
		                        },
		                        {
			                        ""isbn"": ""9781449365035"",
			                        ""title"": ""Speaking JavaScript"",
			                        ""subtitle"": ""An In-Depth Guide for Programmers"",
			                        ""author"": ""Axel Rauschmayer"",
			                        ""published"": ""2014-02-01T00:00:00.000Z"",
			                        ""publisher"": ""O'Reilly Media"",
			                        ""pages"": 460,
			                        ""description"": ""Like it or not, JavaScript is everywhere these days-from browser to server to mobile-and now you, too, need to learn the language or dive deeper than you have. This concise book guides you into and through JavaScript, written by a veteran programmer who once found himself in the same position."",
			                        ""website"": ""http://speakingjs.com/""
		                        },
		                        {
			                        ""isbn"": ""9781491950296"",
			                        ""title"": ""Programming JavaScript Applications"",
			                        ""subtitle"": ""Robust Web Architecture with Node, HTML5, and Modern JS Libraries"",
			                        ""author"": ""Eric Elliott"",
			                        ""published"": ""2014-07-01T00:00:00.000Z"",
			                        ""publisher"": ""O'Reilly Media"",
			                        ""pages"": 254,
			                        ""description"": ""Take advantage of JavaScript's power to build robust web-scale or enterprise applications that are easy to extend and maintain. By applying the design patterns outlined in this practical book, experienced JavaScript developers will learn how to write flexible and resilient code that's easier-yes, easier-to work with as your code base grows."",
			                        ""website"": ""http://chimera.labs.oreilly.com/books/1234000000262/index.html""
		                        },
		                        {
			                        ""isbn"": ""9781593277574"",
			                        ""title"": ""Understanding ECMAScript 6"",
			                        ""subtitle"": ""The Definitive Guide for JavaScript Developers"",
			                        ""author"": ""Nicholas C. Zakas"",
			                        ""published"": ""2016-09-03T00:00:00.000Z"",
			                        ""publisher"": ""No Starch Press"",
			                        ""pages"": 352,
			                        ""description"": ""ECMAScript 6 represents the biggest update to the core of JavaScript in the history of the language. In Understanding ECMAScript 6, expert developer Nicholas C. Zakas provides a complete guide to the object types, syntax, and other exciting changes that ECMAScript 6 brings to JavaScript."",
			                        ""website"": ""https://leanpub.com/understandinges6/read""
		                        },
		                        {
			                        ""isbn"": ""9781491904244"",
			                        ""title"": ""You Don't Know JS"",
			                        ""subtitle"": ""ES6 & Beyond"",
			                        ""author"": ""Kyle Simpson"",
			                        ""published"": ""2015-12-27T00:00:00.000Z"",
			                        ""publisher"": ""O'Reilly Media"",
			                        ""pages"": 278,
			                        ""description"": ""This compact guide focuses on new features available in ECMAScript 6(ES6),the latest version of the standard upon which JavaScript is built."",
			                        ""website"": ""https://github.com/getify/You-Dont-Know-JS/tree/master/es6%20&%20beyond""
		                        },
		                        {
			                        ""isbn"": ""9781449325862"",
			                        ""title"": ""Git Pocket Guide"",
			                        ""subtitle"": ""A Working Introduction"",
			                        ""author"": ""Richard E. Silverman"",
			                        ""published"": ""2013-08-02T00:00:00.000Z"",
			                        ""publisher"": ""O'Reilly Media"",
			                        ""pages"": 234,
			                        ""description"": ""This pocket guide is the perfect on-the-job companion to Git, the distributed version control system. It provides a compact, readable introduction to Git for new users, as well as a reference to common commands and procedures for those of you with Git experience."",
			                        ""website"": ""http://chimera.labs.oreilly.com/books/1230000000561/index.html""
		                        },
		                        {
			                        ""isbn"": ""9781449337711"",
			                        ""title"": ""Designing Evolvable Web APIs with ASP.NET"",
			                        ""subtitle"": ""Harnessing the Power of the Web"",
			                        ""author"": ""Glenn Block, et al."",
			                        ""published"": ""2014-04-07T00:00:00.000Z"",
			                        ""publisher"": ""O'Reilly Media"",
			                        ""pages"": 538,
			                        ""description"": ""Design and build Web APIs for a broad range of clients—including browsers and mobile devices—that can adapt to change over time. This practical, hands-on guide takes you through the theory and tools you need to build evolvable HTTP services with Microsoft’s ASP.NET Web API framework. In the process, you’ll learn how design and implement a real-world Web API."",
			                        ""website"": ""http://chimera.labs.oreilly.com/books/1234000001708/index.html""
		                        }
	                        ]
                        }";
                Console.WriteLine("KP : Print Books Catalog as JSON : ");
                Console.WriteLine(jsonString);

                var json = JsonSerializer.Serialize(jsonString);
                Console.WriteLine("KP : Print Books Catalog as JSON Serialize : ");
                Console.WriteLine(json);


                // Fix for CS0411: Specify the type argument explicitly for JsonSerializer.Deserialize
                var jsonDeserialize = JsonSerializer.Deserialize<object>(jsonString);
                Console.WriteLine("KP : Print Books Catalog as JSON Deserialize : ");
                Console.WriteLine(jsonDeserialize);


                //var collection = new CatalogCollection();
                //collection.Catalogs.Add(catalog);
                //PrintCatalogs(collection);

                //// Add a couple of catalogs.

                //var catalogs = AddCatalogs(url, headers);

                //// Get and print the current list of catalogs.

                //collection = GetResource(url, headers, typeof(CatalogCollection)) as CatalogCollection;
                //PrintCatalogs(collection);

                //// Update the first catalog that we added
                //// to enable it for publishing. When you update the 
                //// catalog, you must specify both Name and IsPublishingEnabled.

                //Console.WriteLine("*** Updating Catalog ***\n");
                //var catalogUrl = string.Format(CatalogUri, merchantId, catalogs[0].Id);
                //var catalog = new Catalog()
                //{
                //    Name = catalogs[0].Name,
                //    IsPublishingEnabled = true
                //};
                //UpdateResource(catalogUrl, headers, catalog);

                //// Get and print the updated catalog.

                //var updatedCatalog = GetResource(catalogUrl, headers, typeof(Catalog)) as Catalog;
                //PrintCatalogDetails(updatedCatalog);

                //// Delete the catalogs that we created.

                //DeleteCatalogs(CatalogUri, headers, merchantId, catalogs);

                //// Get and print the current list of catalogs.

                //collection = GetResource(url, headers, typeof(CatalogCollection)) as CatalogCollection;
                //PrintCatalogs(collection);
            }
            catch (WebException e)
            {
                Console.WriteLine("\n" + e.Message);

                HttpWebResponse response = (HttpWebResponse)e.Response;

                // If the request is bad, the API returns the errors in the 
                // body of the request. For cases where the path may be valid, but
                // the resource does not belong to the user, the API returns not found.

                if (HttpStatusCode.BadRequest == response.StatusCode ||
                    HttpStatusCode.NotFound == response.StatusCode ||
                    HttpStatusCode.InternalServerError == response.StatusCode)
                {
                    using (Stream stream = response.GetResponseStream())
                    {
                        StreamReader reader = new StreamReader(stream);
                        string json = reader.ReadToEnd();
                        reader.Close();

                        // Deserialize error string into errors object.

                        try
                        {
                            //KP : var errors = JsonConvert.DeserializeObject<ContentError>(json);
                            //PrintErrors(errors);
                        }
                        catch (Exception deserializeError)
                        {
                            // This case occurs when the path is not valid.

                            if (HttpStatusCode.NotFound == response.StatusCode)
                            {
                                Console.WriteLine("Path not found: " + response.ResponseUri);
                            }
                            else
                            {
                                Console.WriteLine(deserializeError.Message);
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("\n" + e.Message);
            }


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
                //resource = JsonConvert.DeserializeObject(json, resourceType);
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
                //catalogOut = JsonConvert.DeserializeObject<Catalog>(jsonOut);
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
                //error = JsonConvert.DeserializeObject<ContentError>(jsonOut);
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


        //KP : public class Catalog as Json
        //{
        //  "id": null,
        //  "name": null,
        //  "market": null,
        //  "name": null,
        //  "isPublishingEnabled": false,
        //  "isDefault": null,
        //}
        public class Catalog
        {
            //[JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Ignore)]
            public ulong Id { get; set; }

            //[JsonProperty("name")]
            public string Name { get; set; }

            //[JsonProperty("market", DefaultValueHandling = DefaultValueHandling.Ignore)]
            public string Market { get; set; }

            //[JsonProperty("isPublishingEnabled")]
            public Boolean IsPublishingEnabled { get; set; }

            //[JsonProperty("isDefault", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
            public Boolean IsDefault { get; set; }
        }

        public class CatalogCollection
        {
            //[JsonProperty("catalogs")]
            public List<Catalog> Catalogs { get; set; }
        }

        // Classes used to handle errors.
        public class Error
        {
            //[JsonProperty("location")]
            public string Location { get; set; }

            //[JsonProperty("locationType")]
            public string LocationType { get; set; }

            //[JsonProperty("domain")]
            public string Domain { get; set; }

            //[JsonProperty("message")]
            public string Message { get; set; }

            //[JsonProperty("reason")]
            public string Reason { get; set; }
        }

        public class ErrorCollection
        {
            //[JsonProperty("code")]
            public string Code { get; set; }

            //[JsonProperty("errors")]
            public List<Error> Errors { get; set; }

            //[JsonProperty("message")]
            public string Message { get; set; }

        }

        public class ContentError
        {
            //[JsonProperty("error")]
            public ErrorCollection Error { get; set; }
        }

    }
}
