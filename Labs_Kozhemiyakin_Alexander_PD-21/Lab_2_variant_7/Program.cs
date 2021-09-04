using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2_variant_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;


            Console.Write("Введіть n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введіть k: ");
            int k = Convert.ToInt32(Console.ReadLine());
            Console.Write("Сума чи добуток?  --> ");
            string choice = Console.ReadLine();
            double res = choice.ToLower() == "сума" ? 0 : 1;

            for(int i = n*n; i<= n * k; i++)
            {
                if(choice.ToLower() == "сума")
                {
                    res += ((k*k + Math.Pow(-1, k-1) * (2*k) - 1) / (k*k + 8));
                }
                else
                {
                    res *= ((k * k + Math.Pow(-1, k - 1) * (2 * k) - 1) / (k * k + 8));
                }
            }

            Console.WriteLine($"Результат: {Math.Round(res, 2)}");
        }
    }
}
