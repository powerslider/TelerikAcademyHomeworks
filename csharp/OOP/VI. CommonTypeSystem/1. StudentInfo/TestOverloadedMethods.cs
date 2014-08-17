using System;

class TestOverloadedMethods
{
    static void Main()
    {
        Student firstStudent = new Student("Pesho", "Petrov", "Georgiev", 123456789,
            "PeshoStreet 5", 0885132669, "pesho@gmail.com", 1, University.TU_Sofia,
            Faculty.FacultyOfGermanEngineering, Specialty.ComputerSystemsAndTechnology);

        Student secondStudent = new Student("Pesho", "Petrov", "Georgiev", 987654321,
            "PeshoStreet 7", 0887785764, "pesho_trepach@gmail.com", 1, University.TU_Sofia,
            Faculty.FacultyOfGermanEngineering, Specialty.ComputerSystemsAndTechnology);

        Student thirdStudent = new Student("Gosho", "Petrov", "Georgiev", 987654321,
            "PeshoStreet 7", 0885985764, "gosho@gmail.com", 1, University.TU_Sofia,
            Faculty.FacultyOfGermanEngineering, Specialty.ComputerSystemsAndTechnology);

        Student fourthStudent = new Student("Gosho", "Petrov", "Georgiev", 987654321,
            "PeshoStreet 7", 0885985764, "gosho_trepach@gmail.com", 1, University.SofiaUniversity,
            Faculty.FacultyOfMathematicsAndInformatics, Specialty.SoftwareEngineering);

        Console.WriteLine(firstStudent);

        
        if (firstStudent == secondStudent)
        {
            Console.WriteLine("The first student matches the second!");
        }

        if (thirdStudent == secondStudent)
        {
            Console.WriteLine("The second student matches the third!");
        }

        if (thirdStudent == fourthStudent)
        {
            Console.WriteLine("The third student matches the fourth!");
        }

        if (firstStudent != fourthStudent)
        {
            Console.WriteLine("The first student doesn't match the fourth!");
        }


        Console.WriteLine();
        Console.WriteLine(firstStudent.GetHashCode());    //collision
        Console.WriteLine(secondStudent.GetHashCode());   //collision
        Console.WriteLine(thirdStudent.GetHashCode());
        Console.WriteLine(fourthStudent.GetHashCode());
        Console.WriteLine();

        Student fifthStudent = (Student)firstStudent.Clone();
        Console.WriteLine("-----------Cloned copy------------");
        Console.WriteLine(fifthStudent);                  //cloned data from "firstStudent" to a new student

        Console.WriteLine("Compare first student to second: {0}", firstStudent.CompareTo(secondStudent));
        Console.WriteLine("Compare second student to third: {0}", secondStudent.CompareTo(thirdStudent));
        Console.WriteLine("Compare third student to fourth: {0}", thirdStudent.CompareTo(fourthStudent));
        Console.WriteLine();
    }
}

