﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KPWCFServiceUnitTest.KPWCFServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CompositeType", Namespace="http://schemas.datacontract.org/2004/07/KPWCFService")]
    [System.SerializableAttribute()]
    public partial class CompositeType : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool BoolValueField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StringValueField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool BoolValue {
            get {
                return this.BoolValueField;
            }
            set {
                if ((this.BoolValueField.Equals(value) != true)) {
                    this.BoolValueField = value;
                    this.RaisePropertyChanged("BoolValue");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StringValue {
            get {
                return this.StringValueField;
            }
            set {
                if ((object.ReferenceEquals(this.StringValueField, value) != true)) {
                    this.StringValueField = value;
                    this.RaisePropertyChanged("StringValue");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="KPWCFServiceReference.IKPWCFService")]
    public interface IKPWCFService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IKPWCFService/GetData", ReplyAction="http://tempuri.org/IKPWCFService/GetDataResponse")]
        string GetData(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IKPWCFService/GetData", ReplyAction="http://tempuri.org/IKPWCFService/GetDataResponse")]
        System.Threading.Tasks.Task<string> GetDataAsync(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IKPWCFService/GetFile", ReplyAction="http://tempuri.org/IKPWCFService/GetFileResponse")]
        string GetFile(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IKPWCFService/GetFile", ReplyAction="http://tempuri.org/IKPWCFService/GetFileResponse")]
        System.Threading.Tasks.Task<string> GetFileAsync(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IKPWCFService/SendAttachment", ReplyAction="http://tempuri.org/IKPWCFService/SendAttachmentResponse")]
        string SendAttachment(byte[] pFileBytes, string pFileName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IKPWCFService/SendAttachment", ReplyAction="http://tempuri.org/IKPWCFService/SendAttachmentResponse")]
        System.Threading.Tasks.Task<string> SendAttachmentAsync(byte[] pFileBytes, string pFileName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IKPWCFService/GetFileFromFolder", ReplyAction="http://tempuri.org/IKPWCFService/GetFileFromFolderResponse")]
        byte[] GetFileFromFolder(string filename);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IKPWCFService/GetFileFromFolder", ReplyAction="http://tempuri.org/IKPWCFService/GetFileFromFolderResponse")]
        System.Threading.Tasks.Task<byte[]> GetFileFromFolderAsync(string filename);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IKPWCFService/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IKPWCFService/GetDataUsingDataContractResponse")]
        KPWCFServiceUnitTest.KPWCFServiceReference.CompositeType GetDataUsingDataContract(KPWCFServiceUnitTest.KPWCFServiceReference.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IKPWCFService/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IKPWCFService/GetDataUsingDataContractResponse")]
        System.Threading.Tasks.Task<KPWCFServiceUnitTest.KPWCFServiceReference.CompositeType> GetDataUsingDataContractAsync(KPWCFServiceUnitTest.KPWCFServiceReference.CompositeType composite);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IKPWCFServiceChannel : KPWCFServiceUnitTest.KPWCFServiceReference.IKPWCFService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class KPWCFServiceClient : System.ServiceModel.ClientBase<KPWCFServiceUnitTest.KPWCFServiceReference.IKPWCFService>, KPWCFServiceUnitTest.KPWCFServiceReference.IKPWCFService {
        
        public KPWCFServiceClient() {
        }
        
        public KPWCFServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public KPWCFServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public KPWCFServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public KPWCFServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetData(int value) {
            return base.Channel.GetData(value);
        }
        
        public System.Threading.Tasks.Task<string> GetDataAsync(int value) {
            return base.Channel.GetDataAsync(value);
        }
        
        public string GetFile(int value) {
            return base.Channel.GetFile(value);
        }
        
        public System.Threading.Tasks.Task<string> GetFileAsync(int value) {
            return base.Channel.GetFileAsync(value);
        }
        
        public string SendAttachment(byte[] pFileBytes, string pFileName) {
            return base.Channel.SendAttachment(pFileBytes, pFileName);
        }
        
        public System.Threading.Tasks.Task<string> SendAttachmentAsync(byte[] pFileBytes, string pFileName) {
            return base.Channel.SendAttachmentAsync(pFileBytes, pFileName);
        }
        
        public byte[] GetFileFromFolder(string filename) {
            return base.Channel.GetFileFromFolder(filename);
        }
        
        public System.Threading.Tasks.Task<byte[]> GetFileFromFolderAsync(string filename) {
            return base.Channel.GetFileFromFolderAsync(filename);
        }
        
        public KPWCFServiceUnitTest.KPWCFServiceReference.CompositeType GetDataUsingDataContract(KPWCFServiceUnitTest.KPWCFServiceReference.CompositeType composite) {
            return base.Channel.GetDataUsingDataContract(composite);
        }
        
        public System.Threading.Tasks.Task<KPWCFServiceUnitTest.KPWCFServiceReference.CompositeType> GetDataUsingDataContractAsync(KPWCFServiceUnitTest.KPWCFServiceReference.CompositeType composite) {
            return base.Channel.GetDataUsingDataContractAsync(composite);
        }
    }
}
