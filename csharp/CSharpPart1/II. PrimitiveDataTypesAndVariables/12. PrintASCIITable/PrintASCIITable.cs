using System;

class PrintASCIITable
{
    static void Main()
    {
        int counter = 0;
        char symbol;
        
        // loop over all ASCII codes
        for (counter = 0; counter < 255; counter++)
        {
            // cast to "char" each code to print the relevant symbol
            symbol = (char)(counter);
            Console.WriteLine("{0}. {1}", counter, symbol);
        }
    }
}
