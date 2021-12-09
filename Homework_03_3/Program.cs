using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_03_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            int N = Convert.ToInt32(Console.ReadLine());
            int check = 2;

            if (N == 2)
            {
                Console.WriteLine($"Число: {N} - простое");
            }
            else
            {
                while (N > check)
                {
                    if (N % check >= 1)
                    {
                        Console.WriteLine($"Число: {N} - простое");
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"Число: {N} - не является простым");
                        break;
                    }
                }
            }

            Console.ReadLine();
            Console.ReadKey();

        }
    }
}