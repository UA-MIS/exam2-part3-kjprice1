namespace spring21_exam2_part3
{
    public class PremiumVacation : Vacation
    {
        public override string GetDescription()
        {
            return "PremiumVacation Vacation";
        }

        public override double GetCost()
        {
            return 10000.00;
        }
    }
}