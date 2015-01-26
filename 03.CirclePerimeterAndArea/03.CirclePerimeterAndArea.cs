/*Problem 3. Circle Perimeter and Area

Write a program that reads the radius r of a circle and prints its perimeter and area formatted with 2 digits after the decimal point.
 */

using System;
using System.Threading;
using System.Globalization;

namespace _04.CirclePerimeterAndArea
{
    class Program
    {
        static void Main()
        {
            //Set Invarian culture
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            //Ask for input
            Console.Write("Enter radius r = ");
            double radius = double.Parse(Console.ReadLine());

            //Calcualate the perimeter and area
            double perimeter = 2 * radius * Math.PI;
            double area = Math.PI * radius * radius;

            //Print the result
            Console.WriteLine("Perimeter = {0 :F2}\nArea = {1 :F2}", perimeter, area);
        }
    }
}
