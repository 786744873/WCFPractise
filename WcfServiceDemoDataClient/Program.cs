using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WcfServiceDemoDataClient.ServiceReference1;

namespace WcfServiceDemoDataClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Service1Client client = new Service1Client();
            int n = 111;
            User user = client.GetData(ref n);
            Console.WriteLine(user.Name);
            Console.WriteLine(n );
            client.Close();

            Console.ReadKey();
        }
    }
}
