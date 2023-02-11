namespace TheMoneyExample
{
    public class Bank
    {
        public Money Reduce(Expression source, string to)
        {
            if (typeof(Money).IsInstanceOfType(source))
            {
                return (Money)source;
            }

            Sum sum = (Sum)source;
            return sum.Reduce(to);
        }
    }

}
