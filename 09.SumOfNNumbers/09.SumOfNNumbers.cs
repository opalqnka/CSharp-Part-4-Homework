/*Problem 9. Sum of n Numbers

Write a program that enters a number n and after that enters more n numbers and calculates and prints their sum.
 */

using System;
using System.Threading;
using System.Globalization;

namespace _09.SumOfNNumbers
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
            double sum = 0;

            for (int i = 1; i <= n; i++)
            {
                double number = double.Parse(Console.ReadLine());
                sum += number;
            }

            Console.WriteLine("The sum is {0}", sum);

        }

    }
}
