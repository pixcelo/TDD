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
            Assert.True(Money.Franc(5).Equals(Money.Franc(5)));
            Assert.False(Money.Franc(5).Equals(Money.Franc(6)));
            Assert.False(Money.Franc(5).Equals(Money.Dollar(5)));
        }

        [Fact]
        public void TestFrancMultiplication()
        {
            Money five = Money.Franc(5);
            Assert.Equivalent(Money.Franc(10), five.Times(2));
            Assert.Equivalent(Money.Franc(15), five.Times(3));
        }

        [Fact]
        public void TestCurrency()
        {
            Assert.Equal("USD", Money.Dollar(1).Currency());
            Assert.Equal("CHF", Money.Franc(1).Currency());
        }
    }
}