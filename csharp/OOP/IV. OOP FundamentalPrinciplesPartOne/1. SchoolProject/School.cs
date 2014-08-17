using System;
using System.Collections.Generic;

public class School
{
    private string name;
    private List<SchoolClass> classes;

    public string Name { get; set; }
    public List<SchoolClass> Classes { get; set; }

    public School(string schoolName, List<SchoolClass> classes)
    {
        this.Name = schoolName;
        this.Classes = classes;
    }

    public School(string schoolName)
        : this(schoolName, new List<SchoolClass>())
    {
    }

    public override string ToString()
    {
        string result = String.Format("\nSchool name: {0}\n",
            this.Name);

        return result;
    }
}

