using System;
using System.IO;

// 1. Writing to a File
// You can write text to a file using the StreamWriter class or the static methods in the File class.

class Program
{
    static void Main()
    {
        string path = "example.txt";

        // Using StreamWriter to write to a file
        using (StreamWriter writer = new StreamWriter(path))
        {
            writer.WriteLine("Hello, World!");
            writer.WriteLine("This is a test file.");
        }

        Console.WriteLine("File written successfully.");
    }
}
