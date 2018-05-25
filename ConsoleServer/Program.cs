using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace ConsoleServer
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(Service1),new Uri("http://127.0.0.1:6001/Service1")))
            {
                host.Open();

                Console.Write("服务已开启!");
                Console.ReadLine();
            }
        }
    }
}
