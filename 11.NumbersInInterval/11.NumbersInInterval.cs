/*Problem 11.* Numbers in Interval Dividable by Given Number

Write a program that reads two positive integer numbers and prints how many numbers p exist between them 
such that the reminder of the division by 5 is 0.
*/

using System;

namespace _11.NumbersInInterval
{
    class Program
    {
        static void Main()
        {
            //Remove the comments below to see the numbers divisible by 5
            Console.WriteLine("Please, enter an interval: ");
            Console.Write("Initial number = ");
            int start = int.Parse(Console.ReadLine());
            Console.Write("Final number = ");
            int final = int.Parse(Console.ReadLine());
            int counter = 0;

            //Console.WriteLine("Numbers divisible by 5:");

            for (int i = start; i <= final; i++)
            {
                if (i % 5 == 0)
                {
                    //Console.WriteLine(i);
                    counter += 1;
                }
            }
            Console.WriteLine("In the given interval ({0}, {1}) there are {2} numbers divisible by 5 .", start, final, counter);

        }
    }
}
