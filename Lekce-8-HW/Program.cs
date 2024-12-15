namespace Lekce_8_HW
{
    internal class Program
    {
        static void Main(string[] args)
        {

            IDriveable[] driveables = new IDriveable[150];
            for (int i = 0; i < 50; i++)
            {
                driveables[i] = new Car
                {
                    PocetDveri = 4,
                };
                ((Car)driveables[i]).SetBrand($"Car{i + 1}");
                ((Car)driveables[i]).SetmileAge(1000 + i);
                driveables[50 + i] = new Motorcycle
                {
                    maNad35kW = i % 2 == 0,
                };
                ((Motorcycle)driveables[i+50]).SetBrand($"Motorcycle{i + 1}");
                ((Motorcycle)driveables[i+50]).SetmileAge(2000 + i);
                driveables[100 + i] = new Truck
                {
                    NakladniProstor = 100 + i,
                };
                ((Truck)driveables[i+100]).SetBrand($"Truck{i + 1}");
                ((Truck)driveables[i+100]).SetmileAge(3000 + i);
            }
            Console.WriteLine("Vsechna vozidla jedou: ");
            foreach (var driveable in driveables)
            {
                driveable.Drive();
            }


            Vehicle[] vehicles = new Vehicle[60];
            for (int i = 0; i < 30; i++)
            {
                vehicles[i] = new Car { PocetDveri = 4 };
                vehicles[i].SetBrand($"CarModel{i + 1}");
                vehicles[i].SetmileAge(i * 100);
            }
            for (int i = 0; i < 20; i++)
            {
                vehicles[30 + i] = new Motorcycle { maNad35kW = i % 2 == 0 };
                vehicles[30 + i].SetBrand($"MotorcycleModel{i + 1}");
                vehicles[30 + i].SetmileAge(i * 200);
            }
            for (int i = 0; i < 10; i++)
            {
                vehicles[50 + i] = new Truck { NakladniProstor = 15 + i };
                vehicles[50 + i].SetBrand($"TruckModel{i + 1}");
                vehicles[50 + i].SetmileAge(i * 300);
            }

            foreach (var vehicle in vehicles)
            {
                vehicle.UkazInfo();
                vehicle.NastartujMotor();
            }





        }

        
        
        
    }
}
