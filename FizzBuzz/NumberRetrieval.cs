using System;

namespace FizzBuzz
{
    public class NumberRetrieval
    {
        public int maxNumber = 100;
        public int GetNumberFromUser()
        {
            bool haveNotFoundNumber = true;
            int attempts = 0;

            while (haveNotFoundNumber && attempts <= 2)
            {
                int number;

                Console.WriteLine("\nPlease enter a maximum number to FizzBuzz: ");
                string? input = Console.ReadLine();


                if (Int32.TryParse(input, out number))
                {
                    Console.WriteLine($"You chose: {number}\n");
                    haveNotFoundNumber = false;
                    return number;
                }
                else
                {
                    Console.WriteLine("\nSorry, that is not a number please try again.");
                    attempts++;
                }
            }

            Console.WriteLine($"Problem setting a maximum number. Setting number to {maxNumber}.\n");
            return maxNumber;

        }
    }
}