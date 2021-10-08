using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Цикл_с_постусловием_do_while
{
    class Program
    {
        static void Main(string[] args)
        {
            int q_positive = 0;
            int q_negative = 0;
            int n = 0;
            do
            {
                Console.WriteLine("Введите целое число:");
                n = Convert.ToInt32(Console.ReadLine());
                if (n > 0)
                    q_positive++;
                else
                    if (n < 0)
                    q_negative++;
            } while (n != 0);
            if (q_positive > q_negative)
                Console.WriteLine("Количество положительных чисел больше количества отрицательных");
            else
                if (q_positive < q_negative)
                Console.WriteLine("Количество отрицательных чисел больше количества положительных");
            else
                Console.WriteLine("Количество отрицательных и положительных чисел равно");
            Console.ReadKey();
        }
    }
}
