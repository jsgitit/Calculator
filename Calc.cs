using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    public static class Calc
    {
        
        // Method uses generic "Func<T1,T2,O3>" delegate
        // It takes in "Left" and "right" (first two params) , and outputs the result in third param.
        private static Func<decimal, decimal, decimal> GetOperation(char oper)
        {
            switch (oper)
            {
                case '+': return (l, r) => l + r;  // Note the use of lambda expressions
                case '-': return (l, r) => l - r;
                case '*': return (l, r) => l * r;
                case '/': return (l, r) => l / r;
                default: throw new NotSupportedException("The supplied operator is not supported");
            }
        }

        public static decimal Eval(string expr)
        {
            var elements = expr.Split(new[] { ' ' }, 3);
            var l = Decimal.Parse(elements[0]);
            var r = Decimal.Parse(elements[1]);
            var op = elements[2][0];  // +, -, *, /

            return GetOperation(op)(l, r); // calls method with generic Func<>
        }
    }
}
