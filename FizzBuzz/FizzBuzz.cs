using FizzBuzz.Rules;

namespace FizzBuzz
{
    public class FizzBuzz
    {
        private List<int> divisibleByNumbers = new List<int> { 3, 5, 7, 11 };

        Dictionary<int, IRule> NumberRules =
            new Dictionary<int, IRule>() {
                {3, new AdditionRule("Fizz")},
                {5, new AdditionRule("Buzz")},
                {7, new AdditionRule("Bong")}
            };

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
            void ResetPhraseSeparated()
            {
                phraseSeparated.Clear();
            }
            string GetWordFor(int divisibleByNumber)
            {
                switch (divisibleByNumber)
                {
                    case 3:
                        return "Fizz";
                    case 5:
                        return "Buzz";
                    case 7:
                        return "Bang";
                    case 11:
                        ResetPhraseSeparated();
                        return "Bong";
                    default:
                        return "";
                }
            }

            foreach (var divisibleByNumber in divisibleByNumbers)
            {

                // if (num % divisibleByNumber == 0)
                // {
                // string newWord = GetWordFor(divisibleByNumber);
                // phraseSeparated.Add(newWord);
                // }
            }
            string phrase = string.Join("", phraseSeparated);
            return phrase;
        }

        public void DoFizzBuzz(int maxNumber)
        {
            for (int i = 1; i <= maxNumber; i++)
            {

                // string phrase = SetPhraseFor(i);
                // Console.WriteLine($"\t{phrase}");
                foreach (var rule in NumberRules)
                {
                    if (i % rule.Key == 0)
                    {
                        rule.Value.ApplyRule
                    }
                    else
                    {
                        Console.WriteLine($"\t{i}");
                    }
                }



            }
        }

    }
}