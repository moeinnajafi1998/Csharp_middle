using System;
using System.Collections.Generic;
using System.Linq;

class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        var people = new List<Person>
        {
            new Person { Name = "Alice", Age = 30 },
            new Person { Name = "Bob", Age = 25 },
            new Person { Name = "Charlie", Age = 35 },
        };

        // Filter and select
        var filtered = people.Where(p => p.Age > 25).Select(p => p.Name);

        Console.WriteLine("Filtered Names (Age > 25):");
        foreach (var name in filtered)
        {
            Console.WriteLine(name);
        }

        // Sorting
        var sorted = people.OrderBy(p => p.Name);

        Console.WriteLine("\nSorted by Name:");
        foreach (var person in sorted)
        {
            Console.WriteLine($"{person.Name}, {person.Age}");
        }

        // Grouping
        var grouped = people.GroupBy(p => p.Age >= 30);

        Console.WriteLine("\nGrouped by Age >= 30:");
        foreach (var group in grouped)
        {
            Console.WriteLine(group.Key ? "Age >= 30" : "Age < 30");
            foreach (var person in group)
            {
                Console.WriteLine($"  {person.Name}, {person.Age}");
            }
        }
    }
}