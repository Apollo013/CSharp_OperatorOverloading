using CSharpDelegates.Utilities;
using CSharpOperatorOverloading.Operators;
using System;

namespace CSharpOperatorOverloading.OperatorExamples
{
    public class UnaryOverloadingExample
    {
        public static void Run()
        {
            PrintUtility.PrintTitle("UNARY OVERLOADING");

            // Applying the ++ and -- unary operators to a Point.
            Point p1 = new Point(1, 1);
            Console.WriteLine($"++p1 = {++p1}"); // [2, 2]
            Console.WriteLine($"--p1 = {--p1}"); // [1, 1]

            // Apply same operators as postincrement/decrement.
            Point p2 = new Point(20, 20);
            Console.WriteLine($"p2++ = {p2++}"); // [20, 20]
            Console.WriteLine($"p2-- = {p2--}"); // [21, 21]
            Console.WriteLine($"p2 = {p2}"); // [20, 20]
        }
    }
}
