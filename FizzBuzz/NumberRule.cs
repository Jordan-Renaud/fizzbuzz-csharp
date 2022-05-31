namespace FizzBuzz
{

    public class NumberRule
    {
        public int Number { get; }
        public string Phrase { get; }

        public NumberRule(int number, string phrase)
        {
            Number = number;
            Phrase = phrase;
        }
    }
}