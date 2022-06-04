using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Homework 3:
             Eyni qaydada istifadəçidən 10 ədəd şəhər adı soruşun. 10 - cu şəhərin adını daxil edəndən sonra
               bu dəfə alt-alta yox vergüllə ayıyıb yazın.
             Məsələn: Baki, Gence, Sumqayit...

             Qeyd: Bu 3 tapşırığı etmək üçün 3 ayrı yeni Console Application yaradın.Eyni solution içində yazmayın.
             */

            String name = ("Sheher adini daxil et");

            Console.WriteLine("1-ci " + name);
            var one = Console.ReadLine();

            Console.WriteLine("2-ci " + name);
            var two = Console.ReadLine();

            Console.WriteLine("3-cu " + name);
            var three = Console.ReadLine();

            Console.WriteLine("4-cu " + name);
            var four = Console.ReadLine();

            Console.WriteLine("5-ci " + name);
            var five = Console.ReadLine();

            Console.WriteLine("6-ci " + name);
            var six = Console.ReadLine();

            Console.WriteLine("7-ci " + name);
            var seven = Console.ReadLine();

            Console.WriteLine("8-ci " + name);
            var eight = Console.ReadLine();

            Console.WriteLine("9-cu " + name);
            var nine = Console.ReadLine();

            Console.WriteLine("10-cu " + name);
            var ten = Console.ReadLine();

            Console.WriteLine(one + ", " + two + ", " + three + ", " + four + ", " + five + ", " + six + ", " + seven + ", " + eight + ", " + nine + ", " + ten + ".");
            Console.ReadLine();
        }
    }
}
