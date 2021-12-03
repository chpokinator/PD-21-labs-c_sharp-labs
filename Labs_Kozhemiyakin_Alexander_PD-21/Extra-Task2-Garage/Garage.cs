using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Extra_Task2_Garage
{
    class Garage
    {
        List<Car> cars;
        public Garage()
        {
            cars = new List<Car>();
        }

        public void AddCar(Car c)
        {
            this.cars.Add(c);
        }

        public void DeleteCar(Car c)
        {
            this.cars.Remove(c);
        }

        public List<Car> GetCars(Predicate<Car> predicate = null)
        {
            if(predicate == null)
            {
                return cars;
            }
            return cars.Where(x=> predicate(x) == true).ToList();
        }

        public void ShowCars()
        {
            ConsoleColor before = Console.BackgroundColor;
            for (int i = 0; i < this.cars.Count; i++)
            {
                Console.BackgroundColor = this.cars[i].Color;
                Console.WriteLine(this.cars[i].ToString());
            }
            Console.BackgroundColor = before;
        }
    }
}
