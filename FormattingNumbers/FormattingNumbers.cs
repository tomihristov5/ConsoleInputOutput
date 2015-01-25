// Problem 5. Formatting Numbers
// Write a program that reads 3 numbers:
// integer a (0 <= a <= 500)
// floating-point b
// floating-point c
// The program then prints them in 4 virtual columns on the console. Each column should have a width of 10 characters.
// The number a should be printed in hexadecimal, left aligned
// Then the number a should be printed in binary form, padded with zeroes
// The number b should be printed with 2 digits after the decimal point, right aligned
// The number c should be printed with 3 digits after the decimal point, left aligned.

using System;

class FormattingNumbers
{
    static void Main()
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write("Enter an integer from 0 to 500: ");
        int a = int.Parse(Console.ReadLine());
        if (a >= 0 && a <= 500)
        {
            Console.Write("Enter a float-point number: ");
            double b = Double.Parse(Console.ReadLine());
            Console.Write("Enter another float-point number: ");
            double c = Double.Parse(Console.ReadLine());
            Console.Write("|{0,-10}|", a.ToString("X"));
            Console.Write("{0}|", Convert.ToString(a, 2).PadLeft(10, '0'));
            Console.Write("{0,10:0.00|}", b);
            Console.Write("{0,-10:0.000|}", c);
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("The number is not from 0 to 500");
        }
    }
}

