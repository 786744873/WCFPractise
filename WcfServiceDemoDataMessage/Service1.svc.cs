using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfServiceDemoDataMessage
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码、svc 和配置文件中的类名“Service1”。
    // 注意: 为了启动 WCF 测试客户端以测试此服务，请在解决方案资源管理器中选择 Service1.svc 或 Service1.svc.cs，然后开始调试。
    public class Service1 : IService1
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }


        public Person GetPerson()
        {
            //判断消息协定是否合法
            string mark = null;
            int index= OperationContext.Current.IncomingMessageHeaders.FindHeader("mark", "http://tempuri.org");
            if (index>=0)
            {
                mark = OperationContext.Current.IncomingMessageHeaders.GetHeader<string>(index).ToString();
            }
            if (mark.Equals("aaa"))
            {
                return new Person()
                {
                    ID = 123,
                    Name = "张三"
                };
            }

            return null;

            
        }
    }
}
