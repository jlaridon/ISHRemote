//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Trisoft.ISHRemote.UserRole25ServiceReference
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="urn:trisoft.be:WebServices:InfoShare:UserRole:2.5", ConfigurationName="Trisoft.ISHRemote.UserRole25ServiceReference.UserRole25Soap")]
    public interface UserRole25Soap
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:trisoft.be:WebServices:InfoShare:UserRole:2.5/GetMetaData", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        Trisoft.ISHRemote.UserRole25ServiceReference.GetMetaDataResponse GetMetaData(Trisoft.ISHRemote.UserRole25ServiceReference.GetMetaDataRequest request);
        
        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action="urn:trisoft.be:WebServices:InfoShare:UserRole:2.5/GetMetaData", ReplyAction="*")]
        System.Threading.Tasks.Task<Trisoft.ISHRemote.UserRole25ServiceReference.GetMetaDataResponse> GetMetaDataAsync(Trisoft.ISHRemote.UserRole25ServiceReference.GetMetaDataRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:trisoft.be:WebServices:InfoShare:UserRole:2.5/RetrieveMetaData", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        Trisoft.ISHRemote.UserRole25ServiceReference.RetrieveMetaDataResponse RetrieveMetaData(Trisoft.ISHRemote.UserRole25ServiceReference.RetrieveMetaDataRequest request);
        
        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action="urn:trisoft.be:WebServices:InfoShare:UserRole:2.5/RetrieveMetaData", ReplyAction="*")]
        System.Threading.Tasks.Task<Trisoft.ISHRemote.UserRole25ServiceReference.RetrieveMetaDataResponse> RetrieveMetaDataAsync(Trisoft.ISHRemote.UserRole25ServiceReference.RetrieveMetaDataRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:trisoft.be:WebServices:InfoShare:UserRole:2.5/Find", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        Trisoft.ISHRemote.UserRole25ServiceReference.FindResponse Find(Trisoft.ISHRemote.UserRole25ServiceReference.FindRequest request);
        
        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action="urn:trisoft.be:WebServices:InfoShare:UserRole:2.5/Find", ReplyAction="*")]
        System.Threading.Tasks.Task<Trisoft.ISHRemote.UserRole25ServiceReference.FindResponse> FindAsync(Trisoft.ISHRemote.UserRole25ServiceReference.FindRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:trisoft.be:WebServices:InfoShare:UserRole:2.5/Create", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        Trisoft.ISHRemote.UserRole25ServiceReference.CreateResponse Create(Trisoft.ISHRemote.UserRole25ServiceReference.CreateRequest request);
        
        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action="urn:trisoft.be:WebServices:InfoShare:UserRole:2.5/Create", ReplyAction="*")]
        System.Threading.Tasks.Task<Trisoft.ISHRemote.UserRole25ServiceReference.CreateResponse> CreateAsync(Trisoft.ISHRemote.UserRole25ServiceReference.CreateRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:trisoft.be:WebServices:InfoShare:UserRole:2.5/Update", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        Trisoft.ISHRemote.UserRole25ServiceReference.UpdateResponse Update(Trisoft.ISHRemote.UserRole25ServiceReference.UpdateRequest request);
        
        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action="urn:trisoft.be:WebServices:InfoShare:UserRole:2.5/Update", ReplyAction="*")]
        System.Threading.Tasks.Task<Trisoft.ISHRemote.UserRole25ServiceReference.UpdateResponse> UpdateAsync(Trisoft.ISHRemote.UserRole25ServiceReference.UpdateRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:trisoft.be:WebServices:InfoShare:UserRole:2.5/Delete", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        Trisoft.ISHRemote.UserRole25ServiceReference.DeleteResponse Delete(Trisoft.ISHRemote.UserRole25ServiceReference.DeleteRequest request);
        
        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action="urn:trisoft.be:WebServices:InfoShare:UserRole:2.5/Delete", ReplyAction="*")]
        System.Threading.Tasks.Task<Trisoft.ISHRemote.UserRole25ServiceReference.DeleteResponse> DeleteAsync(Trisoft.ISHRemote.UserRole25ServiceReference.DeleteRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetMetaData", WrapperNamespace="urn:trisoft.be:WebServices:InfoShare:UserRole:2.5", IsWrapped=true)]
    public partial class GetMetaDataRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:trisoft.be:WebServices:InfoShare:UserRole:2.5", Order=0)]
        public string psAuthContext;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:trisoft.be:WebServices:InfoShare:UserRole:2.5", Order=1)]
        public string psUserRoleId;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:trisoft.be:WebServices:InfoShare:UserRole:2.5", Order=2)]
        public string psXMLRequestedMetaData;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:trisoft.be:WebServices:InfoShare:UserRole:2.5", Order=3)]
        public string psOutXMLObjList;
        
        public GetMetaDataRequest()
        {
        }
        
        public GetMetaDataRequest(string psAuthContext, string psUserRoleId, string psXMLRequestedMetaData, string psOutXMLObjList)
        {
            this.psAuthContext = psAuthContext;
            this.psUserRoleId = psUserRoleId;
            this.psXMLRequestedMetaData = psXMLRequestedMetaData;
            this.psOutXMLObjList = psOutXMLObjList;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetMetaDataResponse", WrapperNamespace="urn:trisoft.be:WebServices:InfoShare:UserRole:2.5", IsWrapped=true)]
    public partial class GetMetaDataResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:trisoft.be:WebServices:InfoShare:UserRole:2.5", Order=0)]
        public string GetMetaDataResult;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:trisoft.be:WebServices:InfoShare:UserRole:2.5", Order=1)]
        public string psAuthContext;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:trisoft.be:WebServices:InfoShare:UserRole:2.5", Order=2)]
        public string psOutXMLObjList;
        
        public GetMetaDataResponse()
        {
        }
        
        public GetMetaDataResponse(string GetMetaDataResult, string psAuthContext, string psOutXMLObjList)
        {
            this.GetMetaDataResult = GetMetaDataResult;
            this.psAuthContext = psAuthContext;
            this.psOutXMLObjList = psOutXMLObjList;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:trisoft.be:WebServices:InfoShare:UserRole:2.5")]
    public enum eActivityFilter
    {
        
        /// <remarks/>
        None,
        
        /// <remarks/>
        Active,
        
        /// <remarks/>
        Inactive,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="RetrieveMetaData", WrapperNamespace="urn:trisoft.be:WebServices:InfoShare:UserRole:2.5", IsWrapped=true)]
    public partial class RetrieveMetaDataRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:trisoft.be:WebServices:InfoShare:UserRole:2.5", Order=0)]
        public string psAuthContext;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:trisoft.be:WebServices:InfoShare:UserRole:2.5", Order=1)]
        public string[] pasUserRoleIds;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:trisoft.be:WebServices:InfoShare:UserRole:2.5", Order=2)]
        public Trisoft.ISHRemote.UserRole25ServiceReference.eActivityFilter peActivityFilter;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:trisoft.be:WebServices:InfoShare:UserRole:2.5", Order=3)]
        public string psXMLMetadataFilter;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:trisoft.be:WebServices:InfoShare:UserRole:2.5", Order=4)]
        public string psXMLRequestedMetaData;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:trisoft.be:WebServices:InfoShare:UserRole:2.5", Order=5)]
        public string psOutXMLObjList;
        
        public RetrieveMetaDataRequest()
        {
        }
        
        public RetrieveMetaDataRequest(string psAuthContext, string[] pasUserRoleIds, Trisoft.ISHRemote.UserRole25ServiceReference.eActivityFilter peActivityFilter, string psXMLMetadataFilter, string psXMLRequestedMetaData, string psOutXMLObjList)
        {
            this.psAuthContext = psAuthContext;
            this.pasUserRoleIds = pasUserRoleIds;
            this.peActivityFilter = peActivityFilter;
            this.psXMLMetadataFilter = psXMLMetadataFilter;
            this.psXMLRequestedMetaData = psXMLRequestedMetaData;
            this.psOutXMLObjList = psOutXMLObjList;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="RetrieveMetaDataResponse", WrapperNamespace="urn:trisoft.be:WebServices:InfoShare:UserRole:2.5", IsWrapped=true)]
    public partial class RetrieveMetaDataResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:trisoft.be:WebServices:InfoShare:UserRole:2.5", Order=0)]
        public string RetrieveMetaDataResult;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:trisoft.be:WebServices:InfoShare:UserRole:2.5", Order=1)]
        public string psAuthContext;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:trisoft.be:WebServices:InfoShare:UserRole:2.5", Order=2)]
        public string psOutXMLObjList;
        
        public RetrieveMetaDataResponse()
        {
        }
        
        public RetrieveMetaDataResponse(string RetrieveMetaDataResult, string psAuthContext, string psOutXMLObjList)
        {
            this.RetrieveMetaDataResult = RetrieveMetaDataResult;
            this.psAuthContext = psAuthContext;
            this.psOutXMLObjList = psOutXMLObjList;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Find", WrapperNamespace="urn:trisoft.be:WebServices:InfoShare:UserRole:2.5", IsWrapped=true)]
    public partial class FindRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:trisoft.be:WebServices:InfoShare:UserRole:2.5", Order=0)]
        public string psAuthContext;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:trisoft.be:WebServices:InfoShare:UserRole:2.5", Order=1)]
        public Trisoft.ISHRemote.UserRole25ServiceReference.eActivityFilter peActivityFilter;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:trisoft.be:WebServices:InfoShare:UserRole:2.5", Order=2)]
        public string psXMLMetadataFilter;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:trisoft.be:WebServices:InfoShare:UserRole:2.5", Order=3)]
        public string psXMLRequestedMetaData;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:trisoft.be:WebServices:InfoShare:UserRole:2.5", Order=4)]
        public string psOutXMLObjList;
        
        public FindRequest()
        {
        }
        
        public FindRequest(string psAuthContext, Trisoft.ISHRemote.UserRole25ServiceReference.eActivityFilter peActivityFilter, string psXMLMetadataFilter, string psXMLRequestedMetaData, string psOutXMLObjList)
        {
            this.psAuthContext = psAuthContext;
            this.peActivityFilter = peActivityFilter;
            this.psXMLMetadataFilter = psXMLMetadataFilter;
            this.psXMLRequestedMetaData = psXMLRequestedMetaData;
            this.psOutXMLObjList = psOutXMLObjList;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="FindResponse", WrapperNamespace="urn:trisoft.be:WebServices:InfoShare:UserRole:2.5", IsWrapped=true)]
    public partial class FindResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:trisoft.be:WebServices:InfoShare:UserRole:2.5", Order=0)]
        public string FindResult;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:trisoft.be:WebServices:InfoShare:UserRole:2.5", Order=1)]
        public string psAuthContext;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:trisoft.be:WebServices:InfoShare:UserRole:2.5", Order=2)]
        public string psOutXMLObjList;
        
        public FindResponse()
        {
        }
        
        public FindResponse(string FindResult, string psAuthContext, string psOutXMLObjList)
        {
            this.FindResult = FindResult;
            this.psAuthContext = psAuthContext;
            this.psOutXMLObjList = psOutXMLObjList;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Create", WrapperNamespace="urn:trisoft.be:WebServices:InfoShare:UserRole:2.5", IsWrapped=true)]
    public partial class CreateRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:trisoft.be:WebServices:InfoShare:UserRole:2.5", Order=0)]
        public string psAuthContext;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:trisoft.be:WebServices:InfoShare:UserRole:2.5", Order=1)]
        public string psUserRoleName;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:trisoft.be:WebServices:InfoShare:UserRole:2.5", Order=2)]
        public string psXMLMetaData;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:trisoft.be:WebServices:InfoShare:UserRole:2.5", Order=3)]
        public string psOutUserRoleId;
        
        public CreateRequest()
        {
        }
        
        public CreateRequest(string psAuthContext, string psUserRoleName, string psXMLMetaData, string psOutUserRoleId)
        {
            this.psAuthContext = psAuthContext;
            this.psUserRoleName = psUserRoleName;
            this.psXMLMetaData = psXMLMetaData;
            this.psOutUserRoleId = psOutUserRoleId;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="CreateResponse", WrapperNamespace="urn:trisoft.be:WebServices:InfoShare:UserRole:2.5", IsWrapped=true)]
    public partial class CreateResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:trisoft.be:WebServices:InfoShare:UserRole:2.5", Order=0)]
        public string CreateResult;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:trisoft.be:WebServices:InfoShare:UserRole:2.5", Order=1)]
        public string psAuthContext;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:trisoft.be:WebServices:InfoShare:UserRole:2.5", Order=2)]
        public string psOutUserRoleId;
        
        public CreateResponse()
        {
        }
        
        public CreateResponse(string CreateResult, string psAuthContext, string psOutUserRoleId)
        {
            this.CreateResult = CreateResult;
            this.psAuthContext = psAuthContext;
            this.psOutUserRoleId = psOutUserRoleId;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Update", WrapperNamespace="urn:trisoft.be:WebServices:InfoShare:UserRole:2.5", IsWrapped=true)]
    public partial class UpdateRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:trisoft.be:WebServices:InfoShare:UserRole:2.5", Order=0)]
        public string psAuthContext;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:trisoft.be:WebServices:InfoShare:UserRole:2.5", Order=1)]
        public string psUserRoleId;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:trisoft.be:WebServices:InfoShare:UserRole:2.5", Order=2)]
        public string psXMLMetaData;
        
        public UpdateRequest()
        {
        }
        
        public UpdateRequest(string psAuthContext, string psUserRoleId, string psXMLMetaData)
        {
            this.psAuthContext = psAuthContext;
            this.psUserRoleId = psUserRoleId;
            this.psXMLMetaData = psXMLMetaData;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="UpdateResponse", WrapperNamespace="urn:trisoft.be:WebServices:InfoShare:UserRole:2.5", IsWrapped=true)]
    public partial class UpdateResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:trisoft.be:WebServices:InfoShare:UserRole:2.5", Order=0)]
        public string UpdateResult;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:trisoft.be:WebServices:InfoShare:UserRole:2.5", Order=1)]
        public string psAuthContext;
        
        public UpdateResponse()
        {
        }
        
        public UpdateResponse(string UpdateResult, string psAuthContext)
        {
            this.UpdateResult = UpdateResult;
            this.psAuthContext = psAuthContext;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Delete", WrapperNamespace="urn:trisoft.be:WebServices:InfoShare:UserRole:2.5", IsWrapped=true)]
    public partial class DeleteRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:trisoft.be:WebServices:InfoShare:UserRole:2.5", Order=0)]
        public string psAuthContext;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:trisoft.be:WebServices:InfoShare:UserRole:2.5", Order=1)]
        public string psUserRoleId;
        
        public DeleteRequest()
        {
        }
        
        public DeleteRequest(string psAuthContext, string psUserRoleId)
        {
            this.psAuthContext = psAuthContext;
            this.psUserRoleId = psUserRoleId;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DeleteResponse", WrapperNamespace="urn:trisoft.be:WebServices:InfoShare:UserRole:2.5", IsWrapped=true)]
    public partial class DeleteResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:trisoft.be:WebServices:InfoShare:UserRole:2.5", Order=0)]
        public string DeleteResult;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:trisoft.be:WebServices:InfoShare:UserRole:2.5", Order=1)]
        public string psAuthContext;
        
        public DeleteResponse()
        {
        }
        
        public DeleteResponse(string DeleteResult, string psAuthContext)
        {
            this.DeleteResult = DeleteResult;
            this.psAuthContext = psAuthContext;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    public interface UserRole25SoapChannel : Trisoft.ISHRemote.UserRole25ServiceReference.UserRole25Soap, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    public partial class UserRole25SoapClient : System.ServiceModel.ClientBase<Trisoft.ISHRemote.UserRole25ServiceReference.UserRole25Soap>, Trisoft.ISHRemote.UserRole25ServiceReference.UserRole25Soap
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public UserRole25SoapClient(EndpointConfiguration endpointConfiguration) : 
                base(UserRole25SoapClient.GetBindingForEndpoint(endpointConfiguration), UserRole25SoapClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public UserRole25SoapClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(UserRole25SoapClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public UserRole25SoapClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(UserRole25SoapClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public UserRole25SoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Trisoft.ISHRemote.UserRole25ServiceReference.GetMetaDataResponse Trisoft.ISHRemote.UserRole25ServiceReference.UserRole25Soap.GetMetaData(Trisoft.ISHRemote.UserRole25ServiceReference.GetMetaDataRequest request)
        {
            return base.Channel.GetMetaData(request);
        }
        
        public string GetMetaData(ref string psAuthContext, string psUserRoleId, string psXMLRequestedMetaData, ref string psOutXMLObjList)
        {
            Trisoft.ISHRemote.UserRole25ServiceReference.GetMetaDataRequest inValue = new Trisoft.ISHRemote.UserRole25ServiceReference.GetMetaDataRequest();
            inValue.psAuthContext = psAuthContext;
            inValue.psUserRoleId = psUserRoleId;
            inValue.psXMLRequestedMetaData = psXMLRequestedMetaData;
            inValue.psOutXMLObjList = psOutXMLObjList;
            Trisoft.ISHRemote.UserRole25ServiceReference.GetMetaDataResponse retVal = ((Trisoft.ISHRemote.UserRole25ServiceReference.UserRole25Soap)(this)).GetMetaData(inValue);
            psAuthContext = retVal.psAuthContext;
            psOutXMLObjList = retVal.psOutXMLObjList;
            return retVal.GetMetaDataResult;
        }
        
        public System.Threading.Tasks.Task<Trisoft.ISHRemote.UserRole25ServiceReference.GetMetaDataResponse> GetMetaDataAsync(Trisoft.ISHRemote.UserRole25ServiceReference.GetMetaDataRequest request)
        {
            return base.Channel.GetMetaDataAsync(request);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Trisoft.ISHRemote.UserRole25ServiceReference.RetrieveMetaDataResponse Trisoft.ISHRemote.UserRole25ServiceReference.UserRole25Soap.RetrieveMetaData(Trisoft.ISHRemote.UserRole25ServiceReference.RetrieveMetaDataRequest request)
        {
            return base.Channel.RetrieveMetaData(request);
        }
        
        public string RetrieveMetaData(ref string psAuthContext, string[] pasUserRoleIds, Trisoft.ISHRemote.UserRole25ServiceReference.eActivityFilter peActivityFilter, string psXMLMetadataFilter, string psXMLRequestedMetaData, ref string psOutXMLObjList)
        {
            Trisoft.ISHRemote.UserRole25ServiceReference.RetrieveMetaDataRequest inValue = new Trisoft.ISHRemote.UserRole25ServiceReference.RetrieveMetaDataRequest();
            inValue.psAuthContext = psAuthContext;
            inValue.pasUserRoleIds = pasUserRoleIds;
            inValue.peActivityFilter = peActivityFilter;
            inValue.psXMLMetadataFilter = psXMLMetadataFilter;
            inValue.psXMLRequestedMetaData = psXMLRequestedMetaData;
            inValue.psOutXMLObjList = psOutXMLObjList;
            Trisoft.ISHRemote.UserRole25ServiceReference.RetrieveMetaDataResponse retVal = ((Trisoft.ISHRemote.UserRole25ServiceReference.UserRole25Soap)(this)).RetrieveMetaData(inValue);
            psAuthContext = retVal.psAuthContext;
            psOutXMLObjList = retVal.psOutXMLObjList;
            return retVal.RetrieveMetaDataResult;
        }
        
        public System.Threading.Tasks.Task<Trisoft.ISHRemote.UserRole25ServiceReference.RetrieveMetaDataResponse> RetrieveMetaDataAsync(Trisoft.ISHRemote.UserRole25ServiceReference.RetrieveMetaDataRequest request)
        {
            return base.Channel.RetrieveMetaDataAsync(request);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Trisoft.ISHRemote.UserRole25ServiceReference.FindResponse Trisoft.ISHRemote.UserRole25ServiceReference.UserRole25Soap.Find(Trisoft.ISHRemote.UserRole25ServiceReference.FindRequest request)
        {
            return base.Channel.Find(request);
        }
        
        public string Find(ref string psAuthContext, Trisoft.ISHRemote.UserRole25ServiceReference.eActivityFilter peActivityFilter, string psXMLMetadataFilter, string psXMLRequestedMetaData, ref string psOutXMLObjList)
        {
            Trisoft.ISHRemote.UserRole25ServiceReference.FindRequest inValue = new Trisoft.ISHRemote.UserRole25ServiceReference.FindRequest();
            inValue.psAuthContext = psAuthContext;
            inValue.peActivityFilter = peActivityFilter;
            inValue.psXMLMetadataFilter = psXMLMetadataFilter;
            inValue.psXMLRequestedMetaData = psXMLRequestedMetaData;
            inValue.psOutXMLObjList = psOutXMLObjList;
            Trisoft.ISHRemote.UserRole25ServiceReference.FindResponse retVal = ((Trisoft.ISHRemote.UserRole25ServiceReference.UserRole25Soap)(this)).Find(inValue);
            psAuthContext = retVal.psAuthContext;
            psOutXMLObjList = retVal.psOutXMLObjList;
            return retVal.FindResult;
        }
        
        public System.Threading.Tasks.Task<Trisoft.ISHRemote.UserRole25ServiceReference.FindResponse> FindAsync(Trisoft.ISHRemote.UserRole25ServiceReference.FindRequest request)
        {
            return base.Channel.FindAsync(request);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Trisoft.ISHRemote.UserRole25ServiceReference.CreateResponse Trisoft.ISHRemote.UserRole25ServiceReference.UserRole25Soap.Create(Trisoft.ISHRemote.UserRole25ServiceReference.CreateRequest request)
        {
            return base.Channel.Create(request);
        }
        
        public string Create(ref string psAuthContext, string psUserRoleName, string psXMLMetaData, ref string psOutUserRoleId)
        {
            Trisoft.ISHRemote.UserRole25ServiceReference.CreateRequest inValue = new Trisoft.ISHRemote.UserRole25ServiceReference.CreateRequest();
            inValue.psAuthContext = psAuthContext;
            inValue.psUserRoleName = psUserRoleName;
            inValue.psXMLMetaData = psXMLMetaData;
            inValue.psOutUserRoleId = psOutUserRoleId;
            Trisoft.ISHRemote.UserRole25ServiceReference.CreateResponse retVal = ((Trisoft.ISHRemote.UserRole25ServiceReference.UserRole25Soap)(this)).Create(inValue);
            psAuthContext = retVal.psAuthContext;
            psOutUserRoleId = retVal.psOutUserRoleId;
            return retVal.CreateResult;
        }
        
        public System.Threading.Tasks.Task<Trisoft.ISHRemote.UserRole25ServiceReference.CreateResponse> CreateAsync(Trisoft.ISHRemote.UserRole25ServiceReference.CreateRequest request)
        {
            return base.Channel.CreateAsync(request);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Trisoft.ISHRemote.UserRole25ServiceReference.UpdateResponse Trisoft.ISHRemote.UserRole25ServiceReference.UserRole25Soap.Update(Trisoft.ISHRemote.UserRole25ServiceReference.UpdateRequest request)
        {
            return base.Channel.Update(request);
        }
        
        public string Update(ref string psAuthContext, string psUserRoleId, string psXMLMetaData)
        {
            Trisoft.ISHRemote.UserRole25ServiceReference.UpdateRequest inValue = new Trisoft.ISHRemote.UserRole25ServiceReference.UpdateRequest();
            inValue.psAuthContext = psAuthContext;
            inValue.psUserRoleId = psUserRoleId;
            inValue.psXMLMetaData = psXMLMetaData;
            Trisoft.ISHRemote.UserRole25ServiceReference.UpdateResponse retVal = ((Trisoft.ISHRemote.UserRole25ServiceReference.UserRole25Soap)(this)).Update(inValue);
            psAuthContext = retVal.psAuthContext;
            return retVal.UpdateResult;
        }
        
        public System.Threading.Tasks.Task<Trisoft.ISHRemote.UserRole25ServiceReference.UpdateResponse> UpdateAsync(Trisoft.ISHRemote.UserRole25ServiceReference.UpdateRequest request)
        {
            return base.Channel.UpdateAsync(request);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Trisoft.ISHRemote.UserRole25ServiceReference.DeleteResponse Trisoft.ISHRemote.UserRole25ServiceReference.UserRole25Soap.Delete(Trisoft.ISHRemote.UserRole25ServiceReference.DeleteRequest request)
        {
            return base.Channel.Delete(request);
        }
        
        public string Delete(ref string psAuthContext, string psUserRoleId)
        {
            Trisoft.ISHRemote.UserRole25ServiceReference.DeleteRequest inValue = new Trisoft.ISHRemote.UserRole25ServiceReference.DeleteRequest();
            inValue.psAuthContext = psAuthContext;
            inValue.psUserRoleId = psUserRoleId;
            Trisoft.ISHRemote.UserRole25ServiceReference.DeleteResponse retVal = ((Trisoft.ISHRemote.UserRole25ServiceReference.UserRole25Soap)(this)).Delete(inValue);
            psAuthContext = retVal.psAuthContext;
            return retVal.DeleteResult;
        }
        
        public System.Threading.Tasks.Task<Trisoft.ISHRemote.UserRole25ServiceReference.DeleteResponse> DeleteAsync(Trisoft.ISHRemote.UserRole25ServiceReference.DeleteRequest request)
        {
            return base.Channel.DeleteAsync(request);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.UserRole25Soap))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                result.Security.Mode = System.ServiceModel.BasicHttpSecurityMode.Transport;
                return result;
            }
            if ((endpointConfiguration == EndpointConfiguration.UserRole25Soap12))
            {
                System.ServiceModel.Channels.CustomBinding result = new System.ServiceModel.Channels.CustomBinding();
                System.ServiceModel.Channels.TextMessageEncodingBindingElement textBindingElement = new System.ServiceModel.Channels.TextMessageEncodingBindingElement();
                textBindingElement.MessageVersion = System.ServiceModel.Channels.MessageVersion.CreateVersion(System.ServiceModel.EnvelopeVersion.Soap12, System.ServiceModel.Channels.AddressingVersion.None);
                result.Elements.Add(textBindingElement);
                System.ServiceModel.Channels.HttpsTransportBindingElement httpsBindingElement = new System.ServiceModel.Channels.HttpsTransportBindingElement();
                httpsBindingElement.AllowCookies = true;
                httpsBindingElement.MaxBufferSize = int.MaxValue;
                httpsBindingElement.MaxReceivedMessageSize = int.MaxValue;
                result.Elements.Add(httpsBindingElement);
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.UserRole25Soap))
            {
                return new System.ServiceModel.EndpointAddress("https://ish.example.com/ISHWS/userrole25.asmx");
            }
            if ((endpointConfiguration == EndpointConfiguration.UserRole25Soap12))
            {
                return new System.ServiceModel.EndpointAddress("https://ish.example.com/ISHWS/userrole25.asmx");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        public enum EndpointConfiguration
        {
            
            UserRole25Soap,
            
            UserRole25Soap12,
        }
    }
}

