using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Цикл_с_предусловием_while
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину стороны А прямоугольника: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите длину стороны В прямоугольника: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите длину стороны С квадрата:");
            int c = Convert.ToInt32(Console.ReadLine());
            int sq_a = 0;
            int sq_b = 0;
            while (a >= c)
            {
                a -= c;
                sq_a++;
            }
            while (b >= c)
            {
                b -= c;
                sq_b++;
            }
            int sum_sq = 0;
            for (int n = 0; n < sq_a; n++)
            {
                sum_sq += sq_b;
            }
            Console.WriteLine("Количество квадратов в прямоугольнике равно {0} ", sum_sq);
            Console.ReadKey();
        }
    }
}
