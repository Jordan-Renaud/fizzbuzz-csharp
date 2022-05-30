namespace FizzBuzz
{
    public class FizzBuzz
    {
        private List<int> divisibleByNumbers = new List<int> { 3, 5 };

        private bool CheckForFizzBuzz(int number)
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

        private string SetPhraseFor(int num)
        {
            List<string> phraseSeparated = new List<string> { };

            foreach (var divisibleByNumber in divisibleByNumbers)
            {
                if (num % divisibleByNumber == 0)
                {
                    switch (divisibleByNumber)
                    {
                        case 3:
                            phraseSeparated.Add("Fizz");
                            break;
                        case 5:
                            phraseSeparated.Add("Buzz");
                            break;
                        default:
                            phraseSeparated.Add("");
                            break;
                    }
                }
            }
            string phrase = string.Join("", phraseSeparated);
            return phrase;
        }

        public void DoFizzBuzz(int maxNumber)
        {
            for (int i = 1; i <= maxNumber; i++)
            {
                if (CheckForFizzBuzz(i))
                {
                    string phrase = SetPhraseFor(i);
                    Console.WriteLine(phrase);
                }
                else
                {
                    Console.WriteLine(i);
                }

            }
        }

    }
}