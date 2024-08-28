
// The using keyword in C# serves multiple purposes, each related to resource management, code organization, and working with namespaces. 
// It has three primary uses:

// Namespace Declaration:
// The using keyword is commonly used to include namespaces in your code, allowing you to use classes, interfaces, and other types defined in those namespaces without needing to fully qualify them.

// Disposable Object Management:
// The using statement is used to ensure that objects that implement the IDisposable interface are disposed of correctly. This is particularly useful for managing resources like file handles, database connections, or network streams.

// Aliases for Namespaces or Types:
// The using directive can also be used to create an alias for a namespace or a type, making it easier to refer to those entities in your code.


// 1. using for Namespace Declaration
// When you want to use types from a particular namespace, you include the namespace with the using keyword at the top of your C# file. 
// This eliminates the need to fully qualify the types each time you use them.
using System;
using System.Collections.Generic;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 2, 3 };
            Console.WriteLine("Hello, World!");
        }
    }
}
// In this example:
// System and System.Collections.Generic are namespaces.
// You can use Console and List<T> directly without fully qualifying them as System.Console or System.Collections.Generic.List<T>.


// 2. using for Resource Management
// The using statement ensures that an object is disposed of as soon as it goes out of scope.
// This is particularly useful for managing resources like files, database connections, 
// or any other resources that need to be released when done.
using (var stream = new FileStream("file.txt", FileMode.Open))
{
    // Work with the stream
    byte[] buffer = new byte[stream.Length];
    stream.Read(buffer, 0, buffer.Length);
    Console.WriteLine("File read successfully.");
}  // The stream is automatically disposed of here.
// In this example:
// The FileStream object stream is disposed of automatically when the using block ends.
// This is equivalent to manually calling stream.Dispose() but ensures that Dispose is called even if an exception occurs within the block.


// 3. using for Aliases
// Sometimes you might want to create an alias for a long or complex namespace, or when two namespaces contain types with the same name. 
// The using directive can be used for this purpose.
using ProjectA = Company.ProjectA.Module;
using List = System.Collections.Generic.List<int>;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ProjectA.ClassA obj = new ProjectA.ClassA();
            List myList = new List { 1, 2, 3 };
        }
    }
}
// In this example:
// ProjectA is an alias for the namespace Company.ProjectA.Module.
// List is an alias for the generic List<int> type from System.Collections.Generic.