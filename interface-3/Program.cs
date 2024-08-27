public interface IShape
{
    double Area();
    double Perimeter();
}

public class Rectangle : IShape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public double Area()
    {
        return Width * Height;
    }

    public double Perimeter()
    {
        return 2 * (Width + Height);
    }
}

public class Circle : IShape
{
    public double Radius { get; set; }

    public double Area()
    {
        return Math.PI * Radius * Radius;
    }

    public double Perimeter()
    {
        return 2 * Math.PI * Radius;
    }
}

public class Program
{
    public static void Main()
    {
        IShape rectangle = new Rectangle { Width = 5, Height = 10 };
        IShape circle = new Circle { Radius = 7 };

        Console.WriteLine($"Rectangle Area: {rectangle.Area()}");
        Console.WriteLine($"Circle Area: {circle.Area()}");
    }
}
