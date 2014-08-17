using System;

class PrintName
{
    static void Main()
    {
        string myName = ReadName();
        Console.WriteLine("Hello, {0}!", myName);
    }
    
    static string ReadName()
    {
        Console.Write("Input your name: ");
        string name = Console.ReadLine();

        return name;
    }
}

