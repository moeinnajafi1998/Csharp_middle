// Explicit Interface Implementation:
// A class can implement an interface explicitly, meaning the interface methods are only accessible through an instance of the interface.
// public class MyClass : IAnimal
// {
//     void IAnimal.MakeSound()
//     {
//         Console.WriteLine("Explicit implementation");
//     }
// }

// IAnimal animal = new MyClass();
// animal.MakeSound(); // Works fine

// MyClass myClass = new MyClass();
// // myClass.MakeSound(); // Error: MakeSound is not accessible here

// Interface Inheritance
// Interfaces can inherit from other interfaces. This allows you to build more complex contracts by composing simpler ones:
public interface IAnimal
{
    void MakeSound();
}

public interface IWildAnimal : IAnimal
{
    void Hunt();
}

public class Lion : IWildAnimal
{
    public void MakeSound()
    {
        Console.WriteLine("Roar");
    }

    public void Hunt()
    {
        Console.WriteLine("Lion is hunting");
    }
}


class Prgram{
    static void Main(string[] args){
        
    }
}
