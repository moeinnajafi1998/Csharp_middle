// Casting in inheritance is an important concept in C# when working with object-oriented programming.
// It allows objects of one type to be treated as another type within the inheritance hierarchy.
// In C#, casting can be either implicit or explicit, depending on the relationship between the types involved.



// 1. Implicit Casting
// Implicit casting happens automatically by the C# compiler when the conversion is safe and no data loss occurs.
// In the context of inheritance, this usually involves casting a derived class object to a base class type.

class Animal
{
    public void Eat() => Console.WriteLine("Eating");
}

class Dog : Animal
{
    public void Bark() => Console.WriteLine("Barking");
}

class Program
{
    static void Main()
    {
        Dog dog = new Dog();
        Animal animal = dog;  // Implicit casting from Dog to Animal

        animal.Eat();  // Valid, as Eat is part of Animal
        // animal.Bark(); // Invalid, as Bark is not part of Animal
    }
}