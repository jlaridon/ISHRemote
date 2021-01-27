﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Trisoft.ISHRemote.MetadataBinding25ServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="InfoShareFault", Namespace="http://sdl.com/trisoft/2012/06/WebServices/Contracts/Faults/API25/")]
    [System.SerializableAttribute()]
    public partial class InfoShareFault : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long InfoShareErrorNumberField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string OriginField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string XMLDetailField;
        
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
        public string Description {
            get {
                return this.DescriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.DescriptionField, value) != true)) {
                    this.DescriptionField = value;
                    this.RaisePropertyChanged("Description");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long InfoShareErrorNumber {
            get {
                return this.InfoShareErrorNumberField;
            }
            set {
                if ((this.InfoShareErrorNumberField.Equals(value) != true)) {
                    this.InfoShareErrorNumberField = value;
                    this.RaisePropertyChanged("InfoShareErrorNumber");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Origin {
            get {
                return this.OriginField;
            }
            set {
                if ((object.ReferenceEquals(this.OriginField, value) != true)) {
                    this.OriginField = value;
                    this.RaisePropertyChanged("Origin");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string XMLDetail {
            get {
                return this.XMLDetailField;
            }
            set {
                if ((object.ReferenceEquals(this.XMLDetailField, value) != true)) {
                    this.XMLDetailField = value;
                    this.RaisePropertyChanged("XMLDetail");
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
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://sdl.com/trisoft/2012/06/WebServices/Services/API25/", ConfigurationName="MetadataBinding25ServiceReference.MetadataBinding")]
    public interface MetadataBinding {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://sdl.com/trisoft/2012/06/WebServices/Services/API25/MetadataBinding/Resolve" +
            "Ids", ReplyAction="http://sdl.com/trisoft/2012/06/WebServices/Services/API25/MetadataBinding/Resolve" +
            "IdsResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Trisoft.ISHRemote.MetadataBinding25ServiceReference.InfoShareFault), Action="http://sdl.com/trisoft/2012/06/WebServices/Services/API25/MetadataBinding/Resolve" +
            "IdsInfoShareFault", Name="InfoShareFault", Namespace="http://sdl.com/trisoft/2012/06/WebServices/Contracts/Faults/API25/")]
        [return: System.ServiceModel.MessageParameterAttribute(Name="outXmlFieldTags")]
        string ResolveIds(string xmlFieldTags, string language);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://sdl.com/trisoft/2012/06/WebServices/Services/API25/MetadataBinding/Resolve" +
            "Ids", ReplyAction="http://sdl.com/trisoft/2012/06/WebServices/Services/API25/MetadataBinding/Resolve" +
            "IdsResponse")]
        [return: System.ServiceModel.MessageParameterAttribute(Name="outXmlFieldTags")]
        System.Threading.Tasks.Task<string> ResolveIdsAsync(string xmlFieldTags, string language);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://sdl.com/trisoft/2012/06/WebServices/Services/API25/MetadataBinding/Retriev" +
            "eTags", ReplyAction="http://sdl.com/trisoft/2012/06/WebServices/Services/API25/MetadataBinding/Retriev" +
            "eTagsResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Trisoft.ISHRemote.MetadataBinding25ServiceReference.InfoShareFault), Action="http://sdl.com/trisoft/2012/06/WebServices/Services/API25/MetadataBinding/Retriev" +
            "eTagsInfoShareFault", Name="InfoShareFault", Namespace="http://sdl.com/trisoft/2012/06/WebServices/Contracts/Faults/API25/")]
        [return: System.ServiceModel.MessageParameterAttribute(Name="xmlFieldTags")]
        string RetrieveTags(string fieldName, string fieldLevel, string inputFilter, string xmlFieldsFilter, string language, long maxTagsToReturn);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://sdl.com/trisoft/2012/06/WebServices/Services/API25/MetadataBinding/Retriev" +
            "eTags", ReplyAction="http://sdl.com/trisoft/2012/06/WebServices/Services/API25/MetadataBinding/Retriev" +
            "eTagsResponse")]
        [return: System.ServiceModel.MessageParameterAttribute(Name="xmlFieldTags")]
        System.Threading.Tasks.Task<string> RetrieveTagsAsync(string fieldName, string fieldLevel, string inputFilter, string xmlFieldsFilter, string language, long maxTagsToReturn);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://sdl.com/trisoft/2012/06/WebServices/Services/API25/MetadataBinding/Retriev" +
            "eTagStructure", ReplyAction="http://sdl.com/trisoft/2012/06/WebServices/Services/API25/MetadataBinding/Retriev" +
            "eTagStructureResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Trisoft.ISHRemote.MetadataBinding25ServiceReference.InfoShareFault), Action="http://sdl.com/trisoft/2012/06/WebServices/Services/API25/MetadataBinding/Retriev" +
            "eTagStructureInfoShareFault", Name="InfoShareFault", Namespace="http://sdl.com/trisoft/2012/06/WebServices/Contracts/Faults/API25/")]
        [return: System.ServiceModel.MessageParameterAttribute(Name="xmlFieldTags")]
        string RetrieveTagStructure(string fieldName, string fieldLevel, string xmlFieldsFilter, string language);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://sdl.com/trisoft/2012/06/WebServices/Services/API25/MetadataBinding/Retriev" +
            "eTagStructure", ReplyAction="http://sdl.com/trisoft/2012/06/WebServices/Services/API25/MetadataBinding/Retriev" +
            "eTagStructureResponse")]
        [return: System.ServiceModel.MessageParameterAttribute(Name="xmlFieldTags")]
        System.Threading.Tasks.Task<string> RetrieveTagStructureAsync(string fieldName, string fieldLevel, string xmlFieldsFilter, string language);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://sdl.com/trisoft/2012/06/WebServices/Services/API25/MetadataBinding/SmartTa" +
            "g", ReplyAction="http://sdl.com/trisoft/2012/06/WebServices/Services/API25/MetadataBinding/SmartTa" +
            "gResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Trisoft.ISHRemote.MetadataBinding25ServiceReference.InfoShareFault), Action="http://sdl.com/trisoft/2012/06/WebServices/Services/API25/MetadataBinding/SmartTa" +
            "gInfoShareFault", Name="InfoShareFault", Namespace="http://sdl.com/trisoft/2012/06/WebServices/Contracts/Faults/API25/")]
        [return: System.ServiceModel.MessageParameterAttribute(Name="outXmlFieldTags")]
        string SmartTag(string xmlFieldTags, string language, string edt, byte[] data);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://sdl.com/trisoft/2012/06/WebServices/Services/API25/MetadataBinding/SmartTa" +
            "g", ReplyAction="http://sdl.com/trisoft/2012/06/WebServices/Services/API25/MetadataBinding/SmartTa" +
            "gResponse")]
        [return: System.ServiceModel.MessageParameterAttribute(Name="outXmlFieldTags")]
        System.Threading.Tasks.Task<string> SmartTagAsync(string xmlFieldTags, string language, string edt, byte[] data);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface MetadataBindingChannel : Trisoft.ISHRemote.MetadataBinding25ServiceReference.MetadataBinding, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MetadataBindingClient : System.ServiceModel.ClientBase<Trisoft.ISHRemote.MetadataBinding25ServiceReference.MetadataBinding>, Trisoft.ISHRemote.MetadataBinding25ServiceReference.MetadataBinding {
        
        public MetadataBindingClient() {
        }
        
        public MetadataBindingClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public MetadataBindingClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MetadataBindingClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MetadataBindingClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string ResolveIds(string xmlFieldTags, string language) {
            return base.Channel.ResolveIds(xmlFieldTags, language);
        }
        
        public System.Threading.Tasks.Task<string> ResolveIdsAsync(string xmlFieldTags, string language) {
            return base.Channel.ResolveIdsAsync(xmlFieldTags, language);
        }
        
        public string RetrieveTags(string fieldName, string fieldLevel, string inputFilter, string xmlFieldsFilter, string language, long maxTagsToReturn) {
            return base.Channel.RetrieveTags(fieldName, fieldLevel, inputFilter, xmlFieldsFilter, language, maxTagsToReturn);
        }
        
        public System.Threading.Tasks.Task<string> RetrieveTagsAsync(string fieldName, string fieldLevel, string inputFilter, string xmlFieldsFilter, string language, long maxTagsToReturn) {
            return base.Channel.RetrieveTagsAsync(fieldName, fieldLevel, inputFilter, xmlFieldsFilter, language, maxTagsToReturn);
        }
        
        public string RetrieveTagStructure(string fieldName, string fieldLevel, string xmlFieldsFilter, string language) {
            return base.Channel.RetrieveTagStructure(fieldName, fieldLevel, xmlFieldsFilter, language);
        }
        
        public System.Threading.Tasks.Task<string> RetrieveTagStructureAsync(string fieldName, string fieldLevel, string xmlFieldsFilter, string language) {
            return base.Channel.RetrieveTagStructureAsync(fieldName, fieldLevel, xmlFieldsFilter, language);
        }
        
        public string SmartTag(string xmlFieldTags, string language, string edt, byte[] data) {
            return base.Channel.SmartTag(xmlFieldTags, language, edt, data);
        }
        
        public System.Threading.Tasks.Task<string> SmartTagAsync(string xmlFieldTags, string language, string edt, byte[] data) {
            return base.Channel.SmartTagAsync(xmlFieldTags, language, edt, data);
        }
    }
}
