using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.TolmachevVV.Sprint2.Task0.V16.Lib
{
    public class DataService : ISprint2Task0V16
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] answ = new bool[] { x == y + 750, x != y + 750, x < y * 10, x > y * 10, x <= y * 10, x >= y * 10 };
            return answ;
        }
    }
}
