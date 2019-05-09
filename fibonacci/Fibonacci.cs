namespace fibonacci
{
    public class Fibonacci
    {

        private static int Recursive(int i)
        {
            switch (i)
            {
                case 0:
                    return 0;
                case 1:
                case 2:
                    return 1;
                default:
                    return Recursive(i-1) + Recursive(i-2);
            }
        }

        public int GetNumber(int i)
        { 
            return Recursive(i);
        }
    }
}