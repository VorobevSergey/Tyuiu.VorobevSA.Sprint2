using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.VorobevSA.Sprint2.Task5.V7.Lib;

namespace Tyuiu.VorobevSA.Sprint2.Task5.V7
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService service1 = new DataService();
            Console.Title = "Спринт #0 | Выполнил: Воробьев С.А. | ПКДб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема:Оператор Switch                                                    *");
            Console.WriteLine("* Задание #2.5                                                            *");
            Console.WriteLine("* Вариант #7                                                              *");
            Console.WriteLine("* Выполнил:Воробьев Сергей Александрович | ПКТб-23-2                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("*С начала 1990 года по некоторый день прошло n месяцев и 2 дня. Определить*");
            Console.WriteLine("*название месяца (январь, февраль и т. п.) этого дня.                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите колличество прошедших месяцев: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int year = 1990;
            string res = service1.FindMonthName(year, n);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Ваш месяц: " + res);
            Console.ReadKey();
        }
    }
}
