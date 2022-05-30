namespace FizzBuzz
{
    public class FizzBuzz
    {
        private List<int> divisibleByNumbers = new List<int> { 3, 5, 7 };

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
                    string newWord = getWordFor(divisibleByNumber);
                    phraseSeparated.Add(newWord);
                }
            }
            string phrase = string.Join("", phraseSeparated);
            return phrase;
        }

        private string getWordFor(int divisibleByNumber)
        {
            switch (divisibleByNumber)
            {
                case 3:
                    return "Fizz";
                case 5:
                    return "Buzz";
                case 7:
                    return "Bang";
                default:
                    return "";
            }
        }

        public void DoFizzBuzz(int maxNumber)
        {
            for (int i = 1; i <= maxNumber; i++)
            {
                if (CheckForFizzBuzz(i))
                {
                    string phrase = SetPhraseFor(i);
                    Console.WriteLine($"\t{phrase}");
                }
                else
                {
                    Console.WriteLine($"\t{i}");
                }

            }
        }

    }
}