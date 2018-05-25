using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace SinglePerCall
{
    [ServiceContract]
    public interface ITestSvc
    {
        [OperationContract]
        string GetData();

    }
}
