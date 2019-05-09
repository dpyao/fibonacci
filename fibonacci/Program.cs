namespace fibonacci
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var fibonacci = new Fibonacci();

            for (var i = 1; i <= 120; i++)
            {
                System.Console.WriteLine(fibonacci.GetNumber(i));
            }
        }
    }
}