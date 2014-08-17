using System;

class ArrayOfStringsSort
{
    static void Main(string[] args)
    {
        string[] array = { "Pesho", "Ivan", "Stefan", "Stanislav", "Ani", "Gosho", "Mitko", "Tim", "Simeon"};
        array = SortArray(array);

        foreach (string item in array)
        {
            Console.WriteLine(item);
        }
    }

    public static string[] SortArray(string[] array)
    {
        int min, indexOfMin;
        string temp;

        for (int i = 0; i < array.GetLength(0) - 1; i++)
        {
            indexOfMin = i;
            min = array[i].Length;
            for (int j = i + 1; j < array.GetLength(0); j++)
            {
                if (array[j].Length < min)
                {
                    min = array[j].Length;
                    indexOfMin = j;
                }                    
            }
            if (array[i].Length != min)
	        {
                temp = array[i];
                array[i] = array[indexOfMin];
                array[indexOfMin] = temp;                    
	        }               
        }

        return array;
    }
}

