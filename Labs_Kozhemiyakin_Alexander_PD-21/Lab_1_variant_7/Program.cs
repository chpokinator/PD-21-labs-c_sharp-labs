using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_variant_7
{
    class Program
    {
        static void Main(string[] args)
        {
            double r;
            double h;

            Console.Write("Введите радиус конуса: ");
            r = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите высоту конуса: ");
            h = Convert.ToDouble(Console.ReadLine());

            double v = Math.Round(((Math.PI * Math.Pow(r, 2) * h) / 3), 2);

            Console.WriteLine($"Объём конуса = {v}");
        }
    }
}
