﻿namespace TheMoneyExample
{
    /// <summary>
    /// Value Object パターン
    /// コンストラクタで設定したインスタンス変数の値が変わってはならない
    /// </summary>
    public class Dollar
    {
        public int amount;

        public Dollar(int amount)
        {
            this.amount = amount;
        }

        public Dollar Times(int multiplier)
        {
            return new Dollar(amount * multiplier);
        }
    }
}
