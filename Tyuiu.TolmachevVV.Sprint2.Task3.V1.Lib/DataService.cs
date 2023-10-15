using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.TolmachevVV.Sprint2.Task3.V1.Lib
{
    public class DataService : ISprint2Task3V1
    {
        public double Calculate(double x)
        {
            if (x < -5)
            {
                return x + 10 * x - (1 / Math.Pow(x, 3) + 3);
            }
            else if (x > -5 && x < 3)
            {
                if (x == 2)
                {
                    return x + (15 / x);
                }
                else
                {
                    return x + 10 * x - (1 / x);
                }
            }
            else
            {
                return Math.Exp(x) - 12 * x + Math.Cos(x);
            }
        }
    }
}
