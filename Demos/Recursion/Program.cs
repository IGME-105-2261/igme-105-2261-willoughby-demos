namespace Recursion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Factorials
            // 5! = 1 * 2 * 3 * 4 * 5
            // 4! = 1 * 2 * 3 * 4
            // 3! = 1 * 2 * 3

            // n! = (n-1)! * n

            // Iterative Approach
            int value = 1;
            int n = 10;
            int product = 1;

            while (value <= n)
            {
                product *= value;
                value++;
            }

            Console.WriteLine("{0}! = {1}", n, product);

            n = 5;
            product = Factorial(n);
            Console.WriteLine("{0}! = {1}", n, product);
        }

        public static int Factorial(int n)
        {
            if(n == 1)
            {
                return 1;
            }

            return Factorial(n - 1) * n;
        }
    }
}
