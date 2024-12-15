
namespace Lekce_8_HW
{
    internal abstract class Vehicle
    {
        public string Brand;
        public string GetBrand()
        {
            return Brand;
        }
        public void SetBrand(string brand)
        {
            Brand = brand;
        }
        public int Mileage;
        public int GetmileAge()
        {
            return Mileage;
        }

        public void SetmileAge(int mileAge)
        {
            Mileage = mileAge;
        }
        public abstract void UkazInfo();
        public virtual void NastartujMotor()
        {
            Console.WriteLine("Vuz: " + Brand + " nastartoval motor");
        }
    }
}
