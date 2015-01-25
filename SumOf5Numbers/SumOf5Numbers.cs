// Problem 7. Sum of 5 Numbers
// Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum.

using System;

class SumOf5Numbers
{
    static void Main(string[] args)
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Enter 5 numbers separated by space: ");
        string input = Console.ReadLine();
        string[] numbers = input.Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries);
        double sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += double.Parse(numbers[i]);
        }
        Console.WriteLine("The sum is: {0}", sum);
    }
}

