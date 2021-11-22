using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задача 4-1. Квадрат числа через сумму такого же количества нечетных чисел 
            Console.WriteLine("Введите целое положительное число N:");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number > 0)
            {
                for (int i = 1, j = 0; i <= number; i++)
                {
                    j = j + (2 * i - 1);
                    Console.WriteLine(j);
                }
            }
            else
            {
                Console.WriteLine("Ошибка ввода");
            }
            Console.ReadKey();
        }
    }
}
