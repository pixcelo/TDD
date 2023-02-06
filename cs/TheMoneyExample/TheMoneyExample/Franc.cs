using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheMoneyExample
{
    public class Franc
    {
        private readonly int amount;
        
        public Franc(int amount)
        {
            this.amount = amount;
        }

        public Franc Times(int multiplier)
        {
            return new Franc(amount * multiplier);
        }

        public override bool Equals(object obj)
        {
            Franc franc = (Franc)obj;
            return amount == franc.amount;
        }
    }
}
