namespace TheMoneyExample.Tests
{
    public class MoneyTest
    {
        [Fact]
        public void TestMultiplication()
        {
            Dollar five = new Dolloar(5);
            five.Times(2);
            Assert.Equal(10, five.amount);
        }
    }
}