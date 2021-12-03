using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_variant_7
{
    class Program
    {
        //1.	Виводить на екран введене число з клавіатури в зворотному порядку(1234->4321)
        static void NumberReverse(int num)
        {
            for (int i = num; i > 0; i /= 10)
            {
                Console.Write(i % 10);
            }
            Console.WriteLine();
        }

        //2.	Виводить будь-яку строку в зворотному порядку (АБВ->ВБА)
        static string StringReverse(string str)
        {
            string reversed = "";
            for (int i = str.Length - 1; i >= 0; i--)
            {
                reversed += str[i];
            }
            return reversed;
        }

        //3.	Дробові числа виводяться в зворотному порядку і ціла частина і дробова (123.456->321.654)
        static void FractionsReverse(double num)
        {
            double tmp = Math.Abs(num);
            string result = "";
            if (num < 0)
            {
                result += "-";
            }

            string[] parts = tmp.ToString().Split(',');
            result += $"{StringReverse(parts[0])},{StringReverse(parts[1])}";

            Console.WriteLine(Convert.ToDouble(result));

        }

        //4.	Реалізувати метод, що буде масив повертати задом навпаки (Використання Array.Reverse() заборонено!)
        static int[] IntArrayReverse(int[] arr)
        {
            int[] newArr = arr;
            int i = 0;
            int j = newArr.Length - 1;
            while (i < j)
            {
                int temp = newArr[i];
                newArr[i] = newArr[j];
                newArr[j] = temp;
                i++;
                j--;
            }

            return newArr;
        }

        //5.	Виконати пункт 4 з використанням ключових слів ref i out
        static void IntArrayReverseRefOut(ref int[] arr)
        {
            int i = 0;
            int j = arr.Length - 1;
            while (i < j)
            {
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
                i++;
                j--;
            }
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            //Console.Write("Введіть число --> ");
            //int num = Convert.ToInt32(Console.ReadLine());
            //NumberReverse(num);

            //Console.WriteLine(StringReverse("prikol test 123"));


            //FractionsReverse(123.456);

            //Console.WriteLine(string.Join(",", IntArrayReverse(new int[] { 1, 2, 3, 4, 5 })));

            int[] arr = { 1, 2, 3, 4, 5 };
            IntArrayReverseRefOut(ref arr);
            Console.WriteLine(string.Join(",", arr));

            Console.ReadKey();
        }
    }
}
