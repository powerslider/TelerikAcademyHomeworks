using System;

public class Frog : Animal, ISound
{
    public Frog(string name, double age, Sex sex)
        : base(name, age, sex)
    {
    }

    public void ProduceSound()
    {
        Console.WriteLine("Ribbit, ribbit");
    }
}

