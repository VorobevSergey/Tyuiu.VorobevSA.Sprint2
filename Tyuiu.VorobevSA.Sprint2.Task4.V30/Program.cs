using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.VorobevSA.Sprint2.Task4.V30.Lib;

namespace Tyuiu.VorobevSA.Sprint2.Task4.V30
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService service1 = new DataService();
            Console.Title = "Спринт #0 | Выполнил: Воробьев С.А. | ПКДб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Вложенные операторы if - else                                     *");
            Console.WriteLine("* Задание #2.3                                                            *");
            Console.WriteLine("* Вариант #1                                                              *");
            Console.WriteLine("* Выполнил:Воробьев Сергей Александрович | ПКТб-23-2                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("*Написать программу, которая вычисляет требуемое значение с использованием*");
            Console.WriteLine("*тернального оператора где пользователь вводит значение переменных x,y    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("x*2>y?(6+(4/x^2))^y:(y+(2/x^2)");
            Console.Write("Введите x=");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите y=");
            double y = Convert.ToDouble(Console.ReadLine());
            double res = service1.Calculate(x,y);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Значение выражения=" + res);
            Console.ReadKey();
        }
    }
}
