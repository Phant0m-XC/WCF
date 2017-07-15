using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace DZ1_Service
{
    [ServiceContract]
    interface IMyDiskInfo
    {
        [OperationContract]
        string FreeSpace(string diskName);

        [OperationContract]
        string TotalSpace(string diskName);
    }
}
