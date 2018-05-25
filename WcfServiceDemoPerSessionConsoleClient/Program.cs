using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WcfServiceDemoPerSessionConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Service1Client client = new Service1Client();
            Console.WriteLine(client.GetData());
            Console.WriteLine(client.GetData());
            client.Close();

            Service1Client client2 = new Service1Client();
            Console.WriteLine(client2.GetData());
            Console.WriteLine(client2.GetData());
            client2.Close();


            Console.Read();
        }
    }
}
