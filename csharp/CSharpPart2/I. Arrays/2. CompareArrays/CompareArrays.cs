using System;

class CompareArrays
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine();

        int[] arrOne = new int[n];
        int[] arrTwo = new int[n];
        bool isEqual = true;

        for (int i = 0; i < arrOne.Length; i++)
        {
            arrOne[i] = int.Parse(Console.ReadLine());
        }
        
        Console.WriteLine();
        
        for (int i = 0; i < arrTwo.Length; i++)
		{
			arrTwo[i] = int.Parse(Console.ReadLine());
		}

        Console.WriteLine();

        for (int i = 0; i < n; i++)
		{
            if (arrOne[i] == arrTwo[i])
            {
                Console.WriteLine("{0} = {1}  {2}", arrOne[i], arrTwo[i], isEqual);
            }
            else
            {
                Console.WriteLine("{0} = {1}  {2}", arrOne[i], arrTwo[i], !isEqual);
            }
		}
        Console.WriteLine();
    }
}

