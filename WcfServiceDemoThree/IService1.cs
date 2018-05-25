using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfServiceDemoThree
{
    // SessionMode需要会话绑定
    // CallbackContract定义返回的类型
    [ServiceContract(Namespace="",SessionMode=SessionMode.Required,CallbackContract=typeof(IService1CallBack))]
    public interface IService1
    {

        [OperationContract(IsOneWay=true)]
        void SendToServer(int value);

        [OperationContract(IsOneWay = true)]
        void SendToServer2(int value);

    }


    //IService1的回调
    public interface IService1CallBack
    {
        [OperationContract(IsOneWay = true)]
        void SendToClient(int value);
    }
}
