namespace DataAndTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
        // | declaration|| initialization |
            int myInteger = 5;

            int secondInteger;
            secondInteger = 10;

            // Assignment
            myInteger = secondInteger;
            secondInteger = 12;

            Console.WriteLine("myInteger = " + myInteger);
            Console.WriteLine("secondInteger = " + secondInteger);

            string myString = "Hello World";
            Console.WriteLine(myString);


            int x = 2;
            double price = 1.99;
            double money = 100;
            int pizzaSlices = 35;
            int candy = 75;
            int students = 22;

            int y = 5 + 3;
            x = y + 3;

            price = price * 1.08;
            //price *= 1.08; //This is the same as the line above

            money = money - price;
            //money -= price;

            money = money - (price * pizzaSlices);
            //money -= price * pizzaSlices;

            candy = candy % students;
            //candy %= students;

            x = x + 1;
            x += 1;
            x++;

            x = x - 1;
            x -= 1;
            x--;

            Console.WriteLine("x: " + x);
            Console.WriteLine("price: " + price);
            Console.WriteLine("money: " + money);
            Console.WriteLine("candy: " + candy);

            int myInt = 4;
            int myInt = 5;

        }
    }
}
