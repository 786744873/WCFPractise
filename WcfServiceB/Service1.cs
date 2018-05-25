using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WcfServiceB
{
    public class Service1 : IService1
    {
        public string GetData()
        {
            Console.WriteLine("我是服务B");
            return "从B服务端返回的值";
        }
    }
}
