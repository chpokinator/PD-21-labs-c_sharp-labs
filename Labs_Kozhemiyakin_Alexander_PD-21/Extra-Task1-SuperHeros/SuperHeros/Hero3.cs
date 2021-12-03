using Extra_Task1_SuperHeros.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extra_Task1_SuperHeros.SuperHeros
{
    public class Hero3 : ISuperHero
    {
        private string name = "";
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public void Ability()
        {
            Console.WriteLine($"{Name}'s ability");
        }
    }
}
