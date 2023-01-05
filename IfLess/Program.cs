
RuleMatching ruleMatching = new();
Console.Write(" Enter Number (0 for exit) : ");
int number = int.Parse(Console.ReadLine());
while (number != 0)
{
    ruleMatching.Apply(number);

    Console.Write(" Enter Number (0 for exit) : ");
    number = int.Parse(Console.ReadLine());
}

Console.WriteLine($" Have a good day");


public interface IRule
{
    public bool CanApply(int number);

    public string AppLy(int number);
}

public class OddRule : IRule
{
    public string AppLy(int number)
    {
        return $"{number} is odd.";
    }

    public bool CanApply(int number)
    {
        return number % 2 != 0;
    }
}

public class EvenRule : IRule
{
    public string AppLy(int number)
    {
        return $"{number} is even";
    }

    public bool CanApply(int number)
    {
        return number % 2 == 0;
    }
}

public class RuleMatching
{
    private List<IRule> rules;
    public RuleMatching()
    {
        rules = new List<IRule>
        {
            new EvenRule(),
            new OddRule()
        };
    }

    public void Apply(int number)
    {
        var rule = rules.FirstOrDefault(exp => exp.CanApply(number));
        var result = rule.AppLy(number);
        Console.WriteLine(result);
    }
}