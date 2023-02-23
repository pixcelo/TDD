namespace TheMoneyExample
{
	public interface Expression
	{
        Expression Times(int multiplier);
        Expression Plus(Expression addend);
        Money Reduce(Bank bank, string to);
    }
}
