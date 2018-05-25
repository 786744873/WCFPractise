using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfServiceDemoSingle
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码、svc 和配置文件中的类名“Service1”。
    // 注意: 为了启动 WCF 测试客户端以测试此服务，请在解决方案资源管理器中选择 Service1.svc 或 Service1.svc.cs，然后开始调试。

    //只有一个 System.ServiceModel.InstanceContext 对象用于所有传入呼叫，并且在调用后不回收。 如果服务对象不存在，则创建一个。
    [ServiceBehavior(InstanceContextMode= InstanceContextMode.Single)]
    public class Service1 : IService1
    {
        private int count = 0;
        public string GetData()
        {
            count++;
            return string.Format("You Getted: {0}", count);
        }

    }
}
