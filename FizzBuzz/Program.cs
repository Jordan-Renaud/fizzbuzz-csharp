using System;
using static FizzBuzz.NumberRetrieval;
using static FizzBuzz.FizzBuzz;

namespace FizzBuzz
{
    public class Program
    {
        static void Main(string[] args)
        {
            NumberRetrieval numberRetrieval = new NumberRetrieval();
            FizzBuzz fizzBuzz = new FizzBuzz();

            int maxNumber = numberRetrieval.GetNumberFromUser();
            fizzBuzz.DoFizzBuzz(maxNumber);
        }
    }
}