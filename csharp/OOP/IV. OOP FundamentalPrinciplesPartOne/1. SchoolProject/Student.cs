using System;
using System.Collections.Generic;

 public class Student : Human, ICommentable
{   
    private int classNumber;

    public int ClassNumber { get; set; }

    public Student(string studentName, int classNumber)
    {
        this.Name = studentName;
        this.ClassNumber = classNumber;
    }

    public List<string> Comment { get; set; }

    public void AddComment(string comment)
    {
        Comment.Add(comment);
    }

    public override string ToString()
    {
        string result = String.Format("Student name: {0}\nClass No.{1}", 
            this.Name, this.ClassNumber);

        return result;
    }
}

