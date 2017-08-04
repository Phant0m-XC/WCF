using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using DZ1_Client2.ServiceReference1;

namespace DZ1_Client2
{
    //Proxy клиент
    class Program
    {
        static void Main(string[] args)
        {
            MyDiskInfoClient proxy = new MyDiskInfoClient();
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
                        Console.WriteLine(proxy.TotalSpace(diskName));
                        break;
                    case 2:
                        Console.WriteLine(proxy.FreeSpace(diskName));
                        break;
                    default:
                        Console.WriteLine("Неверный вывод");
                        break;
                }
            } while (goOn);
        }
    }
}
