﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.VorobevSA.Sрrint2.Task0.V22.Lib;

namespace Tyuiu.VorobevSA.Sрrint2.Task0.V22
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService service1 = new DataService();
            Console.Title = "Спринт #0 | Выполнил: Воробьев С.А. | ПКДб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Операции сравнения                                                *");
            Console.WriteLine("* Задание #2.0                                                            *");
            Console.WriteLine("* Вариант #22                                                             *");
            Console.WriteLine("* Выполнил:Воробьев Сергей Александрович | ПКТб-23-2                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("*Написать программу из операций сравнений (==, !=, <, >, <=, >=,          *");
            Console.WriteLine("*последовательность операций не должна нарушаться) и арифметических       *");
            Console.WriteLine("*выражений, которая вернет логическую последовательность(массив):         *");
            Console.WriteLine("*(False, True, True, True, True, False),), при x = 3105, y = 77           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int x = 3105;
            int y = 77;
            bool[] res = new bool[6];
            res = service1.GetCompareOperations(x, y);
            Console.WriteLine("x=" + x + " y=" + y);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(res[i]);
            }
            Console.ReadKey();
        }
    }
}
