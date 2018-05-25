using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WcfServiceB
{
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        string GetData();
    }
}
