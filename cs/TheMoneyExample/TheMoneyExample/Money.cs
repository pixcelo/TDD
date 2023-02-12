namespace TheMoneyExample
{
    public class Money : Expression
    {
        internal int amount;
        internal string? currency;

        public Money(int amount, string currency)
        {
            this.amount = amount;
            this.currency = currency;
        }

        public Money Reduce(string to)
        {
            return this;
        }

        public string? Currency()
        {
            return currency;
        }

        public override bool Equals(object obj)
        {
            Money money = (Money)obj;
            return amount == money.amount
                   && Currency().Equals(money.Currency());
        }

        public Money Times(int multiplier)
        {
            return new Money(amount * multiplier, currency);
        }

        public Expression Plus(Money addend)
        {
            return new Sum(this,  addend);
        }

        public static Money Dollar(int amount)
        {
            return new Money(amount, "USD");
        }

        public static Money Franc(int amount)
        {
            return new Money(amount, "CHF");
        }
    }
}
