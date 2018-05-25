using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultiplePerSession
{
    public class TestSvc : ITestSvc
    {
        object locak = new object();
        private int n = 0;
        TestSvc()
        {
            Console.WriteLine("{0} : 在线程上创建一个新实例", DateTime.Now.Ticks);
        }
        public string GetData()
        {
            string str = "Test";
            Console.WriteLine("{0} : 在线程上调用方法 {1} ", DateTime.Now.Ticks, Thread.CurrentThread.ManagedThreadId);
            lock (locak)
            {
                n++;
                str += ":" + n.ToString();
            }
            return str;
        }

    }
}
