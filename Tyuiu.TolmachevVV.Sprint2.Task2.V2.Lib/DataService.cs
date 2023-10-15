using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.TolmachevVV.Sprint2.Task2.V2.Lib
{
    public class DataService : ISprint2Task2V2
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            if (x == 3 || x == 4)
            {
                if (y == 3 || y == 6 || y == 7 || y == 11)
                {
                    return true;
                }
                if (x == 4 && (y == 12 || y == 13))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            if (x == 5 || x == 6 || x == 7)
            {
                if (x == 5)
                {
                    if (y == 3 || y == 4)
                    {
                        return true;
                    }
                }
                if (x == 7 && y == 9)
                {
                    return true;
                }
                if (y == 5 || y == 6 || (y >= 11 && y <= 13))
                {
                    return true;
                }
            }
            if (x == 8 || x == 9 || x == 10)
            {
                if (y >= 5 && y <= 9)
                {
                    return true;
                }
                if (x == 9 || x == 10 && (y == 3 || y == 4))
                {
                    return true;
                }
                if (x == 8 || x == 9 && (y == 10 || y == 11))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            if (x >= 11 && x <= 13)
            {
                if (x == 11 && (y >= 7 && y<= 9))
                {
                    return true;
                }
                if (x == 12 && (y >= 3 && y <= 9))
                {
                    return true;
                }
                if (x == 13 && (y >= 6 && y <= 8))
                {
                    return true;
                }
                else { return false; }
            }
            else
            {
                return false;
            }
        }
    }
}
