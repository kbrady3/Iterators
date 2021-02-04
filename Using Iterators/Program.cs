using System;

namespace Using_Iterators
{
    class Program
    {
        static void Main(string[] args)
        {
            const int arraySize = 10;
            const int beginRange = 5;
            const int endRange = 25;
            int[] array = new int[arraySize]; //initializes array with size 10

            for(int i = 0; i < array.Length; i++) //iterate while there's still space in array
            {
                Random randomGenerator = new Random(); //generates random number
                array[i] = randomGenerator.Next(beginRange, endRange); //puts a random number between 5 and 25 into the array
            }

            foreach(int item in array) 
            {
                Console.WriteLine(item); //display the item
            }

            Console.WriteLine("Press enter to exit.");
            Console.ReadLine(); //reads user input
        }
    }
}
