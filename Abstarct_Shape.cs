abstract class Shape
{
    public abstract double CalculateArea();
}
class Rectangle : Shape
{
    public double Width { get; private set; }
    public double Height { get; private set; }

    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public override double CalculateArea()
    {
        Console.WriteLine($"Square of a rectangle:{Width * Height}");
        return Width * Height;
    }
}
class Circle : Shape
{
    public double Radius { get; private set; }
    public double Pi { get; private set; }

    public Circle(double radius, double pi)
    {
        Radius = radius;
        Pi = pi;

    }

    public override double CalculateArea()
    {
        Console.WriteLine($"Square of a circle: {Pi * Radius * Radius}");
        return Pi * Radius * Radius;
    }
}
class RightTriangle : Shape
{
    public Tuple<double, double> Legs { get; private set; }

    public RightTriangle(double a, double b)
    {
        Legs = new Tuple<double, double>(a, b);
    }

    public override double CalculateArea()
    {
        Console.WriteLine($"Square of a RightTriangle: {Legs.Item1 * Legs.Item2 * .5}");

        return Legs.Item1 * Legs.Item2 * .5;
    }
}
class Trapeze : Shape
{
    public double Top { get; private set; }
    public double Bottom { get; private set; }
    public double Height { get; private set; }

    public Trapeze(double top, double bottom, double height)
    {
        Top = top;
        Bottom = bottom;
        Height = height;
    }

    public override double CalculateArea()
    {
        Console.WriteLine($"Square of a Trapeze: {(Top + Bottom) * Height * .5}");
        return (Top + Bottom) * Height * .5;
    }
}

