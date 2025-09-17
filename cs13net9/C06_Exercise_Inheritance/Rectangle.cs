namespace C06_Exercise_Inheritance;

public class Rectangle : Shape
{
    public Rectangle() { }

    public Rectangle(double height, double width)
    {
        this.Height = height;
        this.Width = width;
    }

    public override double Area
    {
        get
        {
            return this.Height * this.Width;
        }
    }

}