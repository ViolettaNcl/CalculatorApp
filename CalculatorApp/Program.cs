using System;

namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var calc = new Calculator();
            Console.WriteLine("Calculator Demo");
            Console.WriteLine($"Add: 5 + 3 = {calc.Add(5, 3)}");
            Console.WriteLine($"Subtract: 5 - 3 = {calc.Subtract(5, 3)}");
        }
    }
}