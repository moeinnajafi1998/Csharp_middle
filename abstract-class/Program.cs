// an abstract class is a class that cannot be instantiated on its own and is meant to be a base class for other classes.
// It provides a way to define methods and properties that must be implemented by derived classes.
// Here are some key points about abstract classes in C#:
public abstract class Animal
{
    public abstract void MakeSound();
    
    public void Eat()
    {
        Console.WriteLine("Eating...");
    }
}

public class Cat : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Meow");
    }
}

public class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Bark");
    }
}

public class Program
{
    public static void Main()
    {
        Animal myCat = new Cat();
        myCat.MakeSound(); // Outputs: Meow
        myCat.Eat();       // Outputs: Eating...
        
        Animal myDog = new Dog();
        myDog.MakeSound(); // Outputs: Bark
        myDog.Eat();       // Outputs: Eating...
    }
}
