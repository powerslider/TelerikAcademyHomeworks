using System;

public class Tomcat : Cat, ISound
{
    public Tomcat(string name, double age, Sex sex)
        : base(name, age, sex)
    {
        if (base.Sex != Sex.Male)
        {
            throw new ArgumentException("Tomcats can be only male!!!");
        }
    }

    public void ProduceSound()
    {
        Console.WriteLine("Tomcat: Miau, miau");
    }
}

