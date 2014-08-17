using System;

public class Cat : Animal, ISound
{
    public Cat(string name, double age, Sex sex)
        : base(name, age, sex)
    {
    }
    
    public void ProduceSound()
    {
        Console.WriteLine("Miau, miau");
    }
}

