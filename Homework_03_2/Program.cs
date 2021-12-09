using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_03_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Добрый вечер. Главная задача — обыграть дилера.\nУчастнику партии необходимо собрать комбинацию, которая принесет число очков, \nмаксимально приближенное к 21, но не больше. ");
            Console.Write("Сколько карт у Вас на руках? ");
            int inHand = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 1; i <= inHand; i++)
            {
                Console.Write($"Введите номинал {i} карты...");
                string cardWeight = Console.ReadLine();
                int value;
                switch (cardWeight)
                {
                    case "2":
                        value = Convert.ToInt32(cardWeight);
                        sum = sum + value;
                        break;
                    case "3":
                        value = Convert.ToInt32(cardWeight);
                        sum = sum + value;
                        break;
                    case "4":
                        value = Convert.ToInt32(cardWeight);
                        sum = sum + value;
                        break;
                    case "5":
                        value = Convert.ToInt32(cardWeight);
                        sum = sum + value;
                        break;
                    case "6":
                        value = Convert.ToInt32(cardWeight);
                        sum = sum + value;
                        break;
                    case "7":
                        value = Convert.ToInt32(cardWeight);
                        sum = sum + value;
                        break;
                    case "8":
                        value = Convert.ToInt32(cardWeight);
                        sum = sum + value;
                        break;
                    case "9":
                        value = Convert.ToInt32(cardWeight);
                        sum = sum + value;
                        break;
                    case "10":
                        value = Convert.ToInt32(cardWeight);
                        sum = sum + value;
                        break;
                    case "J":
                        value = 10;
                        sum = sum + value;
                        break;
                    case "Q":
                        value = 10;
                        sum = sum + value;
                        break;
                    case "K":
                        value = 10;
                        sum = sum + value;
                        break;
                    case "T":
                        value = 10;
                        sum = sum + value;
                        break;
                    default:
                        Console.WriteLine("Таких карт не существует...");
                        break;
                }
            }

            if (sum <= 21)
            {
                Console.WriteLine($"Поздравляю, Вы смогли обыграть дилера, сумма карт = {sum}");
            }
            else
            {
                Console.WriteLine($"Вы проиграли, сумма карт = {sum}");
            }

            Console.ReadLine();
            Console.ReadKey();

        }
    }
}