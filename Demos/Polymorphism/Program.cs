namespace Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Pet myPet = new Pet();
            Dog myDog = new Dog("Harley", "Austin");
            //myDog.Bark();
            //myDog.Move();

            Cat myCat = new Cat("Mika", 2, "Elizabeth");
            //myCat.Move();

            Pet[] myPets = new Pet[2];
            myPets[0] = myDog;
            myPets[1] = myCat;

            for(int i = 0; i < myPets.Length; i++)
            {
                myPets[i].Move();

                if (myPets[i] is Dog)
                {
                    ((Dog)myPets[i]).Bark();
                }
            }


            Pet polymorphicDog = new Dog("Harley", "Austin");

            //Dog dogAsDog = (Dog)polymorphicDog;
            //dogAsDog.Bark();

            //((Dog)polymorphicDog).Bark();

        }
    }
}
