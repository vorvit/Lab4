using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое положительное число N:");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number > 0)
            {
                for (int i = 1, j = 1; i <= (number * number) && j <= number; i++)
                {
                    Console.WriteLine(j + j);
                    if (i % 2 != 0)
                    {
                        j = j + j;
                    }
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
