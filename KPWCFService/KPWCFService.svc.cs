using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;

using System.Net.Mail;
using System.IO;
using System.Net.Mime;
using System.Net;


namespace KPWCFService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1 = KPWCFService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class KPWCFService : IKPWCFService
    {
        public string GetData(int value)
        {
            return string.Format("KP : You entered: {0}", value);
        }


        public string GetData(string value)
        {
            return string.Format("KP : You entered: {0}", value);
        }

        public string GetFile(int value)
        {
            return string.Format("KP : You entered: {0}", value);
        }

        public string SendAttachment(byte[] pFileBytes, string pFileName)
        {
            bool isSuccess = false;
            FileStream fileStream = null;
            //Get the file upload path store in web services web.config file.  
            //string strTempFolderPath = System.Configuration.ConfigurationManager.AppSettings.Get("FileUploadPath");
            string strTempFolderPath = @"C:\Projects\KPWebProjects\KPWCFService\bin\";
            try
            {
                            if (!string.IsNullOrEmpty(strTempFolderPath))
                {
                    if (!string.IsNullOrEmpty(pFileName))
                    {
                        string strFileFullPath = strTempFolderPath + pFileName;
                        fileStream = new FileStream(strFileFullPath, FileMode.OpenOrCreate, FileAccess.ReadWrite);
                        // write file stream into the specified file  
                        using (System.IO.FileStream fs = fileStream)
                        {
                            fs.Write(pFileBytes, 0, pFileBytes.Length);
                            isSuccess = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return string.Format("KP : SendAttachment : " + isSuccess);
        }

        public byte[] GetFileFromFolder(string filename)
        {
            byte[] filedetails = new byte[0];
            //string strTempFolderPath = System.Configuration.ConfigurationManager.AppSettings.Get("FileUploadPath");
            string strTempFolderPath = @"C:\Projects\KPWebProjects\KPWCFService\bin\";
            if (File.Exists(strTempFolderPath + filename))
            {
                return File.ReadAllBytes(strTempFolderPath + filename);
            }
            else return filedetails;
        }

        public Task<string> GetDataAsync(int value)
        {
            return Task.FromResult<string>(string.Format("KP : GetDataAsync You entered: {0}", value));
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "KP : Suffix";
            }
            return composite;
        }

    }
}