using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SinglePerSession
{
    public class TestSvc : ITestSvc
    {

        TestSvc()
        {
            Console.WriteLine("{0} : 在线程上创建一个新实例", DateTime.Now.Ticks);
        }
        public string GetData()
        {
            Console.WriteLine("{0} : 在线程上调用方法 {1} ", DateTime.Now.Ticks, Thread.CurrentThread.ManagedThreadId);
            return "Test";
        }

    }
}
