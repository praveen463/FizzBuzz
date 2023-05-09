
using FizzBuzz.Interfaces;
using FizzBuzz;

Console.WriteLine("Hello, World!");
IPrinter printer = new ConsolePrinter();
INumberEvaluator evaluator = new NumberEvaluator();
FizzBuzzGenerator generator = new FizzBuzzGenerator(printer, evaluator);

generator.Generate(1, 100);

Console.ReadLine();