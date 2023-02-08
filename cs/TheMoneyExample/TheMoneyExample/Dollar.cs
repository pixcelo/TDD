namespace TheMoneyExample
{
    /// <summary>
    /// Value Object パターン
    /// コンストラクタで設定したインスタンス変数の値が変わってはならない
    /// </summary>
    public class Dollar : Money
    {
        public Dollar(int amount)
        {
            this.amount = amount;
            currency = "USD";
        }

        public override Money Times(int multiplier)
        {
            return new Dollar(amount * multiplier);
        }
    }
}
