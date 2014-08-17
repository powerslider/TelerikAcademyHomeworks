using System;

class SieveOfEratosthenes
{
    static void Main(string[] args)
    {
        int[] array = new int[10000000];

        for (int i = 2; i < array.Length; i++)
        {
            if (array[i] == 0)
            {
                Console.Write(i + " ");
                for (int j = i * 2; j < array.Length; j += i)
                {
                    array[j] = 1;
                }
            }
        }
    }
}

