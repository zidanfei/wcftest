﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34011
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WcfService1.SyncUnitService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="WSResponseDto", Namespace="http://schemas.datacontract.org/2004/07/iWS.FW.Framework.DTO")]
    [System.SerializableAttribute()]
    public partial class WSResponseDto : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool IsSuccessField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MessageField;
        
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
        public bool IsSuccess {
            get {
                return this.IsSuccessField;
            }
            set {
                if ((this.IsSuccessField.Equals(value) != true)) {
                    this.IsSuccessField = value;
                    this.RaisePropertyChanged("IsSuccess");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Message {
            get {
                return this.MessageField;
            }
            set {
                if ((object.ReferenceEquals(this.MessageField, value) != true)) {
                    this.MessageField = value;
                    this.RaisePropertyChanged("Message");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SyncUnitService.ISyncUnitService")]
    public interface ISyncUnitService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISyncUnitService/Execute", ReplyAction="http://tempuri.org/ISyncUnitService/ExecuteResponse")]
        WcfService1.SyncUnitService.WSResponseDto Execute(string groupName, string syncName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISyncUnitService/Execute", ReplyAction="http://tempuri.org/ISyncUnitService/ExecuteResponse")]
        System.Threading.Tasks.Task<WcfService1.SyncUnitService.WSResponseDto> ExecuteAsync(string groupName, string syncName);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ISyncUnitServiceChannel : WcfService1.SyncUnitService.ISyncUnitService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SyncUnitServiceClient : System.ServiceModel.ClientBase<WcfService1.SyncUnitService.ISyncUnitService>, WcfService1.SyncUnitService.ISyncUnitService {
        
        public SyncUnitServiceClient() {
        }
        
        public SyncUnitServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SyncUnitServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SyncUnitServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SyncUnitServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public WcfService1.SyncUnitService.WSResponseDto Execute(string groupName, string syncName) {
            return base.Channel.Execute(groupName, syncName);
        }
        
        public System.Threading.Tasks.Task<WcfService1.SyncUnitService.WSResponseDto> ExecuteAsync(string groupName, string syncName) {
            return base.Channel.ExecuteAsync(groupName, syncName);
        }
    }
}
