
// Method overriding in C# is a feature of object-oriented programming that allows a subclass to provide a specific implementation of a method that is already defined in its base (or parent) class.
// This is useful when a subclass needs to change or extend the behavior of a method inherited from its parent class.

// Key Concepts of Method Overriding
// Inheritance: Method overriding only works with inheritance.
// A derived (child) class inherits methods and properties from a base (parent) class.
// To override a method, the method must first exist in the base class.

// virtual keyword: In the base class, the method that is intended to be overridden in the derived class is marked with the virtual keyword.

// override keyword: In the derived class, the method that is overriding the base class method is marked with the override keyword.

// Method signature: The method in the derived class must have the same name, return type, and parameters as the method in the base class.

// Polymorphism: Method overriding is a key component of runtime polymorphism in C#. When a method is overridden, the version of the method that gets called is determined by the object instance, not the reference type.

// Example of Method Overriding

using System;

public class Animal
{
    // Base class method
    public virtual void MakeSound()
    {
        Console.WriteLine("The animal makes a sound");
    }
}

public class Dog : Animal
{
    // Derived class overrides the MakeSound method
    public override void MakeSound()
    {
        Console.WriteLine("The dog barks");
    }
}

public class Cat : Animal
{
    // Derived class overrides the MakeSound method
    public override void MakeSound()
    {
        Console.WriteLine("The cat meows");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Animal myAnimal = new Animal();
        Animal myDog = new Dog();
        Animal myCat = new Cat();

        myAnimal.MakeSound();  // Output: The animal makes a sound
        myDog.MakeSound();     // Output: The dog barks
        myCat.MakeSound();     // Output: The cat meows
    }
}
// ------------------------------


// In C#, both abstract and virtual methods are used to achieve polymorphism, but they serve different purposes and have distinct characteristics. Here’s a comparison between the two:

// 1. Definition and Usage
// Abstract Method:

// An abstract method is a method declared in an abstract class that does not have a body; it only defines the method signature.
// Subclasses must override abstract methods; otherwise, they will also need to be declared as abstract.
// Abstract methods are used when the base class cannot provide any meaningful implementation, and it relies on derived classes to provide the specific behavior.
// public abstract class Animal
// {
//     public abstract void MakeSound(); // No implementation here
// }

// public class Dog : Animal
// {
//     public override void MakeSound()
//     {
//         Console.WriteLine("The dog barks");
//     }
// }
// Virtual Method:

// A virtual method is a method in a base class that has a default implementation, but it can be overridden by derived classes if needed.
// Subclasses are not required to override virtual methods; they can choose to use the base class implementation as is.
// Virtual methods are used when a base class provides a general implementation that may or may not be overridden by derived classes.
// public class Animal
// {
//     public virtual void MakeSound()
//     {
//         Console.WriteLine("The animal makes a sound");
//     }
// }

// public class Dog : Animal
// {
//     public override void MakeSound()
//     {
//         Console.WriteLine("The dog barks");
//     }
// }
// 2. Implementation Requirement
// Abstract Method:

// No implementation is provided in the base class. It only defines the method signature.
// Must be overridden in derived classes.
// Virtual Method:

// A default implementation is provided in the base class.
// Can be overridden in derived classes, but it’s optional.
// 3. Class Context
// Abstract Method:

// Can only exist within an abstract class.
// The class that contains an abstract method must be abstract itself.
// The class cannot be instantiated directly.
// Virtual Method:

// Can exist in any class (does not require the class to be abstract).
// The class containing virtual methods can be instantiated.
// 4. Instantiability
// Abstract Method:

// The class containing an abstract method cannot be instantiated directly because it is abstract.
// Virtual Method:

// The class can be instantiated even if it contains virtual methods, as it is not abstract.
// 5. Design Intent
// Abstract Method:

// Used when you want to enforce that derived classes provide their own specific implementation of a method.
// Common in scenarios where the base class represents a concept that cannot be fully defined at that level.
// Virtual Method:

// Used when you want to provide a common default behavior but allow derived classes to modify or completely replace that behavior if necessary.
// Common in scenarios where a base implementation might work for most derived classes, but customization is sometimes needed.