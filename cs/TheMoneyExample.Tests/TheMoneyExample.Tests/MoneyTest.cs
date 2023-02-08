using System;

namespace TheMoneyExample.Tests
{
    public class MoneyTest
    {
        [Fact]
        public void TestMultiplication()
        {
            Money five = Money.Dollar(5);
            Assert.Equivalent(Money.Dollar(10), five.Times(2));
            Assert.Equivalent(Money.Dollar(15), five.Times(3));
        }

        [Fact]
        public void TestEquality()
        {
            Assert.True(Money.Dollar(5).Equals(Money.Dollar(5)));
            Assert.False(Money.Dollar(5).Equals(Money.Dollar(6)));
            Assert.Equal(Money.Dollar(5), Money.Dollar(5));
            Assert.True(new Franc(5).Equals(new Franc(5)));
            Assert.False(new Franc(5).Equals(new Franc(6)));
            Assert.False(new Franc(5).Equals(new Dollar(5)));
        }

        [Fact]
        public void TestFrancMultiplication()
        {
            Franc five = new Franc(5);
            Assert.Equivalent(new Franc(10), five.Times(2));
            Assert.Equivalent(new Franc(15), five.Times(3));
        }
    }
}