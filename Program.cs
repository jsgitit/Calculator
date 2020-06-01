using System;


namespace Calculator
{
    class Program
    {
        // This calc uses Reverse Polish Notation to calculate results
        // Two decimal numbers are passed in with one of four basic math operations
        // The static Calc class uses Functional Programming to return results.
        static void Main(string[] args)
        {
            Console.WriteLine(Calc.Eval("1 3 +"));
            Console.WriteLine(Calc.Eval("10 5 -"));
            Console.WriteLine(Calc.Eval("2 3 *"));
            Console.WriteLine(Calc.Eval("14 2 /"));

        }
    }
}
