namespace TheMoneyExample
{
    public class Franc : Money
    {
        private readonly string currency;

        public Franc(int amount)
        {
            this.amount = amount;
            currency = "CHF";
        }

        public override string Currency()
        {
            return currency;
        }

        public override Money Times(int multiplier)
        {
            return new Franc(amount * multiplier);
        }
    }
}
