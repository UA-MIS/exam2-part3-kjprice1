namespace spring21_exam2_part3
{
    public class DeluxeVacation : Vacation
    {
        public override string GetDescription()
        {
            return "DeluxeVacation Vacation";
        }

        public override double GetCost()
        {
            return 25000.00;
        }
    }
}