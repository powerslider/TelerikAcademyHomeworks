using System;

class CompareCharArrays
{
    static void Main()
    {
        Console.Write("Number of array elements in both arrays: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine();

        char[] arrOne = new char[n];
        char[] arrTwo = new char[n];
        bool isEqual = true;

        for (int i = 0; i < arrOne.Length; i++)
        {
            arrOne[i] = char.Parse(Console.ReadLine());
        }
        
        Console.WriteLine();
        
        for (int i = 0; i < arrTwo.Length; i++)
		{
			arrTwo[i] = char.Parse(Console.ReadLine());
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

