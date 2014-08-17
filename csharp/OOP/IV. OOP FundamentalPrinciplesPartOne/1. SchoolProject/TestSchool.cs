using System;
using System.Collections.Generic;

class TestSchool
{
    static void Main()
    {
        School school = new School("ГПЧЕ");
        Console.WriteLine(school);

        SchoolClass schoolClass = new SchoolClass('A');
        Console.WriteLine(schoolClass);

        Student pesho = new Student("Pesho", 23);
        Console.WriteLine(pesho);
  
        Discipline disciplines = new Discipline("Programing in C", 1, 1);
        Console.WriteLine(disciplines);

        List<string> teacherDisciplines = new List<string>();
        teacherDisciplines.Add("Informatics");
        teacherDisciplines.Add("Mathematics");

        Teacher marinov = new Teacher("Marinov", teacherDisciplines);
        Console.WriteLine(marinov);

    }
}

