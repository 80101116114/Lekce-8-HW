using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekce_8_HW
{
    internal class Car : Vehicle, IDriveable
    {
        public int PocetDveri { get; set; }
        public override void UkazInfo()
        {
            Console.WriteLine("Auto " + Brand + "s najezdem " + Mileage + ". Ma " + PocetDveri + " dveri.");
        }
        public void Drive()
        {
            Console.WriteLine("Auto " + Brand + " jede.");
        }
    }
}
