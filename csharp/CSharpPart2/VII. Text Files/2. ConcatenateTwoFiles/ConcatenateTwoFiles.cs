using System;
using System.IO;
using System.Text;

class TwoTextFiles
{
    static void Main()
    {
        Console.WriteLine("Enter first file");
        StreamWriter first = new StreamWriter("firstFile.txt");

        using (first)
        {
            string firstFile = Console.ReadLine();
            first.WriteLine(firstFile);
        }

        StreamWriter second = new StreamWriter("secondFIle.txt");
        Console.WriteLine("Enter second file:");

        using (second)
        {
            string secondFile = Console.ReadLine();
            second.WriteLine(secondFile);
        }

        StreamReader firstF = new System.IO.StreamReader("firstFile.txt");
        string readFirst = firstF.ReadToEnd();
        firstF.Close();

        StreamReader secondF = new System.IO.StreamReader("secondFile.txt");
        string readSecond = secondF.ReadToEnd();
        secondF.Close();

        FileStream third;
        third = new FileStream("firstFile.txt", FileMode.Create, FileAccess.Write);
        StreamWriter writer = new StreamWriter(third);
        writer.WriteLine(readFirst);
        writer.WriteLine(readSecond);

        writer.Close();
        third.Close();
    }
}
