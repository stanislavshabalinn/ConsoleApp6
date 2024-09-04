using System;
using System.Transactions;

class MainClass
{
    public static void Main(string[] args)
    {
        Console.Write("Enter eour name: ");
        string name = Console.ReadLine();
        
        Console.Write("Enter your age:");
        byte age = checked((byte) int.Parse(Console.ReadLine()));

        Console.Write("What is favorite day of week? :");
        DayOfWeek day = (DayOfWeek) int.Parse(Console.ReadLine()); 

        Console.WriteLine("Your name is {0} and age is {1} and Your favorite day is {2}", name, age, day);
        Console.ReadKey();
    }
}