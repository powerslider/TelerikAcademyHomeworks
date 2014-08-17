using System;

class SubsetSum
{
    static void Main()
    {
        int s = int.Parse(Console.ReadLine());
       
        int[] array = { 2, 1, 2, 4, 3, 5, 2, 6 };
        int maxSize = 0;

        foreach (int number in array)
        {
            maxSize += number;
        }

        bool[] possibleSums = new bool[maxSize + 1];
        possibleSums[0] = true;

        if (s <= maxSize)
        {
            for (int i = 0; i < array.Length; i++)
            {
                int num = array[i];
                for (int j = s; j >= num; j--)
                {
                    if (possibleSums[j - num] == true)
                    {
                        possibleSums[j] = true;
                    }
                    if (possibleSums[s])
                    {
                        break;
                    }
                }
                if (possibleSums[s])
                {
                    break;
                }
            }
            if (possibleSums[s])
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
        else
        {
            Console.WriteLine("no");
        }
    }
}

