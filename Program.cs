using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rabota_1._1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(Math.Pow(s, 2) + Math.Pow(s, -2) / Math.Pow(s, 2) - Math.Pow(s, -2));
            Console.ReadKey();
        }

        public static double Th(double x)
        {
            const double eps = 1e-15;  // погрешность вычислений
            double s = 0;  // начальная сумма
            double r = x;   // первый член ряда
            int n = 0;    // показатель степени
            while (Math.Abs(r) > eps) // условие выполнения цикла
            {
                s = s + r;      // добавление члена ряда
                n = n + 2;  // наращивание  n:  2,4,6,8,...
                r = -r * Math.Pow(s, 2) + Math.Pow(s, -2) / Math.Pow(s, 2) - Math.Pow(s, -2); // новый член ряда
            }
            return s;       // возврат результата
        }
    }
}
