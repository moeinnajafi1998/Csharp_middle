// The this keyword refers to the current instance of the class and is also used as a modifier of the first parameter of an extension method.
// qualify members hidden by similar names
// To pass an object as a parameter to other methods
class Employee
{
    private string name;
    private decimal salary = 5000.00m;

    // Constructor:
    public Employee(string name)
    {
        // Use this to qualify the field, name:
        this.name = name;
    }

    // Show method:
    public void showEmployee()
    {
        Console.WriteLine("Name: {0}", name);
        // Passing the object to the CalcTax method by using this:
        Console.WriteLine("Taxes: {0:C}", Tax.CalcTax(this));
    }

    public decimal Salary
    {
        get { return salary; }
    }
}

class Tax
{
    public static decimal CalcTax(Employee E)
    {
        return 0.08m * E.Salary;
    }
}

class MainClass
{
    static void Main()
    {
        // Create objects:
        Employee E1 = new Employee("Moein najafi");

        // Display results:
        E1.showEmployee();
    }
}