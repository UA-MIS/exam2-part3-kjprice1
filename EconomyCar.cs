namespace spring21_exam2_part3
{
    public class EconomyCar : Car
    {
        public override string GetDescription()
        {
            return "Economy Car";
        }

        public override double GetCost()
        {
            return 10000.00;
        }
    }
}