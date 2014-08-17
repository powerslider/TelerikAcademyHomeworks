using System;

class PrintEmployeeRecord
{
    static void Main()
    {
        string firstName = "Ivan"; 
        string familyName = "Draganov";
        Console.WriteLine("First Name: "+firstName);
        Console.WriteLine("Family Name: "+familyName);
        
        byte age = 58;
        Console.WriteLine("Age: "+age);
        
        int isMale = 1;
        int isFemale = 1;
        bool equal = (isMale==isFemale);
        bool notEqual = (isMale > isFemale);
        if (equal)
        {
            Console.WriteLine("Gender: m");
        }
        else
        {
            Console.WriteLine("Gender: f");
        }

        int IDNumber = 1234;
        int decimalLength = IDNumber.ToString().Length + 6;
        Console.WriteLine("IDNumber: "+IDNumber.ToString("D" + decimalLength.ToString()));
        
        string employeeIDfixed = "2756";
        int employeeID = 0;
        int decimalLength1 = employeeID.ToString("D").Length + 3;
        Console.WriteLine("EmployeeID: " + employeeIDfixed + employeeID.ToString("D" + decimalLength1.ToString()));
    }
}
