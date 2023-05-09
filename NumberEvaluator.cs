using FizzBuzz.Interfaces;

namespace FizzBuzz;

public class NumberEvaluator : INumberEvaluator
{
    public bool IsMultipleOf3(int number)
    {
        return number % 3 == 0;
    }

    public bool IsMultipleOf3And5(int number)
    {
        return IsMultipleOf3(number) && IsMultipleOf5(number);
    }

    public bool IsMultipleOf5(int number)
    {
        return number % 5 == 0;
    }
}
