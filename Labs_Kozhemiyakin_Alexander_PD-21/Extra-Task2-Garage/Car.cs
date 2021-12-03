using System;
using System.Collections.Generic;
using System.Text;

namespace Extra_Task2_Garage
{
    class Car
    {
        string name;
        public string Name
        {
            set
            {
                this.name = value.ToUpper();
            }
            get
            {
                return name;
            }
        }

        private ConsoleColor color;

        public ConsoleColor Color
        {
            get { return color; }
            set { color = value; }
        }

        private short speed;

        public short MaxSpeed
        {
            get { return speed; }
            set { speed = value; }
        }

        private short year;

        public short Year
        {
            get { return year; }
            set { year = value; }
        }


        public Car(string name, ConsoleColor color, short maxSpeed, short year)
        {
            this.Name = name;
            this.Color = color;
            this.MaxSpeed = maxSpeed;
            this.Year = year;
        }

        public override string ToString()
        {
            return $"Name: {this.Name}, Year: {this.Year}";
        }
    }
}
