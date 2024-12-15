using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekce_8_HW
{
    internal class Truck : Vehicle, IDriveable
    {
        public int NakladniProstor { get; set; }
        public override void UkazInfo()
        {
            Console.WriteLine("Nakladak " + Brand + "s najezdem " + Mileage + ". Ma objem " + NakladniProstor + " metru krychlovych.");
        }
        public void Drive()
        {
            Console.WriteLine("Nakladak " + Brand + " jede pryc.");
        }
        public void NalozNaklad(int weight)
        {
            Console.WriteLine("Nakladak " + Brand + " naklada " + weight + " kilo"); 
        }
    }
}
