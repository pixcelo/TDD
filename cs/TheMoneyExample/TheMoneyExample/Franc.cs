namespace TheMoneyExample
{
    public class Franc : Money
    {
        public Franc(int amount, string currency) : base(amount, currency)
        {
            base.amount = amount;
            base.currency = currency;
        }

        public override Money Times(int multiplier)
        {
            return Money.Franc(base.amount * multiplier);
        }
    }
}
