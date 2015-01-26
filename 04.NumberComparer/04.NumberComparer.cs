/*Problem 4. Number Comparer

Write a program that gets two numbers from the console and prints the greater of them.
Try to implement this without if statements.
*/

using System;
using System.Threading;
using System.Globalization;

namespace _04.NumberComparer
{
    class Program
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            Console.WriteLine("Please, enter 2 numbers: ");
            Console.Write("a = ");
            double first = double.Parse(Console.ReadLine());
            Console.Write("b = ");
            double second = double.Parse(Console.ReadLine());

            //use the Math.Max function to get the bigger value
            Console.WriteLine("The greater number is: {0}", Math.Max(first, second));

        }
    }
}
