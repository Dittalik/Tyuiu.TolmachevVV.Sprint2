using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.TolmachevVV.Sprint2.Task7.V12.Lib
{
    public class DataService : ISprint2Task7V12
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            if (x < -2)
            {
                if (y > 4) { return true; }
                else return false;
            }
            else if (x > 0 && x < 1)
            {
                if (y > 0 && y < 1) { return true; }
                else return false;
            }
            else return false;
        }
    }
}
