using System;

class PrintVariableInHexFormat
{
    static void Main()
    {
        int a = 254;
        char hexFormat1 = 'F';
        char hexFormat2 = 'E';
        
        Console.WriteLine("The code of {0} in the hexidecimal system is {1}{2}.\n", a, hexFormat1, hexFormat2);
    }
}