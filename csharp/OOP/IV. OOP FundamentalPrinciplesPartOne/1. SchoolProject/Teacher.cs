using System;
using System.Text;
using System.Collections.Generic;

public class Teacher : Human, ICommentable
{
    private List<string> disciplines;

    public List<string> Disciplines { get; set; }

    public Teacher(string teacherName, List<string> disciplines)
    {
        this.Name = teacherName;
        this.Disciplines = disciplines;
    }

    public Teacher(string teacherName) 
        : this(teacherName, new List<string>())
    {
    }

    public List<string> Comment { get; set; }

    public void AddComment(string comment)
    {
        Comment.Add(comment);
    }

    public override string ToString()
    {
        string result = String.Format("\nTeacher name: {0}\nProfile disciplines: {1}\n",
            this.Name, string.Join(" ,", Disciplines.ToArray()));

        return result;
    }
}

