namespace C06_Exercise_Inheritance;

public class Circle : Square
{
    public Circle() { }

    public Circle(double radius) : base(width: radius * 2) { }

    public double Radius
    {
        get
        {
            return Height / 2;
        }
        set
        {
            Height = value * 2;
        }
    }

    public override double Area
    {
        get
        {
            double radius = Height / 2;
            return radius * radius * Math.PI;
        }
    }
}