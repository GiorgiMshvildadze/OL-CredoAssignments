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
        Console.WriteLine("\nCircle with radius:" + radius);
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
        Console.WriteLine($"\nRectangle with the lenght of {Lenght} and width of {width}");
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

public class Triangle : Shape
{
    public double Side1 { get; set; }
    public double Side2 { get; set; }
    public double Side3 { get; set; }

    public Triangle(double side1, double side2, double side3)
    {
        Side1=side1;
        Side2=side2;
        Side3=side3;
        Console.WriteLine($"\nTriangle Created with Sides of {Side1}, {Side2}, {Side3}");
    }
    public override double CalculateArea()
    {
        double halfPerimeter = (Side1+Side2+Side3)/2;
        double areaSquared = halfPerimeter *(halfPerimeter-Side1)*(halfPerimeter-Side2)*(halfPerimeter-Side3);
        Area = Math.Sqrt(areaSquared);
        Console.WriteLine("Area :" + Area);
        return Area;
    }

    public override double CalculatePerimeter()
    {
        Perimeter = Side1 +Side2 +Side3;
        Console.WriteLine($"Perimeter: {Perimeter}");
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
        var triangle1 = new Triangle(3, 4, 5);
        triangle1.CalculatePerimeter();
        triangle1.CalculateArea();
    }
}
