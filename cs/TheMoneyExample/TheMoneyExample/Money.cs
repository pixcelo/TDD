namespace TheMoneyExample
{
    public abstract class Money
    {
        protected int amount;
        protected string? currency;
        public abstract Money Times(int multiplier);

        public Money(int amount, string currency)
        {
            this.amount = amount;
            this.currency = currency;
        }

        public string? Currency()
        {
            return currency;
        }

        public override bool Equals(object obj)
        {
            Money money = (Money)obj;
            return amount == money.amount
                   && this.GetType().Equals(obj.GetType());
        }

        public static Money Dollar(int amount)
        {
            return new Dollar(amount, "USD");
        }

        public static Money Franc(int amount)
        {
            return new Franc(amount, "CHF");
        }
    }
}
