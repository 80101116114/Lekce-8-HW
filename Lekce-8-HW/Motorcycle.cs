using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekce_8_HW
{
    internal class Motorcycle : Vehicle, IDriveable
    {
        public bool maNad35kW { get; set; }

        public override void UkazInfo()
        {
            Console.WriteLine("Motorka " + Brand + "s najezdem " + Mileage + ". Ma nad 35 kW ?" + maNad35kW);
        }
        public void Drive()
        {
            Console.WriteLine("Motorka: " + Brand + " jedeeeee");
        }
        public override void NastartujMotor()
        {
            Console.WriteLine("Motorka nastartovala :D");
        }
    }
}
