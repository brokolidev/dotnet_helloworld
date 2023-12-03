using System.Diagnostics;

namespace HelloWorld;

public class Rectangle
{
    public Rectangle(int w, int h)
    {
        Width = w;
        Height = h;
    }

    public Rectangle(int side)
    {
        Width = Height = side;
    }

    public int GetArea()
    {
        return Width * Height;
    }

    public int Width;
    public int Height;
}