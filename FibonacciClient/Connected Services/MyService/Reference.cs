﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FibonacciClient.MyService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="MyService.FibonacciSoap")]
    public interface FibonacciSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FibonacciSeries", ReplyAction="*")]
        int FibonacciSeries(int n);
        
        // CODEGEN : La génération du contrat de message depuis le nom d'élément xml de l'espace de noms http://tempuri.org/ n'est pas marqué nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ConvertXmlToJson", ReplyAction="*")]
        FibonacciClient.MyService.ConvertXmlToJsonResponse ConvertXmlToJson(FibonacciClient.MyService.ConvertXmlToJsonRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ConvertXmlToJsonRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ConvertXmlToJson", Namespace="http://tempuri.org/", Order=0)]
        public FibonacciClient.MyService.ConvertXmlToJsonRequestBody Body;
        
        public ConvertXmlToJsonRequest() {
        }
        
        public ConvertXmlToJsonRequest(FibonacciClient.MyService.ConvertXmlToJsonRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ConvertXmlToJsonRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string xml;
        
        public ConvertXmlToJsonRequestBody() {
        }
        
        public ConvertXmlToJsonRequestBody(string xml) {
            this.xml = xml;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ConvertXmlToJsonResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ConvertXmlToJsonResponse", Namespace="http://tempuri.org/", Order=0)]
        public FibonacciClient.MyService.ConvertXmlToJsonResponseBody Body;
        
        public ConvertXmlToJsonResponse() {
        }
        
        public ConvertXmlToJsonResponse(FibonacciClient.MyService.ConvertXmlToJsonResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ConvertXmlToJsonResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string ConvertXmlToJsonResult;
        
        public ConvertXmlToJsonResponseBody() {
        }
        
        public ConvertXmlToJsonResponseBody(string ConvertXmlToJsonResult) {
            this.ConvertXmlToJsonResult = ConvertXmlToJsonResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface FibonacciSoapChannel : FibonacciClient.MyService.FibonacciSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class FibonacciSoapClient : System.ServiceModel.ClientBase<FibonacciClient.MyService.FibonacciSoap>, FibonacciClient.MyService.FibonacciSoap {
        
        public FibonacciSoapClient() {
        }
        
        public FibonacciSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public FibonacciSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FibonacciSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FibonacciSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int FibonacciSeries(int n) {
            return base.Channel.FibonacciSeries(n);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        FibonacciClient.MyService.ConvertXmlToJsonResponse FibonacciClient.MyService.FibonacciSoap.ConvertXmlToJson(FibonacciClient.MyService.ConvertXmlToJsonRequest request) {
            return base.Channel.ConvertXmlToJson(request);
        }
        
        public string ConvertXmlToJson(string xml) {
            FibonacciClient.MyService.ConvertXmlToJsonRequest inValue = new FibonacciClient.MyService.ConvertXmlToJsonRequest();
            inValue.Body = new FibonacciClient.MyService.ConvertXmlToJsonRequestBody();
            inValue.Body.xml = xml;
            FibonacciClient.MyService.ConvertXmlToJsonResponse retVal = ((FibonacciClient.MyService.FibonacciSoap)(this)).ConvertXmlToJson(inValue);
            return retVal.Body.ConvertXmlToJsonResult;
        }
    }
}
