using Microsoft.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WcfServerByLiberaryClient
{
    public class ClientHelper
    {
        private readonly static string baseUri = "http://localhost:4025/UserService.svc";

        public static void GetUser()
        {
            HttpClient client = new HttpClient();
            var strUri = baseUri + "/Task/123";
            var response= client.Get(strUri);
            response.EnsureStatusIsSuccessful();
            var data= response.Content.ReadAsString();
            Console.WriteLine(data);
        }

        public static void AddUser()
        {
            HttpClient client = new HttpClient();
            var strUri = baseUri + "/Task/add";
            User u = new User { Age = 88, ID = 18, Name = "jiangziya" };
            var response = client.Post(strUri, CreateContent(u));
            response.EnsureStatusIsSuccessful();
            var data = response.Content.ReadAsString();
            Console.WriteLine(data);
        }

        public static void UpdateUser()
        {
            HttpClient client = new HttpClient();
            var strUri = baseUri + "/Task/up";
            User u = new User { Age = 88, ID = 18, Name = "jiangziya" };
            var response = client.Put(strUri, CreateContent(u));
            response.EnsureStatusIsSuccessful();
            var data = response.Content.ReadAsString();
            Console.WriteLine(data);
        }

        public static void DelUser()
        {
            HttpClient client = new HttpClient();
            var strUri = baseUri + "/Task/del";
            client.DefaultHeaders.Add("Authorization", "aaa/123");//鉴权
            var response = client.Delete(strUri);
            response.EnsureStatusIsSuccessful();
            var data = response.Content.ReadAsString();
            Console.WriteLine(data);
        }

        public static HttpContent CreateContent(User u)
        {
            var con = JsonConvert.SerializeObject(u);
            var data = System.Text.Encoding.UTF8.GetBytes(con);
            return HttpContent.Create(data, "application/json");
        }
    }
}
