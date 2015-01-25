// Problem 10. Fibonacci Numbers
// Write a program that reads a number n and prints on the console the first n members of the Fibonacci sequence 
// (at a single line, separated by comma and space - ,) : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, ….

using System;

class FibonacciNumbers
{
    static void Main()
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write("Enter a number: ");
        int n = int.Parse(Console.ReadLine());
        int a = 0;
        int b = 1;
        Console.Write("The first {0} numbers of the Fibonacci sequence are: {1}, {2}", n, a, b);
        for (int i = 2; i < n; i++)
        {
            int fib = a + b;
            a = b;
            b = fib;
            Console.Write(", {0}", fib);
        }
        Console.WriteLine();
    }
}

