﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace SinglePerSession
{
    [ServiceContract]
    public interface ITestSvc
    {
        [OperationContract]
        string GetData();

    }
}
