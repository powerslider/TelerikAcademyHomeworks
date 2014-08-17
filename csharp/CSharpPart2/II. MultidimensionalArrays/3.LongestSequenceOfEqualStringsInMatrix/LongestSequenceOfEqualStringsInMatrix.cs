using System;

class LongestSequenceOfEqualStringsInMatrix
{
    static void Main()
    {
        string[,] matrix = {
                            {"hga", "hgia", "ha", "hga"},

                            {"a", "hgga", "hl", "na"},

                            {"mna", "hgia", "hla", "na"},

                            {"ha", "kl", "hgla", "hga"} 
                        };
        int longest = 0;
        int currentLongest = 1;
        int m = 0, n = 0;
        bool hasNext = true;
        string strOfLongestSequence, str = null;

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                m += i;
                n += j;
                strOfLongestSequence = matrix[m , n];
                while (hasNext && m < matrix.GetLength(0) - 1 && 
                    n < matrix.GetLength(1) - 1 && matrix[m, n] != null)
                {
                    if (matrix[m, n] == matrix[m + 1, n])
                    {
                        matrix[m, n] = null;
                        m++;
                        currentLongest++;   
                    }
                    else if (matrix[m, n] == matrix[m + 1,n + 1])
                    {
                        matrix[m, n] = null;
                        m++;
                        n++;
                        currentLongest++; 
                    }
                    else if (matrix[m, n] == matrix[m, n + 1])
                    {
                        matrix[m, n] = null;
                        n++;
                        currentLongest++;
                    }
                    else
                    {
                        hasNext = false;
                    }
                }
                m = 0;
                n = 0;
                hasNext = true;                   

                if (currentLongest > longest)
                {
                    str = strOfLongestSequence;
                    longest = currentLongest;
                }
                currentLongest = 1;
            }          
        }
        Console.WriteLine(str);
        Console.WriteLine(longest + " times");           
    }
}

