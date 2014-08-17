using System;

class ArrayInitialisation
{
    static void Main()
    {
        int[] myArray = new int[20];

        for (int i = 0; i < myArray.Length; i++)
        {
            Console.Write("myArray[{0}] = ", i*5);
            myArray[i] = int.Parse(Console.ReadLine());
        }
    }
}

