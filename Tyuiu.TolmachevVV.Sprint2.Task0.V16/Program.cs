using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.TolmachevVV.Sprint2.Task0.V16.Lib;

namespace Tyuiu.TolmachevVV.Sprint2.Task0.V16
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService service1 = new DataService();
            Console.Title = "Спринт #1 | Выполнил: Толмачев. В. В. | ПКТб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*Спринт #1                                                                *");
            Console.WriteLine("*Тема: Алгоритмы линейной структуры                                       *");
            Console.WriteLine("*Задание #6                                                               *");
            Console.WriteLine("*Вариант #3                                                              *");
            Console.WriteLine("*Выполнил: Толмачев Виталий Владимирович | ПКТб 23-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            int x = 1025; int y = 275;
            Console.WriteLine($"Первое значение: {x} Второе значение: {y}                                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            for (int i = 0; i < service1.GetCompareOperations(x, y).Length; ++i)
            {
                Console.WriteLine(service1.GetCompareOperations(x, y)[i]);
            }
            Console.WriteLine("***************************************************************************");
            Console.ReadKey();
        }
    }
}
