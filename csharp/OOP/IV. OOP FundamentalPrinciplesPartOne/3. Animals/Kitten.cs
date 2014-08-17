using System;

public class Kitten : Cat, ISound
{
    public Kitten(string name, double age, Sex sex)
        : base(name, age, sex)
    {
        if (base.Sex != Sex.Female)
        {
            throw new ArgumentException("Kittens can be only female!!!");
        }
    }

    public void ProduceSound()
    {
        Console.WriteLine("Kitten: Miau, miau");
    }
}

