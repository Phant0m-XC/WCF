using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.IO;

namespace WCF_Service_dll
{
    public class Service1 : IService1
    {
        public List<string> getContent(string path)
        {
            List<string> result = new List<string>();
            if (!Directory.Exists(path))
            {
                result.Add("Path not found");
                return result;
            }
            string[] temp = Directory.GetDirectories(path);
            foreach (var item in temp)
                result.Add(item);
            temp = Directory.GetFiles(path);
            foreach (var item in temp)
                result.Add(item);
            return result;
        }
    }
}
