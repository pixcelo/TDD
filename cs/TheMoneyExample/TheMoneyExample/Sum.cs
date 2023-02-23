namespace TheMoneyExample
{
    public class Sum : Expression
    {
        public Expression augend;
        public Expression addend;

        public Sum(Expression augend, Expression addend)
        {
            this.augend = augend;
            this.addend = addend;
        }

        public Expression Plus(Expression augend)
        {
            return null;
        }

        public Money Reduce(Bank bank, string to)
        {
            int amount = augend.Reduce(bank, to).amount
                         + addend.Reduce(bank, to).amount;
            return new Money(amount, to);
        }
    }
}
