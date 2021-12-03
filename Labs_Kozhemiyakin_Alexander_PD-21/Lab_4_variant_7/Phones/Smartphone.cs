using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4_variant_7.Phones
{
    public class Smartphone: ColorScreenPhone
    {
        public void ContactlessPay()
        {
            Console.WriteLine("Pay for goods with nfc!!!");
        }
        public void QualityCamera()
        {
            Console.WriteLine("Make beautiful photos and videos with high quality camera on your smartphone!!!");
        }
        public void Perfomance()
        {
            Console.WriteLine("Your phone can handle mostly all tasks in the quickiest way!!!");
        }
    }
}
