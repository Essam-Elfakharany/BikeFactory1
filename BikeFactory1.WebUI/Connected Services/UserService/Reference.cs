﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BikeFactory1.WebUI.UserService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="UserService.UserServiceSoap")]
    public interface UserServiceSoap {
        
        // CODEGEN: Generating message contract since element name userName from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/UserAndPasswordAreValid", ReplyAction="*")]
        BikeFactory1.WebUI.UserService.UserAndPasswordAreValidResponse UserAndPasswordAreValid(BikeFactory1.WebUI.UserService.UserAndPasswordAreValidRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/UserAndPasswordAreValid", ReplyAction="*")]
        System.Threading.Tasks.Task<BikeFactory1.WebUI.UserService.UserAndPasswordAreValidResponse> UserAndPasswordAreValidAsync(BikeFactory1.WebUI.UserService.UserAndPasswordAreValidRequest request);
        
        // CODEGEN: Generating message contract since element name userName from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Register", ReplyAction="*")]
        BikeFactory1.WebUI.UserService.RegisterResponse Register(BikeFactory1.WebUI.UserService.RegisterRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Register", ReplyAction="*")]
        System.Threading.Tasks.Task<BikeFactory1.WebUI.UserService.RegisterResponse> RegisterAsync(BikeFactory1.WebUI.UserService.RegisterRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class UserAndPasswordAreValidRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="UserAndPasswordAreValid", Namespace="http://tempuri.org/", Order=0)]
        public BikeFactory1.WebUI.UserService.UserAndPasswordAreValidRequestBody Body;
        
        public UserAndPasswordAreValidRequest() {
        }
        
        public UserAndPasswordAreValidRequest(BikeFactory1.WebUI.UserService.UserAndPasswordAreValidRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class UserAndPasswordAreValidRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string userName;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string password;
        
        public UserAndPasswordAreValidRequestBody() {
        }
        
        public UserAndPasswordAreValidRequestBody(string userName, string password) {
            this.userName = userName;
            this.password = password;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class UserAndPasswordAreValidResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="UserAndPasswordAreValidResponse", Namespace="http://tempuri.org/", Order=0)]
        public BikeFactory1.WebUI.UserService.UserAndPasswordAreValidResponseBody Body;
        
        public UserAndPasswordAreValidResponse() {
        }
        
        public UserAndPasswordAreValidResponse(BikeFactory1.WebUI.UserService.UserAndPasswordAreValidResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class UserAndPasswordAreValidResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public bool UserAndPasswordAreValidResult;
        
        public UserAndPasswordAreValidResponseBody() {
        }
        
        public UserAndPasswordAreValidResponseBody(bool UserAndPasswordAreValidResult) {
            this.UserAndPasswordAreValidResult = UserAndPasswordAreValidResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class RegisterRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Register", Namespace="http://tempuri.org/", Order=0)]
        public BikeFactory1.WebUI.UserService.RegisterRequestBody Body;
        
        public RegisterRequest() {
        }
        
        public RegisterRequest(BikeFactory1.WebUI.UserService.RegisterRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class RegisterRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string userName;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string password;
        
        public RegisterRequestBody() {
        }
        
        public RegisterRequestBody(string userName, string password) {
            this.userName = userName;
            this.password = password;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class RegisterResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="RegisterResponse", Namespace="http://tempuri.org/", Order=0)]
        public BikeFactory1.WebUI.UserService.RegisterResponseBody Body;
        
        public RegisterResponse() {
        }
        
        public RegisterResponse(BikeFactory1.WebUI.UserService.RegisterResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class RegisterResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public bool RegisterResult;
        
        public RegisterResponseBody() {
        }
        
        public RegisterResponseBody(bool RegisterResult) {
            this.RegisterResult = RegisterResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface UserServiceSoapChannel : BikeFactory1.WebUI.UserService.UserServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class UserServiceSoapClient : System.ServiceModel.ClientBase<BikeFactory1.WebUI.UserService.UserServiceSoap>, BikeFactory1.WebUI.UserService.UserServiceSoap {
        
        public UserServiceSoapClient() {
        }
        
        public UserServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public UserServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UserServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UserServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        BikeFactory1.WebUI.UserService.UserAndPasswordAreValidResponse BikeFactory1.WebUI.UserService.UserServiceSoap.UserAndPasswordAreValid(BikeFactory1.WebUI.UserService.UserAndPasswordAreValidRequest request) {
            return base.Channel.UserAndPasswordAreValid(request);
        }
        
        public bool UserAndPasswordAreValid(string userName, string password) {
            BikeFactory1.WebUI.UserService.UserAndPasswordAreValidRequest inValue = new BikeFactory1.WebUI.UserService.UserAndPasswordAreValidRequest();
            inValue.Body = new BikeFactory1.WebUI.UserService.UserAndPasswordAreValidRequestBody();
            inValue.Body.userName = userName;
            inValue.Body.password = password;
            BikeFactory1.WebUI.UserService.UserAndPasswordAreValidResponse retVal = ((BikeFactory1.WebUI.UserService.UserServiceSoap)(this)).UserAndPasswordAreValid(inValue);
            return retVal.Body.UserAndPasswordAreValidResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<BikeFactory1.WebUI.UserService.UserAndPasswordAreValidResponse> BikeFactory1.WebUI.UserService.UserServiceSoap.UserAndPasswordAreValidAsync(BikeFactory1.WebUI.UserService.UserAndPasswordAreValidRequest request) {
            return base.Channel.UserAndPasswordAreValidAsync(request);
        }
        
        public System.Threading.Tasks.Task<BikeFactory1.WebUI.UserService.UserAndPasswordAreValidResponse> UserAndPasswordAreValidAsync(string userName, string password) {
            BikeFactory1.WebUI.UserService.UserAndPasswordAreValidRequest inValue = new BikeFactory1.WebUI.UserService.UserAndPasswordAreValidRequest();
            inValue.Body = new BikeFactory1.WebUI.UserService.UserAndPasswordAreValidRequestBody();
            inValue.Body.userName = userName;
            inValue.Body.password = password;
            return ((BikeFactory1.WebUI.UserService.UserServiceSoap)(this)).UserAndPasswordAreValidAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        BikeFactory1.WebUI.UserService.RegisterResponse BikeFactory1.WebUI.UserService.UserServiceSoap.Register(BikeFactory1.WebUI.UserService.RegisterRequest request) {
            return base.Channel.Register(request);
        }
        
        public bool Register(string userName, string password) {
            BikeFactory1.WebUI.UserService.RegisterRequest inValue = new BikeFactory1.WebUI.UserService.RegisterRequest();
            inValue.Body = new BikeFactory1.WebUI.UserService.RegisterRequestBody();
            inValue.Body.userName = userName;
            inValue.Body.password = password;
            BikeFactory1.WebUI.UserService.RegisterResponse retVal = ((BikeFactory1.WebUI.UserService.UserServiceSoap)(this)).Register(inValue);
            return retVal.Body.RegisterResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<BikeFactory1.WebUI.UserService.RegisterResponse> BikeFactory1.WebUI.UserService.UserServiceSoap.RegisterAsync(BikeFactory1.WebUI.UserService.RegisterRequest request) {
            return base.Channel.RegisterAsync(request);
        }
        
        public System.Threading.Tasks.Task<BikeFactory1.WebUI.UserService.RegisterResponse> RegisterAsync(string userName, string password) {
            BikeFactory1.WebUI.UserService.RegisterRequest inValue = new BikeFactory1.WebUI.UserService.RegisterRequest();
            inValue.Body = new BikeFactory1.WebUI.UserService.RegisterRequestBody();
            inValue.Body.userName = userName;
            inValue.Body.password = password;
            return ((BikeFactory1.WebUI.UserService.UserServiceSoap)(this)).RegisterAsync(inValue);
        }
    }
}
