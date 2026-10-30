namespace ValueAndReference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Value types
            int myInteger = 20;
            int otherInteger = myInteger;

            otherInteger++;

            Console.WriteLine(myInteger);
            Console.WriteLine(otherInteger);

            bool myBoolean;
            double myDouble;

            //Reference types
            string myString;

            int[] myIntArray; // currently equal to null
            myIntArray = new int[5] { 10, 20, 30, 40, 50 };
            int[] otherArray = myIntArray;

            otherArray[0] = 5;

            int test = 0;
            int sum = Sum(otherArray, test);

            //Unchanged by the Sum method because ints are value types
            Console.WriteLine("test = " + test); 
            Console.WriteLine("Sum = " + sum);

            //Both changed by Sum method because arrays are reference types
            Console.WriteLine("myIntArray[0] = " + myIntArray[0]);
            Console.WriteLine("otherArray[0] = " + otherArray[0]);

            DoStuff();
        }

        public static void DoStuff()
        {
            int myInteger;
            Console.WriteLine("Hello");
        }

        public static int Sum(int[] nums, int myNumber)
        {
            myNumber = 20;
            int sum = 0;
            for(int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
                nums[i] = 0;
            }
            return sum;
        }
    }
}
