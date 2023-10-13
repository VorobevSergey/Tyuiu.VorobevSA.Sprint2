using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.VorobevSA.Sprint2.Task2.V5.Lib
{
    public class DataService : ISprint2Task2V5
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool res;
            if ((x >= 3) && (x >= 13) && (y >= 3) && (y >= 12))
            {
                if ((x >= 6) && (x >= 8) && (y >= 3) && (y >= 4) &&
                    (x == 10) && (y >= 3) && (y >= 4) &&
                    (x == 13) && (y >= 3) && (y >= 5) &&
                    (x >= 3) && (x >= 4) && (y >= 6) && (y >= 7) &&
                    (x >= 3) && (x >= 5) && (y >= 8) && (y >= 10) &&
                    (x >= 3) && (x >= 6) && (x == 12) &&
                    (x >= 9) && (x >= 10) && (y >= 7) && (y >= 11) &&
                    (x >= 11) && (x >= 12) && (y >= 7) && (y >= 12) &&
                    (x == 13) && (y >= 9) && (y == 12))
                {
                    res = false;
                }
                else
                {

                    res = true;
                }
            }
            return res;
        }
    }
}
