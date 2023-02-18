namespace TheMoneyExample
{
    public class Bank
    {
        private Dictionary<Pair, int> rates = new Dictionary<Pair, int>();

        public Money Reduce(Expression source, string to)
        {
            return source.Reduce(this, to);
        }

        public void AddRate(string from, string to, int rate)
        {
            rates.Add(new Pair(from, to), rate);
        }

        public int Rate(string from, string to)
        {
            if (from.Equals(to))
            {
                return 1;
            }

            int rate = 1;

            if (rates.TryGetValue(new Pair(from, to), out rate))
            {
                return rate;
            }

            return rate;
        }
    }

}
