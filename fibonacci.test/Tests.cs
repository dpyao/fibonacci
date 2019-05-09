using Xunit;

namespace fibonacci.test
{
    public class Test
    {
        [Theory]
        [InlineData(1, 1)]
        [InlineData(2, 1)]
        [InlineData(3, 2)]
        [InlineData(10, 55)]
        [InlineData(11, 89)]
        [InlineData(12, 144)]
        [InlineData(12, 144)]
        public void ShouldReturnFibonacciNumberIfGiveAItemNumber(int itemNumber, long expected)
        {
            var fibonacci = new Fibonacci();
            var number = fibonacci.GetNumber(itemNumber);
            
            Assert.Equal(expected, number);
        }
    }
}