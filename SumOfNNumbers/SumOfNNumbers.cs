// Problem 9. Sum of n Numbers
// Write a program that enters a number n and after that enters more n numbers and calculates and prints their sum. 
// Note: You may need to use a for-loop.

using System;

class SumOfNNumbers
{
    static void Main()
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write("Enter number n: ");
        double n = double.Parse(Console.ReadLine());
        double sum = 0;
        for (int i = 1; i <= n; i++)
        {
            Console.Write("Enter number {0}: ", i);
            double number = double.Parse(Console.ReadLine());
            sum += number;
        }
        Console.WriteLine("The sum of the numbers is: " + sum);
    }
}

