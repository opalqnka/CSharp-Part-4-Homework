/*Problem 6. Quadratic Equation

Write a program that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots).
 */

using System;
using System.Threading;
using System.Globalization;

namespace _06.QuadraticEquation
{
    class Program
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            Console.WriteLine("Please, enter the 3 coefficients: ");
            Console.Write("a = ");
            double first = double.Parse(Console.ReadLine());
            Console.Write("b = ");
            double second = double.Parse(Console.ReadLine());
            Console.Write("c = ");
            double third = double.Parse(Console.ReadLine());

            double discr = second * second - 4 * first * third;

            if (discr < 0)
            {
                Console.WriteLine("no real roots");
            }
            else
            {
                double discr_sqrt = Math.Sqrt(discr);
                double sol_1 = (-second - discr_sqrt) / (2.0 * first);
                double sol_2 = (-second + discr_sqrt) / (2.0 * first);

                if (sol_1 == sol_2)
                {
                    Console.WriteLine("x1 = x2 = {0}", sol_1);
                }
                else
                {
                    Console.WriteLine("x1 = {0}\nx2 = {1}", sol_1, sol_2);
                }
            }

        }
    }
}
