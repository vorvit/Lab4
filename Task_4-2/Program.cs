using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задача 4-2. Сравнение количесва отрицательных и положительных чисел 
            int kolOtr = 0;
            int kolPol = 0;
            int number;
            Console.WriteLine("Введите последовательность отрицательных и положительных чисел и 0 для выхода");
            do
            {
                number = Convert.ToInt32(Console.ReadLine());
                if (number > 0)
                {
                    kolPol++;
                }
                else if (number != 0)
                {
                    kolOtr++;
                }
            } while (number != 0);
            if (kolOtr > kolPol)
            {
                Console.WriteLine("Количество отрицательных чисел ({0}) больше количества положительных ({1})", kolOtr, kolPol);
            }
            else if (kolOtr == kolPol)
            {
                if (number == 0)
                {
                    Console.WriteLine("Количество положительных чисел ({1}) равно количеству отрицательных ({0})", kolOtr, kolPol);
                }
            }
            else if (kolOtr < kolPol)
            {
                Console.WriteLine("Количество положительных чисел ({1}) больше количества отрицательных ({0})", kolOtr, kolPol);
            }
            Console.WriteLine("Вы ввели 0 - программа остановлена");
            Console.ReadKey();
        }
    }
}
