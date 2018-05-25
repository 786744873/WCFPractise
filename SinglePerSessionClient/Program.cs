using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinglePerSessionClient
{
    class Program
    {
        static void Main(string[] args)
        {
            TestSvcClient proxy = new TestSvcClient();
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("{0}: 开始调用服务方法", DateTime.Now.Ticks);
                proxy.BeginGetData(GetFruitNameCallBack, proxy);
            }

            Console.ReadLine();
        }

        static void GetFruitNameCallBack(IAsyncResult ar)
        {
            string name = ((TestSvcClient)ar.AsyncState).EndGetData(ar);
            Console.WriteLine("{0}: 最终结果:{1} ", DateTime.Now.Ticks, name);
        }
    }
}
