using Lab_4_variant_7.Phones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4_variant_7
{
    class Program
    {
        //Використовуючи інтерфейси або спадкування реалізуйте еволюцію:
        //дисковий телефон -> кнопочний телефон –>мобільний телефон з чорно->
        //білим екраном – >мобільний телефон з кольоровим екраном – >смартфон. (краще спадкування)
        static void Main(string[] args)
        {
            Smartphone smartphone = new Smartphone();

            smartphone.MakeCalls();
            smartphone.Games();
            smartphone.Messages();
            smartphone.Perfomance();
            smartphone.CallTo("aboba");
            Console.ReadKey();
        }
    }
}
