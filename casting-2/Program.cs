// Casting in inheritance is an important concept in C# when working with object-oriented programming.
// It allows objects of one type to be treated as another type within the inheritance hierarchy.
// In C#, casting can be either implicit or explicit, depending on the relationship between the types involved.




// 2. Explicit Casting
// Explicit casting is required when there is a potential for data loss or when the compiler cannot automatically determine that the cast is safe.
// In the context of inheritance, explicit casting is often used to cast from a base class to a derived class.
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
        Animal animal = new Dog();  // Implicit cast (Animal reference, Dog object)
        Dog dog = (Dog)animal;  // Explicit cast from Animal to Dog

        dog.Bark();  // Valid, as the underlying object is actually a Dog
    }
}