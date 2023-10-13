using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.TolmachevVV.Sprint2.Task1.V18.Lib;

namespace Tyuiu.TolmachevVV.Sprint2.Task1.V18
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
            Console.WriteLine("*Задание #1                                                               *");
            Console.WriteLine("*Вариант #18                                                              *");
            Console.WriteLine("*Выполнил: Толмачев Виталий Владимирович | ПКТб 23-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            int a = 155; int b = 696; int c = 242; int d = 541;
            Console.WriteLine($"Значение a: {a} значение b: {b} значение c: {c} значение d: {d}          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            for (int i = 0; i < service1.GetLogicOperations(a, b, c, d).Length; ++i)
            {
                Console.WriteLine(service1.GetLogicOperations(a, b, c, d)[i]);
            }
            Console.WriteLine("***************************************************************************");
            Console.ReadKey();
        }
    }
}
