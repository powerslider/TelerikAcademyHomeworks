using System;

class ReadNumber
{
    static int index = 0;
    
    static void Main()
    {
        int start = 1, end = 100;
        int[] numbers = new int[10];

        for (; ;)
        {
            int temp = ReadInteger(start, end);
            if (temp != -1)
            {
                numbers[index++] = temp;
                if (index == 10)
                {
                    break;
                }
            }              
        }

        foreach (int number in numbers)
        {
            Console.Write(number + " ");
        }
    }

    static int ReadInteger(int start, int end)
    {
        try
        {
            int num = int.Parse(Console.ReadLine());
            if (num < 0 || num < start || num > end)
            {
                throw new Exception();                    
            }
            return num;
        }
        catch (Exception)
        { 
            Console.WriteLine("Invalid number!");
            return -1;
        }
    }
}
