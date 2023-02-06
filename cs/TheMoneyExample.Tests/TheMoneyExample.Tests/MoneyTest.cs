namespace TheMoneyExample.Tests
{
    public class MoneyTest
    {
        [Fact]
        public void TestMultiplication()
        {
            Dollar five = new Dollar(5);
            Assert.Equivalent(new Dollar(10), five.Times(2));
            Assert.Equivalent(new Dollar(15), five.Times(3));
        }

        [Fact]
        public void TestEquality()
        {
            Assert.True(new Dollar(5).Equals(new Dollar(5)));
            Assert.False(new Dollar(5).Equals(new Dollar(6)));
            Assert.Equal(new Dollar(5), new Dollar(5));
        }
    }
}