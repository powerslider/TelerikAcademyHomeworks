using System;

class DeclareStringAndObjectVariables
{
    static void Main()
    {
        string element1 = "Hello";
        string element2 = "World";
        object element3 = (object)(element1 + " " + element2);  // every data type is also an object, so we are allowed to cast to "object"
        string element4 = (string)element3;                     // and every "object" can be any other data type, so we are allowed to cast back to "string"

        Console.WriteLine("{0}!\n", element4);

    }
}

