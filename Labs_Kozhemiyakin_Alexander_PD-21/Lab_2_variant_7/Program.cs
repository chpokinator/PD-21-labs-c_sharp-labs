using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2_variant_7
{
    class Program
    {
        //Варіант 7

        //7.	Перевірити істинність вислову: "Серед трьох даних цілих чисел є хоч би одна пара співпадаючих".
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            Console.Write("Введіть число 1: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введіть число 2: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введіть число 3: ");
            int c = Convert.ToInt32(Console.ReadLine());

            if (a == b || a == c || b == c)
            {
                Console.WriteLine("Серед чисел є пара співпадаючих");
            }
            else
            {
                Console.WriteLine("Серед чисел намає співпадаючих пар");
            }

            Console.ReadKey();
        }
    }
}
