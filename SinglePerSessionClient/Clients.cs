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
[System.ServiceModel.ServiceContractAttribute(ConfigurationName="ITestSvc")]
public interface ITestSvc
{
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITestSvc/GetData", ReplyAction="http://tempuri.org/ITestSvc/GetDataResponse")]
    string GetData();
    
    [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/ITestSvc/GetData", ReplyAction="http://tempuri.org/ITestSvc/GetDataResponse")]
    System.IAsyncResult BeginGetData(System.AsyncCallback callback, object asyncState);
    
    string EndGetData(System.IAsyncResult result);
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public interface ITestSvcChannel : ITestSvc, System.ServiceModel.IClientChannel
{
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public partial class TestSvcClient : System.ServiceModel.ClientBase<ITestSvc>, ITestSvc
{
    
    public TestSvcClient()
    {
    }
    
    public TestSvcClient(string endpointConfigurationName) : 
            base(endpointConfigurationName)
    {
    }
    
    public TestSvcClient(string endpointConfigurationName, string remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public TestSvcClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public TestSvcClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(binding, remoteAddress)
    {
    }
    
    public string GetData()
    {
        return base.Channel.GetData();
    }
    
    public System.IAsyncResult BeginGetData(System.AsyncCallback callback, object asyncState)
    {
        return base.Channel.BeginGetData(callback, asyncState);
    }
    
    public string EndGetData(System.IAsyncResult result)
    {
        return base.Channel.EndGetData(result);
    }
}
