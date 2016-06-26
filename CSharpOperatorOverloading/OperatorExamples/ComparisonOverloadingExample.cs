using CSharpDelegates.Utilities;
using CSharpOperatorOverloading.Operators;
using System;

namespace CSharpOperatorOverloading.OperatorExamples
{
    public class ComparisonOverloadingExample
    {
        public static void Run()
        {
            PrintUtility.PrintTitle("COMPARISON OVERLOADING");

            // Create two 'Point' objects.
            Point p1 = new Point(100, 100);
            Point p2 = new Point(40, 40);

            bool p1GreaterThanp2 = p1 > p2;
            bool p1LessThanp2 = p1 < p2;
            bool p1GreaterOrEqualTop2 = p1 >= p2;
            bool p1LessOrEqualTp2 = p1 <= p2;

            Console.WriteLine($"p1 Greater Than p2: {p1GreaterThanp2}");
            Console.WriteLine($"p1 Less Than p2: {p1LessThanp2}");
            Console.WriteLine($"p1 Greater Than Or Equal To p2: {p1GreaterOrEqualTop2}");
            Console.WriteLine($"p1 Less Than Or Equal To  p2: {p1LessOrEqualTp2}");
        }

    }
}
