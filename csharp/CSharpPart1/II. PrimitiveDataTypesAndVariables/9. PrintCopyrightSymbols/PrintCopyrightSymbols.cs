using System;
using System.Text;

class PrintCopyrightSymbols
{
    static void Main()
    {
        // unicode code of copyright symbol
        char symbol = '\u00A9';     
        
        // this helps you to print the copyright symbol on the console
        Console.OutputEncoding = Encoding.UTF8;       
        
        // the '@' symbol states that everything after it will be accepted literally
        Console.Write(@"
                     {0}
                    {0} {0}
                   {0}   {0}
                  {0} {0} {0} {0}", symbol);
        
        Console.WriteLine("\n");
    }
}
