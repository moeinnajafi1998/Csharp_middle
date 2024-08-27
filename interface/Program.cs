// Interfaces in C# are a powerful feature that allows you to define a contract for what a class should do, without specifying how it should do it.
// Here’s a deep dive into interfaces:
public interface IAnimal
{
    void MakeSound();
    void Eat();
}

public class Dog : IAnimal
{
    public void MakeSound()
    {
        Console.WriteLine("Bark");
    }

    public void Eat()
    {
        Console.WriteLine("Dog is eating");
    }
}

public class Cat : IAnimal
{
    public void MakeSound()
    {
        Console.WriteLine("Meow");
    }

    public void Eat()
    {
        Console.WriteLine("Cat is eating");
    }
}


// Key Characteristics of Interfaces
// Cannot Contain Implementation: Interfaces cannot contain any implementation for the methods they declare.
// They only define the signature of methods, properties, events, or indexers.

// Multiple Inheritance: A class can implement multiple interfaces, which allows you to combine different sets of functionalities.
// This is C#'s way of handling multiple inheritance.

// Default Implementations (C# 8.0 and later): Starting with C# 8.0, interfaces can provide default implementations for methods.
// This allows you to add new methods to interfaces without breaking existing implementations.

public interface IAnimal2
{
    void MakeSound();
    void Eat();

    // Default implementation
    public void Sleep()
    {
        Console.WriteLine("Sleeping...");
    }
}

// Properties, Events, and Indexers: Interfaces can also define properties, events, and indexers that implementing classes must provide.
public interface IAnimal3
{
    string Name { get; set; }
    void MakeSound();
}

public class Dog2 : IAnimal3
{
    public string Name { get; set; }

    public void MakeSound()
    {
        Console.WriteLine("Bark");
    }
}


class Prgram{
    static void Main(string[] args){
        
    }
}