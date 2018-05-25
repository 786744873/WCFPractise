using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WcfServiceDemoOneConsoleClient.ServiceReference1;

namespace WcfServiceDemoOneConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Service1Client client = new Service1Client();
            Console.WriteLine(client.GetData(1111));
            client.Close();

            Console.ReadKey();
        }
    }
}
