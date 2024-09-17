
using System;
class Agha
{
    static void Main(string[] args)
    {
       
        Console.WriteLine("Enter your Name: ");
        string name = Console.ReadLine();

        Console.WriteLine("Enter your Roll No: ");
        string rollNo = (Console.ReadLine());

        Console.Write("Enter your Class: ");
        string studentClass = (Console.ReadLine());

        Console.Write("Enter Section: ");
        string section = Console.ReadLine();

        Console.WriteLine("\nStudent Information:");
        Console.WriteLine("Your Name: " + name);
        Console.WriteLine("Your Roll No: " + rollNo);
        Console.WriteLine("Your Class: " + studentClass);
        Console.WriteLine("Your Section: " + section);
    }
}
