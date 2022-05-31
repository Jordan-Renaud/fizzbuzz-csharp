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

            // List<Rule> rules = new List<Rule> { new AdditionRule(), new ReplacementRule(), new AdditionRule() };

            // string aString = "";
            // foreach (var rule in rules)
            // {
            //     aString = rule.ApplyRule(aString);
            // }

            // Console.WriteLine(aString);
        }
    }
}