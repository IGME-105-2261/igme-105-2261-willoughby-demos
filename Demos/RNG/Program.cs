namespace RNG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int myInteger = 10;
            Random rng = new Random(DateTime.Today.Millisecond);
            //Random rng2 = new Random(DateTime.Today.Millisecond);

            Console.WriteLine(rng.Next());
            //Console.WriteLine(rng2.Next());

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(rng.Next());
            //}

            //This version of Next is exclusive of the upper bound
            int smallNum = rng.Next(10); // [0,10) -> 0 1 2 3 4 5 6 7 8 9

            for (int i = 0; i < 100; i++)
            {
                //This will never print out 10
                Console.Write($"{rng.Next(10)} ");
            }

            //Minimum = Inclusive (included in possible outputs)
            //Maximum = Exclusive (not included in possible outputs)
            int numInRange = rng.Next(12, 19); // 12 -> 18, not 19
            //int numInRange = rng.Next(12, 20); // 12 -> 19

            //                                0          1          2
            string[] names = new string[] { "Austin", "Cortland", "Erika" };
            string randomName = names[0]; //Austin
            randomName = names[2]; //Erika
            randomName = names[rng.Next(0, names.Length)]; //Random one from the array
            Console.WriteLine(randomName);


            // 0.0 -> 0.999999999999
            double randomDouble = rng.NextDouble();

            // 0.0 -> 99.999999999999
            randomDouble = rng.NextDouble() * 100;

            // 50.0 -> 99.999999999999
            randomDouble = 50.0 + rng.NextDouble() * 50.0;

            // 12.5 -> 81.3299999999999
            randomDouble = RandDoubleInRange(rng, 12.5, 81.33);
        }

        public static double RandDoubleInRange(Random rng, double min, double max)
        {
            return min + rng.NextDouble() * (max - min);
        }
    }
}
