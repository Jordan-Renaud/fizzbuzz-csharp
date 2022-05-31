namespace FizzBuzz.Rules
{
    public interface IRule
    {
        public List<string> ApplyRule(List<string> phrases);
    }
}