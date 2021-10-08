using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Цикл_с_параметром_for
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число: ");
            int N = Convert.ToInt32(Console.ReadLine());
            for (int n = 1, sum = 0; n <= N; n++, sum = sum + (2 * (n - 1) - 1))
            {
                Console.WriteLine("Квадрат числа {0} равен {1} ", n, sum + (2 * n - 1));
            }
            Console.ReadKey();
        }
    }
}
