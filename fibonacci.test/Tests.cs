using Xunit;

namespace fibonacci.test
{
    public class Test
    {
        [Theory]
        [InlineData(1, 1)]
        [InlineData(2, 1)]
        [InlineData(3, 2)]

        public void ShouldReturnFibonacciNumberIfGiveAItemNumber(int itemNumber, int expected)
        {
            var fibonacci = new Fibonacci();
            var number = fibonacci.GetNumber(itemNumber);
            
            Assert.Equal(expected, number);
        }
    }
}