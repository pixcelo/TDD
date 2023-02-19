﻿namespace TheMoneyExample
{
    public class Sum : Expression
    {
        public Money augend;
        public Money addend;

        public Sum(Money augend, Money addend)
        {
            this.augend = augend;
            this.addend = addend;
        }

        public Money Reduce(Bank bank, string to)
        {
            int amount = augend.Reduce(bank, to).amount
                         + addend.Reduce(bank, to).amount;
            return new Money(amount, to);
        }
    }
}
