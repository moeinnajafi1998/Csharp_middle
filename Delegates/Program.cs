// Delegates
// A delegate is a type that represents references to methods with a particular parameter list and return type.
// In simpler terms, it's a way to define a method signature and then create instances that refer to methods matching that signature

using System;

public delegate void DisplayMessage(string message); // Declare a delegate

class Program
{
    public static void Main()
    {
        // Instantiate the delegate with a method
        DisplayMessage display = ShowMessage;
        
        // Call the delegate
        display("Hello, World!");
    }

    // Method that matches the delegate signature
    public static void ShowMessage(string message)
    {
        Console.WriteLine(message);
    }
}
