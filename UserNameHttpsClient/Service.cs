﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------



[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ServiceModel.ServiceContractAttribute(ConfigurationName="Iservice")]
public interface Iservice
{
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Iservice/Say", ReplyAction="http://tempuri.org/Iservice/SayResponse")]
    string Say();
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Iservice/Say", ReplyAction="http://tempuri.org/Iservice/SayResponse")]
    System.Threading.Tasks.Task<string> SayAsync();
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public interface IserviceChannel : Iservice, System.ServiceModel.IClientChannel
{
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public partial class IserviceClient : System.ServiceModel.ClientBase<Iservice>, Iservice
{
    
    public IserviceClient()
    {
    }
    
    public IserviceClient(string endpointConfigurationName) : 
            base(endpointConfigurationName)
    {
    }
    
    public IserviceClient(string endpointConfigurationName, string remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public IserviceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public IserviceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(binding, remoteAddress)
    {
    }
    
    public string Say()
    {
        return base.Channel.Say();
    }
    
    public System.Threading.Tasks.Task<string> SayAsync()
    {
        return base.Channel.SayAsync();
    }
}