using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WcfServerByLiberaryClient
{
    class Program
    {
        static void Main(string[] aa)
        {
            #region 方法一
            //ClientHelper.DelUser();
            //Console.Read(); 
            #endregion

            #region 方法二
            var client = new RestClient();
            client.BaseUrl = "http://localhost:4025/UserService.svc/Task/del";
            var request = new RestRequest();
            request.AddHeader("Authorization", "aaa/124");

            #region 同步
            //IRestResponse response = client.Delete<User>(request);
            //Console.WriteLine(response.Content);
            #endregion

            #region 异步
            var result = client.DeleteAsync<User>(request, (obj, args) =>
                {
                    Console.WriteLine(obj.Data.Name);
                });
            #endregion


            Console.Read(); 
            #endregion
        }
    }
}
