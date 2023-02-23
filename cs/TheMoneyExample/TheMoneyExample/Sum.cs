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

        public Expression Times(int multiplier)
        {
            return new Sum(augend.Times(multiplier), addend.Times(multiplier));
        }

        public Expression Plus(Expression augend)
        {
            return new Sum(this, addend);
        }

        public Money Reduce(Bank bank, string to)
        {
            int amount = augend.Reduce(bank, to).amount
                         + addend.Reduce(bank, to).amount;
            return new Money(amount, to);
        }
    }
}
