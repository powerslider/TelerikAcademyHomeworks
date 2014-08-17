using System;

class PrintLettersAndIndexes
{
    static void Main()
    {
        int n = 26;
        char[] letters = new char[n * 2];
        for (int i = 0; i < letters.Length / 2; i++)
        {
            letters[i] = (char)(i + 65);
        }
        for (int i = letters.Length / 2; i < letters.Length; i++)
		{
            letters[i] = (char)(i + 97);
		}

        string word = Console.ReadLine();

        for (int i = 0; i < word.Length; i++)
        {
            Console.Write("[{0}] ", word[i] - 65);
        }
    }
}

