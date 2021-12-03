using Extra_Task1_SuperHeros.SuperHeros;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extra_Task1_SuperHeros
{
    class Program
    {
        //1. Створити інтерфейс супергерой, та реалізувати 5 своїх супергероїв створивши їм окремі класи.
        static void Main(string[] args)
        {
            Hero1 hero1 = new Hero1 { Name = "hero1" };
            hero1.Ability();
            Hero2 hero2 = new Hero2 { Name = "hero2" };
            hero2.Ability();
            Hero3 hero3 = new Hero3 { Name = "hero3" };
            hero3.Ability();
            Hero4 hero4 = new Hero4 { Name = "hero4" };
            hero4.Ability();
            Hero5 hero5 = new Hero5 { Name = "hero5" };
            hero5.Ability();

            Console.ReadKey();
        }
    }
}
