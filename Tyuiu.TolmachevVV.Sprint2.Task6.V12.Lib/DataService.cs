using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.TolmachevVV.Sprint2.Task6.V12.Lib
{
    public class DataService : ISprint2Task6V12
    {
        public string FindDateOfPreviousDay(int g, int m, int n)
        {
            switch (n)
            {
                case 1:
                    switch (m)
                    {
                        case 1: return Convert.ToString(31) + "." + Convert.ToString(12) + "." + Convert.ToString(--g);
                        default: m--;                            
                            switch (m)
                            {
                                case 1:
                                case 3:
                                case 5:
                                case 7:
                                case 8:
                                case 10: return Convert.ToString(31) + "." + Convert.ToString(m) + "." + Convert.ToString(g);
                                case 2: return Convert.ToString(28) + "." + Convert.ToString(m) + "." + Convert.ToString(g);
                                default: return Convert.ToString(30) + "." + Convert.ToString(m) + "." + Convert.ToString(g);

                            }
                    }
                default: return Convert.ToString(--n) + "." + Convert.ToString(m) + "." + Convert.ToString(g);
            }
        }
    }
}
