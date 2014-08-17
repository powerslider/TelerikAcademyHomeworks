using System;

class PrintQuotedString
{
    static void Main()
    {
        string quote1 = "The \"use\" of quotations causes difficulties."; 
        string quote2 = "The use of quotations causes difficulties.";

        Console.WriteLine("{0}\n", quote1);
        Console.WriteLine("{0}\n", quote2);     
    }
}

