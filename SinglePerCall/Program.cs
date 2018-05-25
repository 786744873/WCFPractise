using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;

namespace SinglePerCall
{
    class Program
    {
        static void Main(string[] args)
        {
            // .\SvcUtil.exe /d:D\ /a /o:D:\Clients.cs /config: D:\App.config net.tcp://localhost:8888
            using (ServiceHost host = new ServiceHost(typeof(TestSvc), new Uri("net.tcp://localhost:8888")))
            {
                ServiceEndpoint endpoint =host.AddServiceEndpoint(typeof(ITestSvc), new NetTcpBinding(), "TestService");
                endpoint.Contract.SessionMode = SessionMode.Allowed;//会话

                ServiceMetadataBehavior metadataBehavior = new ServiceMetadataBehavior();
                host.Description.Behaviors.Add(metadataBehavior);

                ServiceBehaviorAttribute serviceBehaviorAttribute = host.Description.Behaviors.Find<ServiceBehaviorAttribute>();
                if (serviceBehaviorAttribute==null)
                {
                    serviceBehaviorAttribute = new ServiceBehaviorAttribute();
                }
                serviceBehaviorAttribute.ConcurrencyMode = ConcurrencyMode.Single;//并发
                serviceBehaviorAttribute.InstanceContextMode = InstanceContextMode.PerCall;

                host.AddServiceEndpoint(typeof(IMetadataExchange), MetadataExchangeBindings.CreateMexTcpBinding(), "mex");

                host.Open();
                Console.WriteLine("服务开始。。。");
                Console.ReadLine();
            }
        }
    }
}
