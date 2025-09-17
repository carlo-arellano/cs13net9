namespace C06_Exercise_Inheritance;

public class Square : Rectangle
{
    public Square() { }

    public Square(double width) : base(height: width, width: width) { }

    public override double Height
    {
        set
        {
            base.Height = value;
            base.Width = value;
        }
    }

    public override double Width
    {
        set
        {
            base.Height = value;
            base.Width = value;
        }
    }
}
