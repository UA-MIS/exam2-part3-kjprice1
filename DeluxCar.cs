namespace spring21_exam2_part3
{
    public class DeluxCar : Car
    {
        public override string GetDescription()
        {
            return "DeluxCar Car";
        }

        public override double GetCost()
        {
            return 25000.00;
        }
    }
}