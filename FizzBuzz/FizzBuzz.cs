namespace FizzBuzz
{
    public class FizzBuzz
    {

        private List<int> divisibleByNumbers = new List<int> { 3, 5 };

        public void DoFizzBuzz(int maxNumber)
        {
            for (int i = 1; i <= maxNumber; i++)
            {
                if (checkForFizzBuzz(i))
                {
                    Console.WriteLine("doing a fizzbuzz");
                }
                else
                {
                    Console.WriteLine(i);
                }

            }
        }

        private bool checkForFizzBuzz(int number)
        {
            foreach (var divisibleByNumber in divisibleByNumbers)
            {
                if (number % divisibleByNumber == 0)
                {
                    return true;
                }
            }
            return false;
        }
    }
}