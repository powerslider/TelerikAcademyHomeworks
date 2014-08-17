using System;
using System.Text;

public class Person
{
    public string Name { get; set; }
    public int? Age { get; set; }

    public Person(string name)
        : this(name, null)
    {
    }

    public Person(string name, int? age)
    {
        this.Name = name;
        this.Age = age;
    }

    public override string ToString()
    {
        StringBuilder result = new StringBuilder();
        result.AppendFormat("Name: {0}\n", this.Name);
        if (this.Age == null)
        {
            result.AppendLine("Age is not specified!");
        }
        else
        {
            result.AppendFormat("Age: {0}", this.Age);
        }

        return result.ToString();
    }
}
