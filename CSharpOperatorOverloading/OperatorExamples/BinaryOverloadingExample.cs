using CSharpDelegates.Utilities;
using CSharpOperatorOverloading.Operators;
using System;

namespace CSharpOperatorOverloading.OperatorExamples
{
    /// <summary>
    /// Demonstrate Binary operator overloading
    /// See 'Point' class under 'Models' folder.
    /// </summary>
    public class BinaryOverloadingExample
    {
        public static void Run()
        {
            PrintUtility.PrintTitle("BINARY OVERLOADING");

            // Create two 'Point' objects.
            Point p1 = new Point(100, 100);
            Point p2 = new Point(40, 40);

            Console.WriteLine("p1 = {0}", p1);
            Console.WriteLine("p2 = {0}", p2);

            // Add the points to make a bigger point
            Console.WriteLine($"p1 + p2: {p1 + p2}");

            // Subtract the points to make a smaller point
            Console.WriteLine($"p1 - p2: {p1 + p2}");


            // += and –+ Operators (FREEBIES)
            PrintUtility.PrintSubTitle("+= and –+ Operators");

            // +=
            Point p3 = new Point(90, 5);
            Console.WriteLine($"p3 = {p3}");
            Console.WriteLine($"p3 += p2: {p3 += p2}");

            // -=
            Point p4 = new Point(0, 500);
            Console.WriteLine($"p4 = {p4}");
            Console.WriteLine($"p4 -= p3: {p4 -= p3}");

        }
    }
}
