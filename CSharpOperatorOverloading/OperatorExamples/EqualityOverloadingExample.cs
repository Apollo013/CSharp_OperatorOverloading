using CSharpDelegates.Utilities;
using CSharpOperatorOverloading.Operators;
using System;

namespace CSharpOperatorOverloading.OperatorExamples
{
    public class EqualityOverloadingExample
    {
        public static void Run()
        {
            PrintUtility.PrintTitle("EQUALITY OVERLOADING");

            // Create two 'Point' objects.
            Point p1 = new Point(100, 100);
            Point p2 = new Point(40, 40);

            Console.WriteLine("p1 == p2 : {0}", p1 == p2);
            Console.WriteLine("p1 != p2 : {0}", p1 != p2);

        }
    }
}
