/*Problem 8. Numbers from 1 to n

Write a program that reads an integer number n from the console and prints all the numbers in the interval [1..n], each on a single line.
 */

using System;
using System.Threading;
using System.Globalization;

namespace _08.NumbersFrom1ToN
{
    class Program
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            Console.WriteLine("Please, enter a number");
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i);
            }

        }
    }
}
