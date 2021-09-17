//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Trisoft.ISHRemote.Settings25ServiceReference
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="urn:trisoft.be:WebServices:InfoShare:Settings:2.5", ConfigurationName="Trisoft.ISHRemote.Settings25ServiceReference.Settings25Soap")]
    public interface Settings25Soap
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:trisoft.be:WebServices:InfoShare:Settings:2.5/GetTimeZone", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        Trisoft.ISHRemote.Settings25ServiceReference.GetTimeZoneResponse GetTimeZone(Trisoft.ISHRemote.Settings25ServiceReference.GetTimeZoneRequest request);
        
        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action="urn:trisoft.be:WebServices:InfoShare:Settings:2.5/GetTimeZone", ReplyAction="*")]
        System.Threading.Tasks.Task<Trisoft.ISHRemote.Settings25ServiceReference.GetTimeZoneResponse> GetTimeZoneAsync(Trisoft.ISHRemote.Settings25ServiceReference.GetTimeZoneRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:trisoft.be:WebServices:InfoShare:Settings:2.5/GetPossibleTargetStatuses", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        Trisoft.ISHRemote.Settings25ServiceReference.GetPossibleTargetStatusesResponse GetPossibleTargetStatuses(Trisoft.ISHRemote.Settings25ServiceReference.GetPossibleTargetStatusesRequest request);
        
        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action="urn:trisoft.be:WebServices:InfoShare:Settings:2.5/GetPossibleTargetStatuses", ReplyAction="*")]
        System.Threading.Tasks.Task<Trisoft.ISHRemote.Settings25ServiceReference.GetPossibleTargetStatusesResponse> GetPossibleTargetStatusesAsync(Trisoft.ISHRemote.Settings25ServiceReference.GetPossibleTargetStatusesRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:trisoft.be:WebServices:InfoShare:Settings:2.5/GetMetaData", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        Trisoft.ISHRemote.Settings25ServiceReference.GetMetaDataResponse GetMetaData(Trisoft.ISHRemote.Settings25ServiceReference.GetMetaDataRequest request);
        
        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action="urn:trisoft.be:WebServices:InfoShare:Settings:2.5/GetMetaData", ReplyAction="*")]
        System.Threading.Tasks.Task<Trisoft.ISHRemote.Settings25ServiceReference.GetMetaDataResponse> GetMetaDataAsync(Trisoft.ISHRemote.Settings25ServiceReference.GetMetaDataRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:trisoft.be:WebServices:InfoShare:Settings:2.5/SetMetaData3", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        Trisoft.ISHRemote.Settings25ServiceReference.SetMetaData3Response SetMetaData3(Trisoft.ISHRemote.Settings25ServiceReference.SetMetaData3Request request);
        
        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action="urn:trisoft.be:WebServices:InfoShare:Settings:2.5/SetMetaData3", ReplyAction="*")]
        System.Threading.Tasks.Task<Trisoft.ISHRemote.Settings25ServiceReference.SetMetaData3Response> SetMetaData3Async(Trisoft.ISHRemote.Settings25ServiceReference.SetMetaData3Request request);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:trisoft.be:WebServices:InfoShare:Settings:2.5/RetrieveFieldSetupByIshType", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        Trisoft.ISHRemote.Settings25ServiceReference.RetrieveFieldSetupByIshTypeResponse RetrieveFieldSetupByIshType(Trisoft.ISHRemote.Settings25ServiceReference.RetrieveFieldSetupByIshTypeRequest request);
        
        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action="urn:trisoft.be:WebServices:InfoShare:Settings:2.5/RetrieveFieldSetupByIshType", ReplyAction="*")]
        System.Threading.Tasks.Task<Trisoft.ISHRemote.Settings25ServiceReference.RetrieveFieldSetupByIshTypeResponse> RetrieveFieldSetupByIshTypeAsync(Trisoft.ISHRemote.Settings25ServiceReference.RetrieveFieldSetupByIshTypeRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:trisoft.be:WebServices:InfoShare:Settings:2.5/GetTranslationStatuses", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        Trisoft.ISHRemote.Settings25ServiceReference.GetTranslationStatusesResponse GetTranslationStatuses(Trisoft.ISHRemote.Settings25ServiceReference.GetTranslationStatusesRequest request);
        
        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action="urn:trisoft.be:WebServices:InfoShare:Settings:2.5/GetTranslationStatuses", ReplyAction="*")]
        System.Threading.Tasks.Task<Trisoft.ISHRemote.Settings25ServiceReference.GetTranslationStatusesResponse> GetTranslationStatusesAsync(Trisoft.ISHRemote.Settings25ServiceReference.GetTranslationStatusesRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetTimeZone", WrapperNamespace="urn:trisoft.be:WebServices:InfoShare:Settings:2.5", IsWrapped=true)]
    public partial class GetTimeZoneRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:trisoft.be:WebServices:InfoShare:Settings:2.5", Order=0)]
        public string psAuthContext;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:trisoft.be:WebServices:InfoShare:Settings:2.5", Order=1)]
        public string psOutXMLSettings;
        
        public GetTimeZoneRequest()
        {
        }
        
        public GetTimeZoneRequest(string psAuthContext, string psOutXMLSettings)
        {
            this.psAuthContext = psAuthContext;
            this.psOutXMLSettings = psOutXMLSettings;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetTimeZoneResponse", WrapperNamespace="urn:trisoft.be:WebServices:InfoShare:Settings:2.5", IsWrapped=true)]
    public partial class GetTimeZoneResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:trisoft.be:WebServices:InfoShare:Settings:2.5", Order=0)]
        public string GetTimeZoneResult;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:trisoft.be:WebServices:InfoShare:Settings:2.5", Order=1)]
        public string psAuthContext;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:trisoft.be:WebServices:InfoShare:Settings:2.5", Order=2)]
        public string psOutXMLSettings;
        
        public GetTimeZoneResponse()
        {
        }
        
        public GetTimeZoneResponse(string GetTimeZoneResult, string psAuthContext, string psOutXMLSettings)
        {
            this.GetTimeZoneResult = GetTimeZoneResult;
            this.psAuthContext = psAuthContext;
            this.psOutXMLSettings = psOutXMLSettings;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:trisoft.be:WebServices:InfoShare:Settings:2.5")]
    public enum eTargetStatus
    {
        
        /// <remarks/>
        ContentObject,
        
        /// <remarks/>
        Publication,
        
        /// <remarks/>
        TranslationJob,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetPossibleTargetStatuses", WrapperNamespace="urn:trisoft.be:WebServices:InfoShare:Settings:2.5", IsWrapped=true)]
    public partial class GetPossibleTargetStatusesRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:trisoft.be:WebServices:InfoShare:Settings:2.5", Order=0)]
        public string psAuthContext;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:trisoft.be:WebServices:InfoShare:Settings:2.5", Order=1)]
        public Trisoft.ISHRemote.Settings25ServiceReference.eTargetStatus peTargetStatus;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:trisoft.be:WebServices:InfoShare:Settings:2.5", Order=2)]
        public string psIshObjectType;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:trisoft.be:WebServices:InfoShare:Settings:2.5", Order=3)]
        public string[] pasUserRoles;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:trisoft.be:WebServices:InfoShare:Settings:2.5", Order=4)]
        public string psFromStatus;
        
        public GetPossibleTargetStatusesRequest()
        {
        }
        
        public GetPossibleTargetStatusesRequest(string psAuthContext, Trisoft.ISHRemote.Settings25ServiceReference.eTargetStatus peTargetStatus, string psIshObjectType, string[] pasUserRoles, string psFromStatus)
        {
            this.psAuthContext = psAuthContext;
            this.peTargetStatus = peTargetStatus;
            this.psIshObjectType = psIshObjectType;
            this.pasUserRoles = pasUserRoles;
            this.psFromStatus = psFromStatus;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetPossibleTargetStatusesResponse", WrapperNamespace="urn:trisoft.be:WebServices:InfoShare:Settings:2.5", IsWrapped=true)]
    public partial class GetPossibleTargetStatusesResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:trisoft.be:WebServices:InfoShare:Settings:2.5", Order=0)]
        public string GetPossibleTargetStatusesResult;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:trisoft.be:WebServices:InfoShare:Settings:2.5", Order=1)]
        public string psAuthContext;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:trisoft.be:WebServices:InfoShare:Settings:2.5", Order=2)]
        public string psOutXMLLovValueList;
        
        public GetPossibleTargetStatusesResponse()
        {
        }
        
        public GetPossibleTargetStatusesResponse(string GetPossibleTargetStatusesResult, string psAuthContext, string psOutXMLLovValueList)
        {
            this.GetPossibleTargetStatusesResult = GetPossibleTargetStatusesResult;
            this.psAuthContext = psAuthContext;
            this.psOutXMLLovValueList = psOutXMLLovValueList;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetMetaData", WrapperNamespace="urn:trisoft.be:WebServices:InfoShare:Settings:2.5", IsWrapped=true)]
    public partial class GetMetaDataRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:trisoft.be:WebServices:InfoShare:Settings:2.5", Order=0)]
        public string psAuthContext;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:trisoft.be:WebServices:InfoShare:Settings:2.5", Order=1)]
        public string psXMLRequestedMetaData;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:trisoft.be:WebServices:InfoShare:Settings:2.5", Order=2)]
        public string psOutXMLObjList;
        
        public GetMetaDataRequest()
        {
        }
        
        public GetMetaDataRequest(string psAuthContext, string psXMLRequestedMetaData, string psOutXMLObjList)
        {
            this.psAuthContext = psAuthContext;
            this.psXMLRequestedMetaData = psXMLRequestedMetaData;
            this.psOutXMLObjList = psOutXMLObjList;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetMetaDataResponse", WrapperNamespace="urn:trisoft.be:WebServices:InfoShare:Settings:2.5", IsWrapped=true)]
    public partial class GetMetaDataResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:trisoft.be:WebServices:InfoShare:Settings:2.5", Order=0)]
        public string GetMetaDataResult;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:trisoft.be:WebServices:InfoShare:Settings:2.5", Order=1)]
        public string psAuthContext;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:trisoft.be:WebServices:InfoShare:Settings:2.5", Order=2)]
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SetMetaData3", WrapperNamespace="urn:trisoft.be:WebServices:InfoShare:Settings:2.5", IsWrapped=true)]
    public partial class SetMetaData3Request
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:trisoft.be:WebServices:InfoShare:Settings:2.5", Order=0)]
        public string psAuthContext;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:trisoft.be:WebServices:InfoShare:Settings:2.5", Order=1)]
        public string psXMLMetaData;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:trisoft.be:WebServices:InfoShare:Settings:2.5", Order=2)]
        public string psXMLRequiredCurrentMetaData;
        
        public SetMetaData3Request()
        {
        }
        
        public SetMetaData3Request(string psAuthContext, string psXMLMetaData, string psXMLRequiredCurrentMetaData)
        {
            this.psAuthContext = psAuthContext;
            this.psXMLMetaData = psXMLMetaData;
            this.psXMLRequiredCurrentMetaData = psXMLRequiredCurrentMetaData;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SetMetaData3Response", WrapperNamespace="urn:trisoft.be:WebServices:InfoShare:Settings:2.5", IsWrapped=true)]
    public partial class SetMetaData3Response
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:trisoft.be:WebServices:InfoShare:Settings:2.5", Order=0)]
        public string SetMetaData3Result;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:trisoft.be:WebServices:InfoShare:Settings:2.5", Order=1)]
        public string psAuthContext;
        
        public SetMetaData3Response()
        {
        }
        
        public SetMetaData3Response(string SetMetaData3Result, string psAuthContext)
        {
            this.SetMetaData3Result = SetMetaData3Result;
            this.psAuthContext = psAuthContext;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="RetrieveFieldSetupByIshType", WrapperNamespace="urn:trisoft.be:WebServices:InfoShare:Settings:2.5", IsWrapped=true)]
    public partial class RetrieveFieldSetupByIshTypeRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:trisoft.be:WebServices:InfoShare:Settings:2.5", Order=0)]
        public string psAuthContext;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:trisoft.be:WebServices:InfoShare:Settings:2.5", Order=1)]
        public string[] pasIshTypes;
        
        public RetrieveFieldSetupByIshTypeRequest()
        {
        }
        
        public RetrieveFieldSetupByIshTypeRequest(string psAuthContext, string[] pasIshTypes)
        {
            this.psAuthContext = psAuthContext;
            this.pasIshTypes = pasIshTypes;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="RetrieveFieldSetupByIshTypeResponse", WrapperNamespace="urn:trisoft.be:WebServices:InfoShare:Settings:2.5", IsWrapped=true)]
    public partial class RetrieveFieldSetupByIshTypeResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:trisoft.be:WebServices:InfoShare:Settings:2.5", Order=0)]
        public string RetrieveFieldSetupByIshTypeResult;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:trisoft.be:WebServices:InfoShare:Settings:2.5", Order=1)]
        public string psAuthContext;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:trisoft.be:WebServices:InfoShare:Settings:2.5", Order=2)]
        public string psOutXMLFieldSetup;
        
        public RetrieveFieldSetupByIshTypeResponse()
        {
        }
        
        public RetrieveFieldSetupByIshTypeResponse(string RetrieveFieldSetupByIshTypeResult, string psAuthContext, string psOutXMLFieldSetup)
        {
            this.RetrieveFieldSetupByIshTypeResult = RetrieveFieldSetupByIshTypeResult;
            this.psAuthContext = psAuthContext;
            this.psOutXMLFieldSetup = psOutXMLFieldSetup;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetTranslationStatuses", WrapperNamespace="urn:trisoft.be:WebServices:InfoShare:Settings:2.5", IsWrapped=true)]
    public partial class GetTranslationStatusesRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:trisoft.be:WebServices:InfoShare:Settings:2.5", Order=0)]
        public string psAuthContext;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:trisoft.be:WebServices:InfoShare:Settings:2.5", Order=1)]
        public string psIshType;
        
        public GetTranslationStatusesRequest()
        {
        }
        
        public GetTranslationStatusesRequest(string psAuthContext, string psIshType)
        {
            this.psAuthContext = psAuthContext;
            this.psIshType = psIshType;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetTranslationStatusesResponse", WrapperNamespace="urn:trisoft.be:WebServices:InfoShare:Settings:2.5", IsWrapped=true)]
    public partial class GetTranslationStatusesResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:trisoft.be:WebServices:InfoShare:Settings:2.5", Order=0)]
        public string GetTranslationStatusesResult;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:trisoft.be:WebServices:InfoShare:Settings:2.5", Order=1)]
        public string psAuthContext;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:trisoft.be:WebServices:InfoShare:Settings:2.5", Order=2)]
        public string psOutXMLTranslationStatuses;
        
        public GetTranslationStatusesResponse()
        {
        }
        
        public GetTranslationStatusesResponse(string GetTranslationStatusesResult, string psAuthContext, string psOutXMLTranslationStatuses)
        {
            this.GetTranslationStatusesResult = GetTranslationStatusesResult;
            this.psAuthContext = psAuthContext;
            this.psOutXMLTranslationStatuses = psOutXMLTranslationStatuses;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    public interface Settings25SoapChannel : Trisoft.ISHRemote.Settings25ServiceReference.Settings25Soap, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    public partial class Settings25SoapClient : System.ServiceModel.ClientBase<Trisoft.ISHRemote.Settings25ServiceReference.Settings25Soap>, Trisoft.ISHRemote.Settings25ServiceReference.Settings25Soap
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public Settings25SoapClient(EndpointConfiguration endpointConfiguration) : 
                base(Settings25SoapClient.GetBindingForEndpoint(endpointConfiguration), Settings25SoapClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public Settings25SoapClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(Settings25SoapClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public Settings25SoapClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(Settings25SoapClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public Settings25SoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Trisoft.ISHRemote.Settings25ServiceReference.GetTimeZoneResponse Trisoft.ISHRemote.Settings25ServiceReference.Settings25Soap.GetTimeZone(Trisoft.ISHRemote.Settings25ServiceReference.GetTimeZoneRequest request)
        {
            return base.Channel.GetTimeZone(request);
        }
        
        public string GetTimeZone(ref string psAuthContext, ref string psOutXMLSettings)
        {
            Trisoft.ISHRemote.Settings25ServiceReference.GetTimeZoneRequest inValue = new Trisoft.ISHRemote.Settings25ServiceReference.GetTimeZoneRequest();
            inValue.psAuthContext = psAuthContext;
            inValue.psOutXMLSettings = psOutXMLSettings;
            Trisoft.ISHRemote.Settings25ServiceReference.GetTimeZoneResponse retVal = ((Trisoft.ISHRemote.Settings25ServiceReference.Settings25Soap)(this)).GetTimeZone(inValue);
            psAuthContext = retVal.psAuthContext;
            psOutXMLSettings = retVal.psOutXMLSettings;
            return retVal.GetTimeZoneResult;
        }
        
        public System.Threading.Tasks.Task<Trisoft.ISHRemote.Settings25ServiceReference.GetTimeZoneResponse> GetTimeZoneAsync(Trisoft.ISHRemote.Settings25ServiceReference.GetTimeZoneRequest request)
        {
            return base.Channel.GetTimeZoneAsync(request);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Trisoft.ISHRemote.Settings25ServiceReference.GetPossibleTargetStatusesResponse Trisoft.ISHRemote.Settings25ServiceReference.Settings25Soap.GetPossibleTargetStatuses(Trisoft.ISHRemote.Settings25ServiceReference.GetPossibleTargetStatusesRequest request)
        {
            return base.Channel.GetPossibleTargetStatuses(request);
        }
        
        public string GetPossibleTargetStatuses(ref string psAuthContext, Trisoft.ISHRemote.Settings25ServiceReference.eTargetStatus peTargetStatus, string psIshObjectType, string[] pasUserRoles, string psFromStatus, out string psOutXMLLovValueList)
        {
            Trisoft.ISHRemote.Settings25ServiceReference.GetPossibleTargetStatusesRequest inValue = new Trisoft.ISHRemote.Settings25ServiceReference.GetPossibleTargetStatusesRequest();
            inValue.psAuthContext = psAuthContext;
            inValue.peTargetStatus = peTargetStatus;
            inValue.psIshObjectType = psIshObjectType;
            inValue.pasUserRoles = pasUserRoles;
            inValue.psFromStatus = psFromStatus;
            Trisoft.ISHRemote.Settings25ServiceReference.GetPossibleTargetStatusesResponse retVal = ((Trisoft.ISHRemote.Settings25ServiceReference.Settings25Soap)(this)).GetPossibleTargetStatuses(inValue);
            psAuthContext = retVal.psAuthContext;
            psOutXMLLovValueList = retVal.psOutXMLLovValueList;
            return retVal.GetPossibleTargetStatusesResult;
        }
        
        public System.Threading.Tasks.Task<Trisoft.ISHRemote.Settings25ServiceReference.GetPossibleTargetStatusesResponse> GetPossibleTargetStatusesAsync(Trisoft.ISHRemote.Settings25ServiceReference.GetPossibleTargetStatusesRequest request)
        {
            return base.Channel.GetPossibleTargetStatusesAsync(request);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Trisoft.ISHRemote.Settings25ServiceReference.GetMetaDataResponse Trisoft.ISHRemote.Settings25ServiceReference.Settings25Soap.GetMetaData(Trisoft.ISHRemote.Settings25ServiceReference.GetMetaDataRequest request)
        {
            return base.Channel.GetMetaData(request);
        }
        
        public string GetMetaData(ref string psAuthContext, string psXMLRequestedMetaData, ref string psOutXMLObjList)
        {
            Trisoft.ISHRemote.Settings25ServiceReference.GetMetaDataRequest inValue = new Trisoft.ISHRemote.Settings25ServiceReference.GetMetaDataRequest();
            inValue.psAuthContext = psAuthContext;
            inValue.psXMLRequestedMetaData = psXMLRequestedMetaData;
            inValue.psOutXMLObjList = psOutXMLObjList;
            Trisoft.ISHRemote.Settings25ServiceReference.GetMetaDataResponse retVal = ((Trisoft.ISHRemote.Settings25ServiceReference.Settings25Soap)(this)).GetMetaData(inValue);
            psAuthContext = retVal.psAuthContext;
            psOutXMLObjList = retVal.psOutXMLObjList;
            return retVal.GetMetaDataResult;
        }
        
        public System.Threading.Tasks.Task<Trisoft.ISHRemote.Settings25ServiceReference.GetMetaDataResponse> GetMetaDataAsync(Trisoft.ISHRemote.Settings25ServiceReference.GetMetaDataRequest request)
        {
            return base.Channel.GetMetaDataAsync(request);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Trisoft.ISHRemote.Settings25ServiceReference.SetMetaData3Response Trisoft.ISHRemote.Settings25ServiceReference.Settings25Soap.SetMetaData3(Trisoft.ISHRemote.Settings25ServiceReference.SetMetaData3Request request)
        {
            return base.Channel.SetMetaData3(request);
        }
        
        public string SetMetaData3(ref string psAuthContext, string psXMLMetaData, string psXMLRequiredCurrentMetaData)
        {
            Trisoft.ISHRemote.Settings25ServiceReference.SetMetaData3Request inValue = new Trisoft.ISHRemote.Settings25ServiceReference.SetMetaData3Request();
            inValue.psAuthContext = psAuthContext;
            inValue.psXMLMetaData = psXMLMetaData;
            inValue.psXMLRequiredCurrentMetaData = psXMLRequiredCurrentMetaData;
            Trisoft.ISHRemote.Settings25ServiceReference.SetMetaData3Response retVal = ((Trisoft.ISHRemote.Settings25ServiceReference.Settings25Soap)(this)).SetMetaData3(inValue);
            psAuthContext = retVal.psAuthContext;
            return retVal.SetMetaData3Result;
        }
        
        public System.Threading.Tasks.Task<Trisoft.ISHRemote.Settings25ServiceReference.SetMetaData3Response> SetMetaData3Async(Trisoft.ISHRemote.Settings25ServiceReference.SetMetaData3Request request)
        {
            return base.Channel.SetMetaData3Async(request);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Trisoft.ISHRemote.Settings25ServiceReference.RetrieveFieldSetupByIshTypeResponse Trisoft.ISHRemote.Settings25ServiceReference.Settings25Soap.RetrieveFieldSetupByIshType(Trisoft.ISHRemote.Settings25ServiceReference.RetrieveFieldSetupByIshTypeRequest request)
        {
            return base.Channel.RetrieveFieldSetupByIshType(request);
        }
        
        public string RetrieveFieldSetupByIshType(ref string psAuthContext, string[] pasIshTypes, out string psOutXMLFieldSetup)
        {
            Trisoft.ISHRemote.Settings25ServiceReference.RetrieveFieldSetupByIshTypeRequest inValue = new Trisoft.ISHRemote.Settings25ServiceReference.RetrieveFieldSetupByIshTypeRequest();
            inValue.psAuthContext = psAuthContext;
            inValue.pasIshTypes = pasIshTypes;
            Trisoft.ISHRemote.Settings25ServiceReference.RetrieveFieldSetupByIshTypeResponse retVal = ((Trisoft.ISHRemote.Settings25ServiceReference.Settings25Soap)(this)).RetrieveFieldSetupByIshType(inValue);
            psAuthContext = retVal.psAuthContext;
            psOutXMLFieldSetup = retVal.psOutXMLFieldSetup;
            return retVal.RetrieveFieldSetupByIshTypeResult;
        }
        
        public System.Threading.Tasks.Task<Trisoft.ISHRemote.Settings25ServiceReference.RetrieveFieldSetupByIshTypeResponse> RetrieveFieldSetupByIshTypeAsync(Trisoft.ISHRemote.Settings25ServiceReference.RetrieveFieldSetupByIshTypeRequest request)
        {
            return base.Channel.RetrieveFieldSetupByIshTypeAsync(request);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Trisoft.ISHRemote.Settings25ServiceReference.GetTranslationStatusesResponse Trisoft.ISHRemote.Settings25ServiceReference.Settings25Soap.GetTranslationStatuses(Trisoft.ISHRemote.Settings25ServiceReference.GetTranslationStatusesRequest request)
        {
            return base.Channel.GetTranslationStatuses(request);
        }
        
        public string GetTranslationStatuses(ref string psAuthContext, string psIshType, out string psOutXMLTranslationStatuses)
        {
            Trisoft.ISHRemote.Settings25ServiceReference.GetTranslationStatusesRequest inValue = new Trisoft.ISHRemote.Settings25ServiceReference.GetTranslationStatusesRequest();
            inValue.psAuthContext = psAuthContext;
            inValue.psIshType = psIshType;
            Trisoft.ISHRemote.Settings25ServiceReference.GetTranslationStatusesResponse retVal = ((Trisoft.ISHRemote.Settings25ServiceReference.Settings25Soap)(this)).GetTranslationStatuses(inValue);
            psAuthContext = retVal.psAuthContext;
            psOutXMLTranslationStatuses = retVal.psOutXMLTranslationStatuses;
            return retVal.GetTranslationStatusesResult;
        }
        
        public System.Threading.Tasks.Task<Trisoft.ISHRemote.Settings25ServiceReference.GetTranslationStatusesResponse> GetTranslationStatusesAsync(Trisoft.ISHRemote.Settings25ServiceReference.GetTranslationStatusesRequest request)
        {
            return base.Channel.GetTranslationStatusesAsync(request);
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
            if ((endpointConfiguration == EndpointConfiguration.Settings25Soap))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                result.Security.Mode = System.ServiceModel.BasicHttpSecurityMode.Transport;
                return result;
            }
            if ((endpointConfiguration == EndpointConfiguration.Settings25Soap12))
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
            if ((endpointConfiguration == EndpointConfiguration.Settings25Soap))
            {
                return new System.ServiceModel.EndpointAddress("https://ish.example.com/ISHWS/settings25.asmx");
            }
            if ((endpointConfiguration == EndpointConfiguration.Settings25Soap12))
            {
                return new System.ServiceModel.EndpointAddress("https://ish.example.com/ISHWS/settings25.asmx");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        public enum EndpointConfiguration
        {
            
            Settings25Soap,
            
            Settings25Soap12,
        }
    }
}

