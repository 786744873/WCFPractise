using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WcfServiceA
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host=new ServiceHost(typeof(Service1),new Uri("http://127.0.0.1:8088/Service1")))
            {
                host.Open();
                Console.WriteLine("服务A启动");
                Console.Read();
            }
        }
    }
}
