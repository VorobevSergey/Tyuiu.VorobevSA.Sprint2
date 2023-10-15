using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.VorobevSA.Sprint2.Task7.V15.Lib;

namespace Tyuiu.VorobevSA.Sprint2.Task7.V15
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService service1 = new DataService();
            Console.Title = "Спринт #0 | Выполнил: Воробьев С.А. | ПКДб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема:Добавление к решению итоговых проектов по спринту                  *");
            Console.WriteLine("* Задание #2.7                                                            *");
            Console.WriteLine("* Вариант #15                                                             *");
            Console.WriteLine("* Выполнил:Воробьев Сергей Александрович | ПКТб-23-2                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("*Написать программу на C#, которая запрашивает исходные данные            *");
            Console.WriteLine("*(вещественные значения) и вычисляет, находится ли точка с координатами   *");
            Console.WriteLine("*X,Y в заштрихованной области.                                            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите координату x: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Введите координату y: ");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            bool res = service1.CheckDotInShadedArea(x, y);
            if (res)
            {
                Console.WriteLine("Входит");
            }
            else
            {
                Console.WriteLine("Не входит");
            }
            Console.ReadKey();
        }
    }
}
