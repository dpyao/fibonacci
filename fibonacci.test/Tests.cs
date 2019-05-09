using Xunit;

namespace fibonacci.test
{
    public class Test
    {
        [Theory]
        [InlineData(1, 1)]
        [InlineData(2, 1)]
        public void ShouldReturn1IfGiveAItemNumber1(int itemNumber, int expected)
        {
            var fibonacci = new Fibonacci();
            var number = fibonacci.getNumber(itemNumber);
            
            Assert.Equal(expected, number);
        }
    }
}