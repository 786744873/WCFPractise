using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Routing;

namespace WcfServiceRouteServer
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(RoutingService)))
            {
                host.Open();
                Console.WriteLine("路由服务已经开始 ");
                Console.Read();
            }
        }
    }
}
