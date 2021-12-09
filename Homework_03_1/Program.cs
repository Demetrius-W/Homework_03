using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_03_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            int value = int.Parse(Console.ReadLine());
            int check = value % 2;

            if (check == 0)
            {
                Console.WriteLine($"Число: {value} - четное");
            }
            else
            {
                Console.WriteLine($"Число: {value} - нечетное");
            }

            Console.ReadLine();
            Console.ReadKey();

        }
    }
}
