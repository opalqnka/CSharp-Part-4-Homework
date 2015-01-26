/*Problem 5. Formatting Numbers

Write a program that reads 3 numbers:
integer a (0 <= a <= 500)
floating-point b
floating-point c
The program then prints them in 4 virtual columns on the console. Each column should have a width of 10 characters.
The number a should be printed in hexadecimal, left aligned
Then the number a should be printed in binary form, padded with zeroes
The number b should be printed with 2 digits after the decimal point, right aligned
The number c should be printed with 3 digits after the decimal point, left aligned.
 */

using System;
using System.Threading;
using System.Globalization;

namespace _05.FormattingNumbers
{
    class Program
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
       
            Console.WriteLine("Please, enter 3 numbers\n1)  a must be an integer (0 <= a <= 500)\n2)  b and c should be with floating-points\n");
            Console.Write("a = ");
            int first = int.Parse(Console.ReadLine());

            if (0 <= first && first <= 500)
            {

                Console.Write("b = ");
                double second = double.Parse(Console.ReadLine());
                Console.Write("c = ");
                double third = double.Parse(Console.ReadLine());

                //Convert a to binary and pad it with 0s
                string firstBin = Convert.ToString(first, 2).PadLeft(10, '0');

                Console.WriteLine("\n{0,-10:X}|{1}|{2,10:F2}|{3,-10:F3}|", first, firstBin, second, third);
            }
            else
                Console.WriteLine("Not valid value for a!");

        }
    }
}
