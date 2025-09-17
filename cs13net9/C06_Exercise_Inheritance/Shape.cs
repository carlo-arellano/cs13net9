namespace C06_Exercise_Inheritance;

public abstract class Shape
{
    protected double _height;
    protected double _width;

    public virtual double Height
    {
        get
        {
            return _height;
        }
        set
        {
            _height = value;
        }
    }

    public virtual double Width
    {
        get
        {
            return _width;
        }
        set
        {
            _width = value;
        }
    }

    public abstract double Area { get; }

}