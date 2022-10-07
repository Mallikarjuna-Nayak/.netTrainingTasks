using System;

namespace InterfacesTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Fuel amount:");
            Cars car = new Cars(0);
            int fuel = int.Parse(Console.ReadLine());
            if(car.Refuel(fuel))
            {
                car.Drive();
            }
        }
    }
    public interface IVehiculo
    {
        void Drive();
        bool Refuel(int amount);
    }
    public class Cars : IVehiculo
    {
        public int Fuel { get; set; }
        public Cars(int fuel)
        {
            Fuel = fuel;
        }
        public void Drive()
        {
            if(Fuel > 0)
            {
                Console.WriteLine("Driving");
            }
            else
            {
                Console.WriteLine("No Fuel");
            }
        }
        public bool Refuel(int amount)
        {
            Fuel += amount;
            return true;
        }
    }
}
