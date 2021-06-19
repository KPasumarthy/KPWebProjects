using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net;
using System.IO;
using System.Text;
using System.Web;
using Newtonsoft.Json.Linq;
using KPWCFServiceUnitTest;

namespace KPWCFServiceUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
        }

        //String hostName = "http://localhost:59030/KPWCFService.svc";
        String hostName = "http://localhost/KPWCFService";
        //String hostName = "isd001ecv.sigitest.ustest.selective.com";

        private HttpWebRequest generateHttpWebRequest(String method)
        {
            //HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(string.Format("http://{0}/WebServices/ECM/PresentationServices/Underwriting/{1}", hostName, method));
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(string.Format("{0}/{1}", hostName, method));
            //httpWebRequest.ContentType = "text/json";
            httpWebRequest.ContentType = "text/xml; charset=utf-8";

            //WebProxy proxy = new WebProxy("http://10.137.64.46:8888");
            //proxy.BypassProxyOnLocal = false;
            //httpWebRequest.Proxy = proxy;

            return httpWebRequest;

        }


        [TestMethod]
        public void GetData()
        {
            //HttpWebRequest httpWebRequest = this.generateHttpWebRequest("ContentService.svc/importDocument");
            HttpWebRequest httpWebRequest = this.generateHttpWebRequest("KPWCFService.svc/KPWCFSOAPService/GetData");
            httpWebRequest.Method = "POST";

            Byte[] postData = null;
            String filePath = @"KPTextFile.txt";

            using (Stream streamWriter = httpWebRequest.GetRequestStream())
            {
                StringBuilder str = new StringBuilder();
                str.Append("KP : Test - KPWCFServices");

                postData = Encoding.UTF8.GetBytes(str.ToString());
                streamWriter.Write(postData, 0, postData.Length);

                streamWriter.Close();
            }

            HttpWebResponse httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (StreamReader streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                JToken t = JObject.Parse(streamReader.ReadToEnd());
                Boolean success = (Boolean)t["success"];
                //Console.WriteLine(t["statusMessage"]);
                if (success)
                    Assert.IsTrue(success);
                else
                    Assert.IsTrue(success, t["statusMessage"].ToString());
            }
        }



        //[TestMethod]
        public void ImportDocument()
        {
            //HttpWebRequest httpWebRequest = this.generateHttpWebRequest("ContentService.svc/importDocument");
            HttpWebRequest httpWebRequest = this.generateHttpWebRequest("KPWCFService.svc/KPWCFSOAPService/GetData");
            httpWebRequest.Method = "POST";

            Byte[] postData = null;
            String filePath = @"KPTextFile.txt";

            using (Stream streamWriter = httpWebRequest.GetRequestStream())
            {
                byte[] bytedata = File.ReadAllBytes(filePath);
                string strBase64 = Convert.ToBase64String(bytedata);

                StringBuilder str = new StringBuilder();
                str.Append("{");
                str.Append(Path.GetFileName(filePath));
                str.Append("\",");
                str.Append("\"documentBytes\":\"");
                str.Append(strBase64);
                str.Append("\",");
                str.Append("\"metadata\":{");
                str.Append("\"accountId\":\"1111111\",");
                str.Append("}");
                str.Append("}");

                postData = Encoding.UTF8.GetBytes(str.ToString());
                streamWriter.Write(postData, 0, postData.Length);

                streamWriter.Close();
            }

            HttpWebResponse httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (StreamReader streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                JToken t = JObject.Parse(streamReader.ReadToEnd());
                Boolean success = (Boolean)t["success"];
                //Console.WriteLine(t["statusMessage"]);
                if (success)
                    Assert.IsTrue(success);
                else
                    Assert.IsTrue(success, t["statusMessage"].ToString());
            }
        }

    }
}
