// 2. Reading from a File
// You can read text from a file using the StreamReader class or the static methods in the File class.
using System;
using System.IO;

class Program
{
    static void Main()
    {
        string path = "test.txt";

        // Using StreamReader to read from a file
        using (StreamReader reader = new StreamReader(path))
        {
            string content = reader.ReadToEnd();
            Console.WriteLine(content);
        }
    }
}