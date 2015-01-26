/*Problem 10. Fibonacci Numbers

Write a program that reads a number n and prints on the console the first n members of the Fibonacci sequence 
(at a single line, separated by comma and space - ,) : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, …
 */

using System;


namespace _10.FibonacciNumbers
{
    class Program
    {

        //I'll solve the problem recursively using a function called Fibonacci
        public static int Fibonacci(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            else if (n == 0)
            {
                return 0;
            }

            return Fibonacci(n - 1) + Fibonacci(n - 2);
            }

        static void Main()
        {
            Console.WriteLine("Please, enter n");
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write(Fibonacci(i) + ", ");
            }

            Console.WriteLine();
        }
    }
}
