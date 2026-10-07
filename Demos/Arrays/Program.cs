namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] nums = new int[3];
            int[] nums;
            nums = new int[3];

            int num1 = 12;
            int num2 = 5;
            int num3 = 90;

            nums[0] = 12;
            nums[1] = 5;
            nums[2] = 90;

            Console.WriteLine(nums[1]);

            Console.Write("How many numbers do you have? ");
            int numItems = int.Parse(Console.ReadLine());

            int[] userNumbers = new int[numItems];

            numItems = 5;

            for (int i = 0; i < userNumbers.Length; i++)
            {
                Console.Write("Enter #{0}: ", i + 1);
                userNumbers[i] = int.Parse(Console.ReadLine());
            }

            int sum = 0;
            for (int i = 0; i < userNumbers.Length; i++)
            {
                sum += userNumbers[i];
            }
            Console.WriteLine("The sum of your numbers is " + sum);

            int[] multiplesOf5 = new int[50];
            for(int i = 0; i < multiplesOf5.Length; i++)
            {
                multiplesOf5[i] = (i + 1) * 5;
            }
        }
    }
}
