using System;
using System.Collections.Generic;
using System.Linq;

class TestProgram
{
    static void Main()
    {
        List<Student> students = new List<Student>()
        {
            new Student{FirstName = "Pesho", LastName = "Petrov", Grade = 2.3},
            new Student{FirstName = "Gosho", LastName = "Goshev", Grade = 3.2},
            new Student{FirstName = "Tenio", LastName = "Gogov", Grade = 5.1},
            new Student{FirstName = "Gaco", LastName = "Bacov", Grade = 4.4},
            new Student{FirstName = "Kolio", LastName = "Fichkata", Grade = 5.3},
            new Student{FirstName = "Vanio", LastName = "Tupoto", Grade = 3.6},
            new Student{FirstName = "Kiro", LastName = "Traktorista", Grade = 4.3},
            new Student{FirstName = "Asan", LastName = "Mangala", Grade = 5.9},
            new Student{FirstName = "Gunio", LastName = "Prostiq", Grade = 2.1},
            new Student{FirstName = "Mincho", LastName = "Praznikov", Grade = 5.6},
        };

        Console.WriteLine("----------Students----------\n");
        var grades = students.OrderBy(x => x.Grade);
        foreach (var grade in grades)
        {
            Console.WriteLine(String.Format("{0} {1} - {2}", grade.FirstName, grade.LastName, grade.Grade));
        }

        Console.WriteLine("\n\n");

        List<Worker> workers = new List<Worker>()
        {
            new Worker{FirstName = "Pesho", LastName = "Idiota", HourlyWage = 38.3},
            new Worker{FirstName = "Misho", LastName = "Birata", HourlyWage = 10.2},
            new Worker{FirstName = "Ivan", LastName = "Ivanov", HourlyWage = 35.1},
            new Worker{FirstName = "Mariq", LastName = "Petrova", HourlyWage = 9.4},
            new Worker{FirstName = "Kolio", LastName = "Kolev", HourlyWage = 50.3},
            new Worker{FirstName = "Bojidar", LastName = "Flegmata", HourlyWage = 17.6},
            new Worker{FirstName = "Raicho", LastName = "Raichev", HourlyWage = 21.6},
            new Worker{FirstName = "Goiko", LastName = "Piqndeto", HourlyWage = 15.9},
            new Worker{FirstName = "Muncho", LastName = "Ludiq", HourlyWage = 7.1},
            new Worker{FirstName = "Emo", LastName = "Rimata", HourlyWage = 16.6},
        };

        Console.WriteLine("----------Workers----------\n");
        var wages = workers.OrderByDescending(x => x.HourlyWage);
        foreach (var wage in wages)
        {
            Console.WriteLine(String.Format("{0} {1} - {2}", wage.FirstName, wage.LastName, wage.HourlyWage));
        }

        Console.WriteLine("\n\n");

        Console.WriteLine("------Students and Workers------\n");
        List<dynamic> names = new List<dynamic>();
        
        foreach (var name in students)
        {
            names.Add(name);
        }

        foreach (var name in workers)
        {
            names.Add(name);
        }

        var sortedNames = from name in names
                          orderby name.FirstName, name.LastName
                          select name;

        foreach (var name in sortedNames)
        {
            Console.WriteLine("{0} {1}", name.FirstName, name.LastName);
        }
        Console.WriteLine();
    }
}

