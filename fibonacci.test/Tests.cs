using Xunit;

namespace fibonacci.test
{
    public class Test
    {
        [Fact]
        public void ShouldReturn1IfGiveAItemNumber1()
        {
            var fibonacci = new Fibonacci();
            var number = fibonacci.getNumber(1);
            
            Assert.Equal(number, 1);
        }
    }
}