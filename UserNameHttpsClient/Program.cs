using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserNameHttpsClient
{
    class Program
    {
        static void Main(string[] args)
        {
            IserviceClient client = new IserviceClient("Username");
            try
            {
                client.ClientCredentials.UserName.UserName = "aaa";
                client.ClientCredentials.UserName.Password = "aaa";
                Console.WriteLine(client.Say());
                client.Close();
            }
            catch (Exception err)
            {
                Console.WriteLine(err);
            }

            Console.ReadKey();
        }
    }
}
