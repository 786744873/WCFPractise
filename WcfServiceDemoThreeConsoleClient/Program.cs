using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using WcfServiceDemoThreeConsoleClient.ServiceReference1;

namespace WcfServiceDemoThreeConsoleClient
{
    class Program
    {
        [ServiceBehavior(InstanceContextMode= InstanceContextMode.PerSession)]
        public class CallBachHandle : IService1Callback
        {
            public void SendToClient(int value)
            {
                Console.WriteLine(value);
            }
        }

        static void Main(string[] args)
        {
            //创建回调的上下文实例
            InstanceContext instance = new InstanceContext(new CallBachHandle());

            Service1Client client = new Service1Client(instance);

            client.SendToServer(1);
            client.SendToServer2(1); 
      

            Console.Read();
            client.Close();
            Console.Read();

        }
    }
}
