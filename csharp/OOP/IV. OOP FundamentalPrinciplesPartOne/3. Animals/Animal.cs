using System;

public enum Sex
{
    Male,
    Female
}

public abstract class Animal
{
    public string Name { get; set; }
    public double Age { get; set; }
    public Sex Sex { get; set; }

    public Animal(string name, double age, Sex sex)
    {
        this.Name = name;
        this.Age = age;
        this.Sex = sex;
    }

    public override string ToString()
    {
 	    string result = String.Format("Name: {0}\nType: {1}\nAge: {2}\nSex: {3}\n\n",
            this.Name, this.GetType(), this.Age, this.Sex);

        return result;
    }
}

