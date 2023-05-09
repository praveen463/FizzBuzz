using FizzBuzz.Interfaces;

namespace FizzBuzz;

public class FizzBuzzGenerator
{
    private readonly IPrinter _printer;
    private readonly INumberEvaluator _evaluator;

    public FizzBuzzGenerator(IPrinter printer, INumberEvaluator evaluator)
    {
        _printer = printer;
        _evaluator = evaluator;
    }

    public void Generate(int start, int end)
    {
        for (int i = start; i <= end; i++)
        {
            if (_evaluator.IsMultipleOf3(i) && _evaluator.IsMultipleOf5(i))
            {
                _printer.Print("FizzBuzz");
            }
            else if (_evaluator.IsMultipleOf3(i))
            {
                _printer.Print("Fizz");
            }
            else if (_evaluator.IsMultipleOf5(i))
            {
                _printer.Print("Buzz");
            }
            else
            {
                _printer.Print(i.ToString());
            }
        }
    }
}
