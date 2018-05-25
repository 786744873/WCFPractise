using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;

namespace WcfServiceDemoDataMessageClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Service1Client client = new Service1Client();


            #region 添加消息协定
            OperationContextScope scope = new OperationContextScope(client.InnerChannel);
            MessageHeader header = MessageHeader.CreateHeader("mark", "http://tempuri.org", "aaa");
            OperationContext.Current.OutgoingMessageHeaders.Add(header); 
            #endregion

            WcfServiceDemoDataMessage.Person p = client.GetPerson();
            Console.WriteLine(p.Name);

            client.Close();

            Console.ReadKey();
        }
    }
}
