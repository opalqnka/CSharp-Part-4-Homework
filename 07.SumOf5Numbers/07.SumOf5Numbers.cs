/*Problem 7. Sum of 5 Numbers

Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum.
 */

using System;
using System.Threading;
using System.Globalization;

namespace _07.SumOf5Numbers
{
    class Program
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            Console.WriteLine("Please, enter 5 numbers: ");
            string[] numbers = Console.ReadLine().Split(' ');

            double sum = 0.0;

            for (int i = 0; i < numbers.Length; i++)
            {
                sum += Convert.ToDouble(numbers[i]);
            }

            Console.WriteLine("The sum is {0}", sum);

        }
    }
}
