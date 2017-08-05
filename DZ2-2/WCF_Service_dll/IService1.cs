using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_Service_dll
{
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        List<string> getContent(string path);
    }
}
