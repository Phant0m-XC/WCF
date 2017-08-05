using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Client.ServiceReference1;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Service1Client proxy = new Service1Client();
            int choice = -1;
            string path;
            bool goOn = true;
            string[] result;
            do
            {
                Console.WriteLine("1 - Просмотреть содержимое папки\n0 - Выход");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 0:
                        goOn = false;
                        break;
                    case 1:
                        Console.Write("Введите путь: ");
                        path = Console.ReadLine();
                        result = proxy.getContent(path);
                        foreach (var item in result)
                            Console.WriteLine(item);
                        break;
                    default:
                        Console.WriteLine("Неверный вывод");
                        break;
                }
            } while (goOn);
        }
    }
}
