﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApp1.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService")]
    public interface IService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/Encrypt", ReplyAction="http://tempuri.org/IService/EncryptResponse")]
        string Encrypt(string text);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/Encrypt", ReplyAction="http://tempuri.org/IService/EncryptResponse")]
        System.Threading.Tasks.Task<string> EncryptAsync(string text);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/Decrypt", ReplyAction="http://tempuri.org/IService/DecryptResponse")]
        string Decrypt(string text);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/Decrypt", ReplyAction="http://tempuri.org/IService/DecryptResponse")]
        System.Threading.Tasks.Task<string> DecryptAsync(string text);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceChannel : WindowsFormsApp1.ServiceReference1.IService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceClient : System.ServiceModel.ClientBase<WindowsFormsApp1.ServiceReference1.IService>, WindowsFormsApp1.ServiceReference1.IService {
        
        public ServiceClient() {
        }
        
        public ServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string Encrypt(string text) {
            return base.Channel.Encrypt(text);
        }
        
        public System.Threading.Tasks.Task<string> EncryptAsync(string text) {
            return base.Channel.EncryptAsync(text);
        }
        
        public string Decrypt(string text) {
            return base.Channel.Decrypt(text);
        }
        
        public System.Threading.Tasks.Task<string> DecryptAsync(string text) {
            return base.Channel.DecryptAsync(text);
        }
    }
}
