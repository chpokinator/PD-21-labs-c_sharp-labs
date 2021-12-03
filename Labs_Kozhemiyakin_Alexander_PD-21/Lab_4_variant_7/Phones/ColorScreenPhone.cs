using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4_variant_7.Phones
{
    public class ColorScreenPhone : PhoneWithBlackWhiteScreen
    {
        public void Games()
        {
            Console.WriteLine("You can play games on me!!!");
        }
        public void Music()
        {
            Console.WriteLine("You can listen to music!!!");
        }
        public void Videos()
        {
            Console.WriteLine("You can watch different videos!!!");
        }
    }
}
