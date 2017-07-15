using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.IO;

namespace DZ1_Service
{
    class MyDiskInfo : IMyDiskInfo
    {
        public string FreeSpace(string diskName)
        {
            if(diskName.Length > 0)
            {
                DriveInfo[] drv = DriveInfo.GetDrives();
                foreach(var item in drv)
                {
                    if (item.Name.ElementAt(0) == diskName.ElementAt(0))
                        return item.TotalFreeSpace.ToString();
                }
            }
            return "Wrong disk!";
        }

        public string TotalSpace(string diskName)
        {
            if (diskName.Length > 0)
            {
                DriveInfo[] drv = DriveInfo.GetDrives();
                foreach (var item in drv)
                {
                    if (item.Name.ElementAt(0) == diskName.ElementAt(0))
                        return item.TotalSize.ToString();
                }
            }
            return "Wrong disk!";
        }
    }
}
