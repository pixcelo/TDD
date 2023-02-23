namespace TheMoneyExample
{
	public interface Expression
	{
        Expression Plus(Expression addend);
        Money Reduce(Bank bank, string to);
	}
}
