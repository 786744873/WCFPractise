using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WcfServiceDemoTwoConsoleClient.ServiceReference1;

namespace WcfServiceDemoTwoConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Service1Client client = new Service1Client();
            client.GetData(1111);
            client.Close();

            Console.ReadKey();
        }
    }
}
