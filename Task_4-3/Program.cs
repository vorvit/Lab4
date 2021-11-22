using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задача 4-3. Максимальное количество квадратов 
            Console.WriteLine("Введите A: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите B: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите C: ");
            int c = Convert.ToInt32(Console.ReadLine());
            int k = 0;
            int n = 0;
            while (a >= c)
            {
                a -= c;
                k++; //количество квадратов по стороне А
            }
            while (b >= c)
            {     
                b -= c;
                n++; //количество квадратов по стороне В
            }
            int i = 0;
            int sum = 0;
            while (i < n)
            {
                sum += k;
                i++;
            }
            if (sum != 0)
            {
                Console.WriteLine("В прямоугольнике AB находится {0} квадратов со стороной С", sum);
            }
            else
            {
                Console.WriteLine("В прямоугольнике AB невозможно разместить квадраты со стороной С");
            }
            Console.ReadKey();
        }
    }
}
