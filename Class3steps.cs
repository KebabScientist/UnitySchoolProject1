using System;

public class Animal
{
    public string Name { get; set; }

    public Animal(string name)
    {
        Name = name;
    }

    public void Eat()
    {
        Console.WriteLine($"{Name} is eating.");
    }
}

public class Mammal : Animal
{
    public int NumberOfLegs { get; set; }

    public Mammal(string name, int numberOfLegs) : base(name)
    {
        NumberOfLegs = numberOfLegs;
    }

    public void Walk()
    {
        Console.WriteLine($"{Name} is walking on {NumberOfLegs} legs.");
    }
}

public class Dog : Mammal
{
    public string Breed { get; set; }

    public Dog(string name, int numberOfLegs, string breed) : base(name, numberOfLegs)
    {
        Breed = breed;
    }

    public void Bark()
    {
        Console.WriteLine($"{Name}, the {Breed}, is barking.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Dog myDog = new Dog("Rex", 4, "German Shepherd");
        myDog.Eat();
        myDog.Walk();
        myDog.Bark();
    }
}
