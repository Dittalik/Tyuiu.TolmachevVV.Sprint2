using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.TolmachevVV.Sprint2.Task1.V18.Lib
{
    public class DataService : ISprint2Task1V18
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] result = new bool[] { a == b - d | a > c, b != c & b > c, c < d || d >= c, a == d && a + d == b, !(a == b), a < b ^ c < b };
            return result;
        }
    }
}
