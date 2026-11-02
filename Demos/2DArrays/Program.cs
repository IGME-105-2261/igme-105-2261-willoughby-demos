namespace _2DArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Multidimensional Array
            int[,] twoDimensionalIntArray = new int[2, 3];

            /*   0   1   2
             *   3   4   5
             */

            twoDimensionalIntArray[0, 0] = 0;
            twoDimensionalIntArray[0, 1] = 1;
            twoDimensionalIntArray[0, 2] = 2;

            twoDimensionalIntArray[1, 0] = 3;
            twoDimensionalIntArray[1, 1] = 4;
            twoDimensionalIntArray[1, 2] = 5;

            Console.WriteLine(twoDimensionalIntArray[1, 2]);
            Console.WriteLine(twoDimensionalIntArray.Length);
            Console.WriteLine("Dimension 0 Length: " + 
                twoDimensionalIntArray.GetLength(0));
            Console.WriteLine("Dimension 1 Length: " + 
                twoDimensionalIntArray.GetLength(1));

            for(int r = 0; r < twoDimensionalIntArray.GetLength(0); r++)
            {
                for(int c = 0; c < twoDimensionalIntArray.GetLength(1); c++)
                {
                    Console.Write(twoDimensionalIntArray[r, c] + " ");
                }
                Console.WriteLine();
            }

            //int[] myIntArray = new int[3];
            //myIntArray[0] = 10;

            //Jagged Array
            int[][] jaggedIntArray = new int[3][];

            jaggedIntArray[0] = new int[4] { 20, 40, 60, 80 };
            jaggedIntArray[1] = new int[3] { 5, 15, 25 };
            jaggedIntArray[2] = new int[5] { 1, 2, 3, 4, 5};

            for(int r = 0; r < jaggedIntArray.Length; r++)
            {
                for(int c = 0; c < jaggedIntArray[r].Length; c++)
                {
                    Console.Write(jaggedIntArray[r][c] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
