/*Problem 1. Sum of 3 Numbers

Write a program that reads 3 real numbers from the console and prints their sum.
 */

using System;
using System.Threading;
using System.Globalization;

namespace _01.SumOf3Numbers
{
    class Program
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            Console.WriteLine("Please, enter 3 real numbers: ");
            Console.Write("a = ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b = ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("c = ");
            double c = double.Parse(Console.ReadLine());

            double sum;
            sum = a + b + c;

            Console.WriteLine("The sum of the 3 numbers is {0}", sum);
        }
    }
}
