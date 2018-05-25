using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseCertificationClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Service1Client client = new Service1Client();
            Console.WriteLine(client.GetCallerIdentity());
            Console.WriteLine(client.GetData(111));
            client.Close();
            Console.ReadLine();
        }
    }
}
