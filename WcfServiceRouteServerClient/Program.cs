using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WcfServiceRouteServerClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Service1Client svc = new Service1Client("service1Endpoint");
            Console.WriteLine(svc.GetData());
            svc.Close();
            Console.Read();
        }
    }
}
