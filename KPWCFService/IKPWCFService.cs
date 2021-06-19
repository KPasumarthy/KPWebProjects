using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace KPWCFService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IKPWCFService
    {

        [OperationContract]
        string GetData(int value);

        [OperationContract]
        string GetFile(int value);

        [OperationContract]
        string SendAttachment(byte[] pFileBytes, string pFileName);

        [OperationContract]
        byte[] GetFileFromFolder(string filename);


        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "KP : Hello World - WCF Service ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }

    }
}
