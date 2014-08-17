using System;
using System.IO;

class InsertLineNumbers
{
    static void Main()
    {
        string inputFile = @"..\..\file1.txt";
        string outputFile = @"..\..\file2.txt";
        try
        {
            StreamReader reader = new StreamReader(inputFile);
            StreamWriter writer = new StreamWriter(outputFile);
            using (reader)
            {
                using (writer)
                {
                    int lineNumber = 0;
                    string line = reader.ReadLine();
                    while (line != null)
                    {
                        lineNumber++;
                        writer.WriteLine("{0}. {1}", lineNumber, line);
                        line = reader.ReadLine();
                    }
                }
            }
        }
        catch (FileNotFoundException)
        {
            Console.Error.WriteLine("Cannot find file {0}.", inputFile);
        }
        catch (DirectoryNotFoundException)
        {
            Console.Error.WriteLine("Invalid directory in the file path.");
        }
        catch (IOException)
        {
            Console.Error.WriteLine("Cannot open the file {0}", inputFile);
        }
    }
}
