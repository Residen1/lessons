using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Homework 1:
             İstifadəçidən adını, soyadını, yaşadığı şəhəri soruşun və bunları dəyişənlərdə saxlayın.

             Homework 2:
             İstifadəçidən 10 ədəd şəhər adı daxil etməsini istəyin. İstifadəçi 10-cu şəhər adını daxil
             etdikdən sonra sıra ilə şəhər adlarını alt-alta ekrana yazdırın.
             Məsələn:
             Bakı
             Gəncə
             Sumqayıt
            */

            Console.WriteLine("Adinizi daxil edin");
            var name = Console.ReadLine();

            Console.WriteLine("SoyAdinizi daxil edin");
            var Surname = Console.ReadLine();

            Console.WriteLine("Yashadiginiz sheherin adini daxil edin");
            var Cityname = Console.ReadLine();

            Console.WriteLine("Ad: " + name);
            Console.WriteLine("SoyAd: " + Surname);
            Console.WriteLine("Sheher: " + Cityname);







        }

    }
}
