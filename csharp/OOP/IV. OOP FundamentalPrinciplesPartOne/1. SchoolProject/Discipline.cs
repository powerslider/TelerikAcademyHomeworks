using System;
using System.Collections.Generic;

public class Discipline : ICommentable
{
    private string name;
    private int numberOfLectures;
    private int numberOfExercises;

    public string Name { get; set; }
    public int NumberOfLectures { get; set; }
    public int NumberOfExercises { get; set; }

    public Discipline(string disciplineName)
        : this(disciplineName, 0, 0)
    {
       
    }
    public Discipline(string disciplineName, int numberOfLectures, int numberOfExercises)
    {
        this.Name = disciplineName;
        this.NumberOfLectures = numberOfLectures;
        this.NumberOfExercises = numberOfExercises;
    }

    public List<string> Comment { get; set; }

    public void AddComment(string comment)
    {
        Comment.Add(comment);
    }

    public override string ToString()
    {
        string result = String.Format("\nDiscipline name: {0}" + 
            "\nNumber of lectures: {1}" + "\nNumber of exercises: {2}",
            this.Name, this.NumberOfLectures, this.NumberOfExercises);

        return result;
    }
}

