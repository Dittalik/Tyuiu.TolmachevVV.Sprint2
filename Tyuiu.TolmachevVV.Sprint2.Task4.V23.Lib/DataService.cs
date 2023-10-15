using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.TolmachevVV.Sprint2.Task4.V23.Lib
{
    public class DataService : ISprint2Task4V20
    {
        public double Calculate(double x, double y)
        {
            return Math.Round((x / 2 < Math.Sqrt(y) / 3) ? Math.Pow(1 + 1 / Math.Pow(y, 2), x) : y + 12 * x - (1 / x), 3);
        }
    }
}
