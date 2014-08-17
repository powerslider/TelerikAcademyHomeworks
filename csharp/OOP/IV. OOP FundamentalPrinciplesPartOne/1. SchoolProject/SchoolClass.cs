using System;
using System.Collections.Generic;

public class SchoolClass : ICommentable
{
    private List<Student> students;
    private List<Teacher> teachers;
    private char classID;

    public List<Student> Students { get; set; }
    public List<Teacher> Teachers { get; set; }
    public char ClassID { get; set; }

    public SchoolClass(char classID, List<Student> students, List<Teacher> teachers)
    {
        this.ClassID = classID;
        this.Students = students;
        this.Teachers = teachers;
        
    }

    public SchoolClass(char classID, List<Student> students)
        : this(classID, students, new List<Teacher>())
    {
    }

    public SchoolClass(char classID)
        : this(classID, new List<Student>(), new List<Teacher>())
    {
    }

    public List<string> Comment { get; set; }

    public void AddComment(string comment)
    {
        Comment.Add(comment);
    }

    public override string ToString()
    {
        string result = String.Format("ClassID: {0}\n",
            this.ClassID);

        return result;
    }
}

