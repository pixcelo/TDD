namespace TheMoneyExample
{
    /// <summary>
    /// Value Object パターン
    /// コンストラクタで設定したインスタンス変数の値が変わってはならない
    /// </summary>
    public class Dollar : Money
    {
        private readonly int amount;

        public Dollar(int amount)
        {
            this.amount = amount;
        }

        public Dollar Times(int multiplier)
        {
            return new Dollar(amount * multiplier);
        }

        public override bool Equals(object obj)
        {
            Dollar dollar = (Dollar)obj;
            return amount == dollar.amount;
        }
    }
}
