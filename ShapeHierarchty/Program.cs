namespace ShapeHierachy;

public abstract class Shape
{
    public double Perimeter { get; set; }
    public double Area { get; set; }

    public virtual double CalculatePerimeter()
    {
        return Perimeter;
    }
    public virtual double CalculateArea()
    {
        return Area;
    }
}

public class Circle : Shape
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
        Console.WriteLine("Circle with radius:" + radius);
    }
    public override double CalculatePerimeter()
    {
        Perimeter = 2 * Radius * Math.PI;
        Console.WriteLine($"Perimeter: {Perimeter}");
        return Perimeter;
    }
    public override double CalculateArea()
    {
        Area = Math.PI * Math.Pow(Radius, 2);
        Console.WriteLine($"Area: {Area}");
        return Area;
    }
}

public class Rectangle : Shape
{
    public double Lenght { get; set; }
    public double Widht { get; set; }

    public Rectangle(double lenght, double width)
    {
        Lenght = lenght;
        Widht = width;
        Console.WriteLine($"Rectangle with the lenght of {Lenght} and width of {width}");
    }

    public override double CalculateArea()
    {
        Area = Lenght * Widht;
        Console.WriteLine("Area: " + Area);
        return Area;
    }
    public override double CalculatePerimeter()
    {
        Perimeter = Lenght * 2 + Widht * 2;
        Console.WriteLine("Perimeter: " + Perimeter);
        return Perimeter;
    }
}
class Program
{
    static void Main(string[] args)
    {

        Shape circle1 = new Circle(5);
        circle1.CalculatePerimeter();
        circle1.CalculateArea();
        Shape rectangle1 = new Rectangle(5, 5);
        rectangle1.CalculatePerimeter();
        rectangle1.CalculateArea();

    }
}
