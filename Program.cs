using System;

namespace spring21_exam2_part3
{
    class Program
    {
        static void Main(string[] args)
        {
            Vacation premiumVacation = new PremiumVacation();
            Console.WriteLine(premiumVacation.GetDescription() + " costs $" + premiumVacation.GetCost());

            Vacation deluxeVacation = new DeluxeVacation();
            Console.WriteLine(deluxeVacation.GetDescription() + " costs $" + deluxeVacation.GetCost());
        }
    }
}
