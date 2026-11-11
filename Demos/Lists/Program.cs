//The necessary using statement for lists
//Visual studio 2026 adds this by default, so you
//dont need to manually write it out
using System.Collections.Generic;

namespace Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rng = new Random();
            int[] myNumbers = new int[3];

            List<int> numbersList = new List<int>();
            //List<int> numbersList = new List<int>(4); //Initializes with a capacity of 4
            numbersList.Add(40);
            Console.WriteLine(numbersList[0]);

            for(int i = 0; i < 10; i++)
            {
                numbersList.Add(rng.Next(100));
            }
            //Console.WriteLine(numbersList[10]);
            //Console.WriteLine(numbersList[11]); //Out of bounds

            numbersList.Insert(0, 99);
            numbersList[0] = 98;

            for (int i = 0; i < numbersList.Count; i++)
            {
                Console.WriteLine(i + ": " + numbersList[i]);
            }

            bool didRemove = numbersList.Remove(400);
            if (didRemove)
            {
                Console.WriteLine("Removed a value!");
            }

            numbersList[6] = 55;
            for (int i = 0; i < numbersList.Count; i++)
            {
                Console.WriteLine(i + ": " + numbersList[i]);
            }
            Console.WriteLine();

            //numbersList.RemoveAt(3);





            for (int i = 0; i < numbersList.Count; i++)
            {
                if(numbersList[i] == 55)
                {
                    numbersList.RemoveAt(i);
                    i--;
                }

                Console.WriteLine(i + ": " + numbersList[i]);
            }




            foreach(int num in numbersList)
            {
                Console.WriteLine(num);
            }
        }
    }
}
