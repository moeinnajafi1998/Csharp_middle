// The static keyword in C# is used to declare static members, which are shared among all instances of a class.
// This means that the member belongs to the type itself rather than to a specific instance of the type.
// The static keyword can be applied to classes, fields, methods, properties, constructors, operators, events, and even local variables.

// Key Concepts of static in C#:
// Static Class:

// A class can be declared as static if it only contains static members. A static class cannot be instantiated, meaning you cannot create objects of it.
public static class MathHelper
{
    public static double Pi = 3.14159;
    public static double Square(double number) => number * number;
}

// Static Members:

// Static members are shared across all instances of a class. A static field or property retains its value between different calls.
// Example:
public class Counter
{
    public static int Count = 0;
    public Counter()
    {
        Count++;
    }
}

// Static Methods:

// Static methods can only access other static members (variables or methods) directly. They cannot access instance members.
// Example:
public class Calculator
{
    public static int Add(int a, int b) => a + b;
}

// Static Constructors:

// A static constructor is used to initialize any static data, or to perform actions that need to be performed only once.
// It is called automatically before any static members are accessed or any instances are created.
// Example:
public class Logger
{
    public static string LogPath;
    static Logger()
    {
        LogPath = "default.log";
    }
}

//Static Variables:

// Static variables (fields) maintain their value for the lifetime of the application.
// Example:
public class Session
{
    public static string? UserName;
}

// Static Local Functions:

// C# 8.0 introduced the ability to declare static local functions.
// These are functions defined inside a method that cannot access any instance variables or methods from the containing class.
// Example:
// void Calculate()
// {
//     static int Multiply(int x, int y) => x * y;
//     var result = Multiply(5, 10);
// }


class Program{
    static void Main(string[] args){

    }
}