
// In C#, StringBuilder is a class provided by the .NET framework that is used to efficiently manipulate strings. Unlike the string type, which is immutable (meaning that any modification to a string creates a new string), StringBuilder is mutable. This means that you can modify the contents of a StringBuilder object without creating a new object in memory. This makes StringBuilder particularly useful when you need to perform many repeated modifications, such as appending, inserting, or removing characters or substrings.

// Key Features of StringBuilder:
// Mutable Strings: You can change the contents of a StringBuilder object without creating new objects, which helps in reducing memory overhead and improving performance.

// Efficiency: It is more efficient than using string when performing multiple string operations, especially in loops, because it doesn't create multiple string objects.

// Dynamic Size: The internal buffer of StringBuilder automatically expands as needed when the length of the string increases, which means you don’t need to worry about resizing it manually.

// Common Methods:
// Append(string value): Appends the specified string to the end of the StringBuilder object.
// Insert(int index, string value): Inserts the specified string at the specified index.
// Remove(int startIndex, int length): Removes the specified number of characters from the StringBuilder starting at the specified index.
// Replace(string oldValue, string newValue): Replaces all occurrences of a specified string in the StringBuilder with another specified string.
// ToString(): Converts the contents of the StringBuilder to a string.

using System;
using System.Text;

class Program
{
    static void Main()
    {
        StringBuilder sb = new StringBuilder("Hello");
        sb.Append(" World"); // Modifies the existing StringBuilder object
        sb.Append("!");
        sb.Insert(5, ","); // Inserts a comma at index 5
        sb.Replace("World", "C#"); // Replaces "World" with "C#"
        sb.Remove(5, 1); // Removes the comma at index 5
        string result = sb.ToString(); // Converts StringBuilder to string
        
        Console.WriteLine(result); // Output: "Hello C#!"
    }
}