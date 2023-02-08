namespace TheMoneyExample
{
    public abstract class Money
    {
        protected int amount;
        public abstract Money Times(int multiplier);

        public override bool Equals(object obj)
        {
            Money money = (Money)obj;
            return amount == money.amount
                   && this.GetType().Equals(obj.GetType());
        }

        public static Money Dollar(int amount)
        {
            return new Dollar(amount);
        }
    }
}
