namespace FizzBuzz.Rules
{
    public class AdditionRule : IRule
    {
        private string NewPhrase;
        public AdditionRule(string newPhrase)
        {
            NewPhrase = newPhrase;
        }
        public List<string> ApplyRule(List<string> phrases)
        {
            phrases.Add(NewPhrase);
            return phrases;
        }
    }
}
