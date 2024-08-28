using System;
using System.IO;

class Program
{
    static void Main()
    {
        string path = "test.txt";

        // Using StreamWriter to append to a file
        using (StreamWriter writer = new StreamWriter(path, append: true))
        {
            writer.WriteLine("\nThis line is appended.");
        }

        Console.WriteLine("Content appended successfully.");
    }
}
