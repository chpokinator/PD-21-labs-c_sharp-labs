using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extra_Task2_Garage
{
    class Program
    {
        //2.  Гараж шейха 
        /*
         Створити клас, який буде уособлювати Гараж Шейха.
         Створити клас, який буде уособлювати Автомобіль. В Гаражі зберігається необмежена кількість Автомобілів.
         Шейх може купити новий Автомобіль в Гараж, чи викинути існуючий.
         Також Шейх може взяти машину покататися за певними критеріями: за ім’ям машини, кольором, швидкістю, року випуску
         (за всіма параметрами, або частково). Після введення параметру на екран виводяться всі Автомобілі з Гаражу Шейха, які підходять за цими параметрами
        */
        static void Main(string[] args)
        {
            Garage g = new Garage();
            Car c1 = new Car("моя перша машина", ConsoleColor.Red, 100, 1992);
            Car c2 = new Car("моя улюблена машина", ConsoleColor.Yellow, 200, 1985);
            Car c3 = new Car("стрьомна машина", ConsoleColor.Gray, 500, 2021);
            Car c4 = new Car("сзаламана машина", ConsoleColor.Green, 2000, 2057);
            Car c5 = new Car("test", ConsoleColor.Red, 150, 1990);

            g.AddCar(c1);
            g.AddCar(c2);
            g.AddCar(c3);
            g.AddCar(c4);
            g.AddCar(c5);

            //g.ShowCars();
            ConsoleColor before = Console.BackgroundColor;
            foreach (var x in g.GetCars(a => a.Color == ConsoleColor.Red))
            {
                Console.BackgroundColor = x.Color;
                Console.WriteLine(x.ToString());
            }
            Console.BackgroundColor = before;
            Console.ReadKey();
        }
    }
}
