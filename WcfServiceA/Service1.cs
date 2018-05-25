using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WcfServiceA
{
    public class Service1 : IService1
    {
        public string GetData()
        {
            Console.WriteLine("我是服务A");
            return "从A服务端返回的值";
        }
    }
}
