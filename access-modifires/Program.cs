// Access modifiers in C# control the visibility and accessibility of classes, methods, and other members of a program.
// They define where a member can be accessed from within your code.
// C# has many access modifiers:

// public
// Description: Members declared as public are accessible from any other code in the same assembly or another assembly that references it. This is the most permissive access level.
// Usage: Used when you want to allow access to a class or member from anywhere.
// Example:
public class Car
{
    public string? Model;
    public void Drive() 
    {
        // Some implementation
    }
}

// private
// Description: Members declared as private are only accessible within the same class or struct. This is the most restrictive access level.
// Usage: Used when you want to encapsulate details and prevent them from being accessed outside the class.
// Example:
class Car2
{
    private string? model;
    private void StartEngine()
    {
        // Some implementation
    }
}

// protected
// Description: Members declared as protected are accessible within the same class and by derived classes.
// Usage: Used when you want to allow derived classes to access certain members of the base class while keeping them hidden from other classes.
// Example:
class Vehicle
{
    protected string? licensePlate;
}

class Car3 : Vehicle
{
    public void DisplayLicensePlate()
    {
        Console.WriteLine(licensePlate);
    }
}

// internal
// Description: Members declared as internal are accessible only within the same assembly, but not from another assembly.
// Usage: Used when you want to expose members to other classes in the same assembly but hide them from other assemblies.
// Example:
internal class Car4
{
    internal void Honk()
    {
        // Some implementation
    }
}

// protected internal
// Description: Members declared as protected internal are accessible within the same assembly or from derived classes in other assemblies.
// Usage: Combines the features of both protected and internal, allowing access from derived classes or within the same assembly.
// Example:
public class Vehicle2
{
    protected internal string? vinNumber;
}

// private protected
// Description: Members declared as private protected are accessible within the same class or derived classes, but only if those derived classes are in the same assembly.
// Usage: Combines the features of both private and protected, providing more restrictive access.
class Car5
{
    private protected void Repair()
    {
        // Some implementation
    }
}

// -------------
class Program{
    static void Main(string[] args){

    }
}