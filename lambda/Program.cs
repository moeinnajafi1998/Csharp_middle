// Lambda expressions in C# are a concise way to represent anonymous methods (methods without a name) using a syntax that resembles mathematical functions. 
// They are particularly useful in scenarios where you need to pass a short piece of code as an argument to methods like those found in LINQ (Language Integrated Query) queries.

// Basic Syntax
// The syntax of a lambda expression is as follows:
// (parameters) => expression_or_statement_block
// Parameters: A comma-separated list of input parameters.
// =>: The "goes to" operator, which separates the parameters from the body of the expression.
// Expression_or_statement_block: This is either a single expression or a block of statements.

// Example:
Func<int, int> square = x => x * 2;
// This creates a lambda expression that takes an integer x and returns its square.
// The lambda expression x => x * 2 is equivalent to:
// int Square(int x)
// {
//     return x * 2;
// }

// Multiple Parameters:
Func<int, int, int> add = (x, y) => x + y;

// No Parameters:
Action greet = () => Console.WriteLine("Hello, World!");

// Block of Statements
Func<int, int, int> subtract = (x, y) =>
{
    int result = x - y;
    return result;
};

// Lambda Expressions and Delegates
// Lambda expressions can be assigned to delegates, which are references to methods. The Func, Action, and Predicate delegates are commonly used with lambda expressions.

// Func<T, TResult>: A delegate that takes a parameter of type T and returns a result of type TResult.
// Action<T>: A delegate that takes a parameter of type T and returns void.
// Predicate<T>: A delegate that takes a parameter of type T and returns a bool.
// Usage with LINQ
// Lambda expressions are extensively used in LINQ queries. For example:
List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
var evenNumbers = numbers.Where(n => n % 2 == 0).ToList();

// Type Inference
// C# compiler can often infer the type of the parameters in a lambda expression, so you don't need to explicitly specify them. For instance:
Func<int, int> square2 = x => x * 2;

// Lambda Expressions and Expression Trees
// Lambda expressions can also be used to create expression trees, which are data structures representing code. This is useful in scenarios like building dynamic queries:
// Expression<Func<int, bool>> isEven = num => num % 2 == 0;
