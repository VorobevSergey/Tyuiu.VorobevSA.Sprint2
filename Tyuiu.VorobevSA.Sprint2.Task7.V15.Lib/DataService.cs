using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.VorobevSA.Sprint2.Task7.V15.Lib
{
    public class DataService : ISprint2Task7V15
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool res;
            if((x*x+y*y>=1) && (x * x + y * y <= 2*2))
            {
                res = true;
            }
            else
            {
                res = false;
            }
            return res;

        }
    }
}
