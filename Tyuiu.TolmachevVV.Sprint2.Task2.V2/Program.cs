using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.TolmachevVV.Sprint2.Task2.V2.Lib;

namespace Tyuiu.TolmachevVV.Sprint2.Task2.V2
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService service1 = new DataService();
            Console.Title = "Спринт #1 | Выполнил: Толмачев. В. В. | ПКТб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*Спринт #2                                                                *");
            Console.WriteLine("*Тема: Алгоритмы линейной структуры                                       *");
            Console.WriteLine("*Задание #2                                                               *");
            Console.WriteLine("*Вариант #2                                                               *");
            Console.WriteLine("*Выполнил: Толмачев Виталий Владимирович | ПКТб 23-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Введите координаты x и y:                                                 *");
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(service1.CheckDotInShadedArea(x, y));
            Console.WriteLine("***************************************************************************");
            Console.ReadKey();
        }
    }
}
