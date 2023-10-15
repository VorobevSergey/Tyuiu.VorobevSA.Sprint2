using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.VorobevSA.Sprint2.Task6.V15.Lib;

namespace Tyuiu.VorobevSA.Sprint2.Task6.V15
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService service1 = new DataService();
            Console.Title = "Спринт #0 | Выполнил: Воробьев С.А. | ПКДб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема:Получение результата из switch                                     *");
            Console.WriteLine("* Задание #2.6                                                            *");
            Console.WriteLine("* Вариант #15                                                             *");
            Console.WriteLine("* Выполнил:Воробьев Сергей Александрович | ПКТб-23-2                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("*Дано целое число k (1 <= k <= 365). Определить, каким днем недели        *");
            Console.WriteLine("*(понедельником, вторником, …, субботой или воскресеньем) является k-й ден*");
            Console.WriteLine("*не високосного года, в котором 1 января понедельник.                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите день для проверки= ");
            int k = Convert.ToInt32(Console.ReadLine());
            string res = service1.FindDayName(k);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("День недели заданного вами дня: " + res);
            Console.ReadKey();
        }
    }
}
