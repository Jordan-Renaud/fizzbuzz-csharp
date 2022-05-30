using System;

namespace FizzBuzz
{
    public class NumberRetrieval
    {
        public int maxNumber = 100;
        public void GetNumberFromUser()
        {
            bool haveNotFoundNumber = true;

            while (haveNotFoundNumber)
            {
                int number;

                Console.WriteLine("\nPlease enter a maximum number to FizzBuzz: ");
                string? input = Console.ReadLine();


                if (Int32.TryParse(input, out number))
                {
                    Console.WriteLine($"You chose: {number}\n");
                    haveNotFoundNumber = false;
                    maxNumber = number;
                }
                else
                {
                    Console.WriteLine("\nSorry, that is not a number please try again.");
                }
            }

        }


    }
}