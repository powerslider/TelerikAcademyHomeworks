using System;

public class TestGenericList
{
    static void Main()
    {
        GenericList<int> intList = new GenericList<int>();
        intList.Add(5);
        intList.Add(6);
        intList.Add(7);
        intList.Add(8);
        intList.Add(10); 
        Console.WriteLine(intList); 
        
        intList.Remove(0);
        Console.WriteLine(intList); 
        
        intList.Insert(9, 3);
        Console.WriteLine(intList); 
        
        int searchedInt = intList.ValueOf(0);
        Console.WriteLine(searchedInt);

        int searchedIntIndex = intList.IndexOf(7);
        Console.WriteLine(searchedIntIndex);
        //intList.Clear();

        GenericList<string> stringList = new GenericList<string>();
        stringList.Add("Monday");
        stringList.Add("Tuesday");
        stringList.Add("Wednesday");
        stringList.Add("Thursday");
        stringList.Add("Friday");
        stringList.Add("Saturday");
        stringList.Add("Sunday");
        Console.WriteLine(stringList);
        
        stringList.Remove(2);
        Console.WriteLine(stringList);

        stringList.Insert("Wednesday", 2);
        Console.WriteLine(stringList);

        string searchedString = stringList.ValueOf(0);
        Console.WriteLine(searchedString);

        int searchedStringIndex = stringList.IndexOf("Sunday");
        Console.WriteLine(searchedStringIndex);
        //stringList.Clear();       
    }
}
