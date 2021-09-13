using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4_variant_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;



            Console.Write("Введіть розмір масиву: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Random random = new Random();
            int[] arr = new int[n];
            Console.Write("Початковий масив: ");
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(-100, 100);
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine("\n");
            int min = arr.Min();
            int max = arr.Max();
            Console.Write("Вихідний масив: ");
            for(int i = 0; i<arr.Length; i++)
            {
                if(arr[i] > 0)
                {
                    arr[i] = min;
                }
                else if (arr[i] < 0)
                {
                    arr[i] = max;
                }
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
