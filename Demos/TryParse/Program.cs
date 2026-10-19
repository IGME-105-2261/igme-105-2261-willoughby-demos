namespace TryParse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result = -1;
            bool success = false;

            Console.Write("Please enter a positive, even, whole number: ");
            success = int.TryParse(Console.ReadLine(), out result);

            while(!success || result < 1 || result % 2 == 1)
            {
                Console.Write("Invalid input! Try again: ");
                success = int.TryParse(Console.ReadLine(), out result);
            }

            Console.WriteLine("Your number is " + result);
        }
    }
}
