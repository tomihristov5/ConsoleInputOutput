// Problem 2. Print Company Information
// A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, age 
// and a phone number.
// Write a program that reads the information about a company and its manager and prints it back on the console.

using System;

class PrintCompanyInformation
{
    static void Main()
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write("Enter Company name: ");
        string name = Console.ReadLine();
        Console.Write("Enter Company address: ");
        string address = Console.ReadLine();
        Console.Write("Enter Company phone: ");
        string phone = Console.ReadLine();
        Console.Write("Enter Company fax: ");
        string fax = Console.ReadLine();
        Console.Write("Enter Company web site: ");
        string webSite = Console.ReadLine();
        Console.Write("Enter Manager first name: ");
        string manager = Console.ReadLine();
        Console.Write("Enter Manager last name: ");
        string managerLastName = Console.ReadLine();
        Console.Write("Enter Manager Age: ");
        string managerAge = Console.ReadLine();
        Console.WriteLine("Enter Manager Phone Number: ");
        string managerPhone = Console.ReadLine();
        Console.WriteLine("\n" + name);
        Console.WriteLine("Address: " + address);
        Console.WriteLine("Tel. " + phone);
        Console.WriteLine("Fax: " + fax);
        Console.WriteLine("Web site: " + webSite);
        Console.WriteLine("Manager: {0} {1} (age: {2}, tel. {3})", manager, managerLastName, managerAge, managerPhone);
    }
}

