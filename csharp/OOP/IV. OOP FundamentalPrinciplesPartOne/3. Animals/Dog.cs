using System;

public class Dog : Animal, ISound
{
    public Dog(string name, double age, Sex sex)
        : base(name, age, sex)
    {
    }

    public void ProduceSound()
    {
        Console.WriteLine("Bark, bark");
    }
}

