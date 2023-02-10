namespace TheMoneyExample
{
    /// <summary>
    /// Value Object パターン
    /// コンストラクタで設定したインスタンス変数の値が変わってはならない
    /// </summary>
    public class Dollar : Money
    {
        public Dollar(int amount, string currency) : base(amount, currency)
        {
            base.amount = amount;
            base.currency = currency;
        }

        public override Money Times(int multiplier)
        {
            return Money.Dollar(base.amount * multiplier);
        }
    }
}
