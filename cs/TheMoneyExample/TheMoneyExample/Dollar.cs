namespace TheMoneyExample
{
    /// <summary>
    /// Value Object パターン
    /// コンストラクタで設定したインスタンス変数の値が変わってはならない
    /// </summary>
    public class Dollar : Money
    {
        private readonly string currency;

        public Dollar(int amount)
        {
            this.amount = amount;
            currency = "USD";
        }

        public override string Currency()
        {
            return currency;
        }

        public override Money Times(int multiplier)
        {
            return new Dollar(amount * multiplier);
        }
    }
}
