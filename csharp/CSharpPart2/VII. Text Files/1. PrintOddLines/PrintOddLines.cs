using System;
using System.IO;


class oddLines
{
    static void Main()
    {
        StreamReader reader = new StreamReader("doc.txt");
        using (reader)
        {
            string content = reader.ReadLine();
            int numOfLine = 0;
            while (content != null)
            {

                numOfLine++;
                if (numOfLine % 2 == 1)
                {
                    Console.WriteLine(content);
                }
                content = reader.ReadLine();
            }
        }
    }
}