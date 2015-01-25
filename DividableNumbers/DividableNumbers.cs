// Problem 11.* Numbers in Interval Dividable by Given Number
// Write a program that reads two positive integer numbers and prints how many numbers p exist between them such that the 
// remainder of the division by 5 is 0.

using System;

class DividableNumbers
{
    static void Main()
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write("Write a number: ");
        int startNumber = int.Parse(Console.ReadLine());
        Console.Write("Write a number: ");
        int endNumber = int.Parse(Console.ReadLine());
        int p = 0; // Counts how many numbers are dividable with 5 without a remainder
        Console.WriteLine("The dividable numbers by 5 with remainder of 0 between {0} and {1} are: ", startNumber, endNumber);
        for (int i = startNumber; i <= endNumber; i++)
        {
            if (i % 5 == 0)
            {
                Convert.ToString(i);
                p++;
                Console.Write(" " + i);
            }
        }
        Console.WriteLine();
        Console.WriteLine("There are {0} numbers.", p);
    }
}

