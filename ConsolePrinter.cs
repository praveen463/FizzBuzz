using FizzBuzz.Interfaces;

namespace FizzBuzz;

public class ConsolePrinter : IPrinter
{
    public void Print(string message)
    {
        Console.WriteLine(message);
    }
}
