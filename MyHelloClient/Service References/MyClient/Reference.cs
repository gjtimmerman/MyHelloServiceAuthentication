﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyHelloClient.MyClient {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="MyClient.IHello")]
    public interface IHello {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHello/Hello", ReplyAction="http://tempuri.org/IHello/HelloResponse")]
        string Hello(string prompt);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IHelloChannel : MyHelloClient.MyClient.IHello, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class HelloClient : System.ServiceModel.ClientBase<MyHelloClient.MyClient.IHello>, MyHelloClient.MyClient.IHello {
        
        public HelloClient() {
        }
        
        public HelloClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public HelloClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public HelloClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public HelloClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string Hello(string prompt) {
            return base.Channel.Hello(prompt);
        }
    }
}
