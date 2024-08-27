// LINQ (Language Integrated Query) is a powerful feature in C# that enables querying of collections in a more readable and concise way.
// Introduced in C# 3.0, LINQ allows you to work with data from various sources (like databases, XML, collections, etc.) in a consistent manner.

// Key Features of LINQ:
// Unified Syntax: LINQ provides a consistent query syntax for different data sources (in-memory collections, databases, XML, etc.).
// Type Safety: LINQ queries are type-checked at compile time, reducing runtime errors.
// IntelliSense Support: Visual Studio provides IntelliSense for LINQ, making it easier to write queries.
// Readability: LINQ expressions are generally more readable and concise than traditional foreach loops or manual queries.
// Basic LINQ Query Structure
// A LINQ query typically has three parts:

// Data source: The collection or data structure you want to query.
// Query: The LINQ query that defines how to retrieve data.
// Execution: The query is executed to retrieve results.
// Here's a simple example with an array:

int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

// LINQ query
var evenNumbers = from num in numbers
                  where num % 2 == 0
                  select num;

// Execute the query
foreach (var n in evenNumbers)
{
    Console.WriteLine(n);
}


// LINQ Query Syntax vs. Method Syntax
// LINQ queries can be written in two ways: Query Syntax (SQL-like) and Method Syntax (using extension methods).

// Query Syntax Example:
var querySyntax = from num in numbers
                  where num % 2 == 0
                  select num;

// Method Syntax Example:
var methodSyntax = numbers.Where(num => num % 2 == 0);

// Both syntaxes produce the same result, but method syntax is more commonly used in practice.

// Common LINQ Operations
// Filtering: Where method or where keyword filters elements based on a condition.
// Projection: Select method or select keyword transforms the data.
// Sorting: OrderBy, OrderByDescending, ThenBy, ThenByDescending methods.
// Grouping: GroupBy method groups elements.
// Joining: Join method performs inner joins, GroupJoin for outer joins.
// Aggregating: Count, Sum, Average, Min, Max methods.