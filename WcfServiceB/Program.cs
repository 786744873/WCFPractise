using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WcfServiceB
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(Service1), new Uri("http://127.0.0.1:8089/Service1")))
            {
                host.Open();
                Console.WriteLine("服务B启动");
                Console.Read();
            }
        }
    }
}
