using System;

class GeneratingVariations
{
    static int numberOfLoops;
    static int numberOfIterations;
    static int[] variations;

    static void Main(string[] args)
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("k = ");
        int k = int.Parse(Console.ReadLine());

        numberOfLoops = k;
        numberOfIterations = n;
        variations = new int[k];

        Variate(0);
    }

    static void Variate(int currentLoop)
    {
        if (currentLoop == numberOfLoops)
        {
            PrintVariation();
            return;
        }

        for (int i = 1; i <= numberOfIterations; i++)
        {
            variations[currentLoop] = i;
            Variate(currentLoop + 1);
        }
    }

    static void PrintVariation()
    {
        foreach (int number in variations)
        {
            Console.Write("{0} ", number);
        }
        Console.WriteLine();
    }
}
