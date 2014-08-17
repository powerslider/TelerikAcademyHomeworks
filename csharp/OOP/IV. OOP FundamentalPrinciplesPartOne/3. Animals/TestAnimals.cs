using System;
using System.Collections.Generic;
using System.Linq;

class TestAnimals
{
    static void Main()
    {
        Dog dog = new Dog("Sparkie", 18, Sex.Male);
        Console.WriteLine(dog.ToString());

        Frog frog = new Frog("Kermit", 15, Sex.Male);
        Console.WriteLine(frog.ToString());

        Cat cat = new Cat("TheBigCat", 6, Sex.Female);
        Console.WriteLine(cat.ToString());

        Kitten kitten = new Kitten("Kittie", 1, Sex.Female);
        //Kitten kitten = new Kitten("Kittie", 1, Sex.Male); //incorrect
        Console.WriteLine(kitten.ToString());

        Tomcat tomcat = new Tomcat("Tom", 5, Sex.Male);
        //Tomcat tomcat = new Tomcat("Tom", 5, Sex.Female); // incorrect
        Console.WriteLine(tomcat.ToString());

        Console.WriteLine();
        dog.ProduceSound();
        frog.ProduceSound();
        cat.ProduceSound();
        kitten.ProduceSound();
        tomcat.ProduceSound();
        Console.WriteLine();

        List<Dog> dogs = new List<Dog>();
        dogs.Add(new Dog("Sharo", 2, Sex.Male));
        dogs.Add(new Dog("Rex", 5, Sex.Male));
        dogs.Add(new Dog("Roshla", 3, Sex.Female));
        dogs.Add(dog);

        double averageAge = dogs.Average(x => x.Age);
        Console.WriteLine("Average age of dogs is {0}.", averageAge);

        List<Frog> frogs = new List<Frog>();
        frogs.Add(new Frog("Toad", 12, Sex.Male));
        frogs.Add(new Frog("Big Toad", 8, Sex.Male));
        frogs.Add(new Frog("Ugly Frog", 3, Sex.Female));
        frogs.Add(frog);

        averageAge = frogs.Average(x => x.Age);
        Console.WriteLine("Average age of frogs is {0}.", averageAge);

        List<Cat> cats = new List<Cat>();
        cats.Add(new Cat("TopCat", 10, Sex.Male));
        cats.Add(new Cat("Black Cat", 7, Sex.Male));
        cats.Add(new Cat("Kittle", 4, Sex.Female));
        cats.Add(cat);

        averageAge = cats.Average(x => x.Age);
        Console.WriteLine("Average age of cats is {0}.", averageAge);

        List<Kitten> kittens = new List<Kitten>();
        kittens.Add(new Kitten("Huggie", 1, Sex.Female));
        kittens.Add(new Kitten("Pussycat", 2.5, Sex.Female));
        kittens.Add(new Kitten("Cuttie", 6, Sex.Female));
        kittens.Add(kitten);

        averageAge = kittens.Average(x => x.Age);
        Console.WriteLine("Average age of kittens is {0}.", averageAge);

        List<Tomcat> tomcats = new List<Tomcat>();
        tomcats.Add(new Tomcat("Dirty Puss", 4, Sex.Male));
        tomcats.Add(new Tomcat("Gray Tomcat", 8.5, Sex.Male));
        tomcats.Add(new Tomcat("Blackie", 12.5, Sex.Male));
        tomcats.Add(tomcat);

        averageAge = tomcats.Average(x => x.Age);
        Console.WriteLine("Average age of tomcats is {0}.", averageAge);

        Console.WriteLine();



    }
}

