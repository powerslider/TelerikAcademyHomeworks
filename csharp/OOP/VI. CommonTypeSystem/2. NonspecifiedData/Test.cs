using System;

class Program
{
    static void Main()
    {
        Person personOne = new Person("Pesho");
        Console.WriteLine(personOne);

        Person personTwo = new Person("Gosho", 123);
        Console.WriteLine(personTwo);
    }
}

