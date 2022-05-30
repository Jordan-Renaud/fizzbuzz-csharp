using System;
using static FizzBuzz.NumberRetrieval;

namespace FizzBuzz
{
    public class Program
    {
        static void Main(string[] args)
        {
            NumberRetrieval numberRetrieval = new NumberRetrieval();
            numberRetrieval.GetNumberFromUser();

            Console.WriteLine(numberRetrieval.maxNumber);
        }
    }
}