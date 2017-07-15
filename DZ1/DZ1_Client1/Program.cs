using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace DZ1_Client1
{
    class Program
    {
        static void Main(string[] args)
        {
            ChannelFactory<IMyDiskInfo> factory = new ChannelFactory<IMyDiskInfo>(new WSHttpBinding(),
                new EndpointAddress("http://localhost:80/Temporary_Listen_Addresses/"));
            IMyDiskInfo channel = factory.CreateChannel();
            int choice = -1;
            string diskName;
            bool goOn = true;
            do
            {
                Console.Write("Введите имя диска: ");
                diskName = Console.ReadLine();
                Console.WriteLine("1 - Вывести размер диска?\n2 - Вывести размер свободного пространства диска?\n0 - Выход");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 0:
                        goOn = false;
                        break;
                    case 1:
                        Console.WriteLine(channel.TotalSpace(diskName));
                        break;
                    case 2:
                        Console.WriteLine(channel.FreeSpace(diskName));
                        break;
                    default:
                        Console.WriteLine("Неверный вывод");
                        break;
                }
            } while (goOn);
            factory.Close();
        }
    }
}