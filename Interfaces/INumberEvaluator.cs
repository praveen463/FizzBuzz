namespace FizzBuzz.Interfaces;

public interface INumberEvaluator
{
    bool IsMultipleOf3(int number);

    bool IsMultipleOf3And5(int number);

    bool IsMultipleOf5(int number);
}
