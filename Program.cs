using System;

namespace spring21_exam2_part3
{
    class Program
    {
        static void Main(string[] args)
        {
            Car kia = new EconomyCar();
            Console.WriteLine(kia.GetDescription() + " costs $" + kia.GetCost());

            Car bmw = new DeluxCar();
            Console.WriteLine(bmw.GetDescription() + " costs $" + bmw.GetCost());
        }
    }
}
