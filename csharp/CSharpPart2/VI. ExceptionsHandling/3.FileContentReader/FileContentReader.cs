using System;
using System.IO;

class FileContentReader
{
    static void Main(string[] args)
    {
        try
        {
            string fullPath = @"C:\windows\win.ini";
            string text = File.ReadAllText(fullPath);
            Console.WriteLine(text);
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("File not found!");
        }
        catch (DirectoryNotFoundException)
        {
            Console.WriteLine("Directory not found!");
        }
        catch (PathTooLongException)
        {
            Console.WriteLine("The full path to the fail is too long!");
        }
        catch (ArgumentException)
        {
            Console.WriteLine("Empty path!");
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine("Access to file denied!");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            Console.WriteLine("exception");
        }
    }
}

