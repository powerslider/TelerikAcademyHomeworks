using System;

class GenerateRandomNumbers
{
    static void Main(string[] args)
    {
        Random generator = new Random();
        for (int i = 0; i < 10; i++)
        {      
            int rand = generator.Next(100, 201);
            Console.Write("{0} ", rand);
        }
        Console.WriteLine();
    }
}

