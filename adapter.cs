using System;

// Step 1: Define the Target Interface
public interface IShape
{
    void Draw(int x, int y, int width, int height);
}

// Step 2: Create the Adaptee Class
public class Rectangle
{
    public void DrawRectangle(int x, int y, int width, int height)
    {
        Console.WriteLine($"Drawing a rectangle at ({x}, {y}) with width {width} and height {height}.");
    }
}

// Step 3: Create the Adapter Class
public class RectangleAdapter : IShape
{
    private readonly Rectangle _rectangle;

    public RectangleAdapter(Rectangle rectangle)
    {
        _rectangle = rectangle;
    }

    public void Draw(int x, int y, int width, int height)
    {
        // Translate the call to the adaptee's method
        _rectangle.DrawRectangle(x, y, width, height);
    }
}

// Step 4: Client Code
class Program
{
    static void Main(string[] args)
    {
        // Create a Rectangle object
        Rectangle rectangle = new Rectangle();

        // Create an adapter for the Rectangle
        IShape shape = new RectangleAdapter(rectangle);

        // Use the adapter to draw the rectangle
        shape.Draw(10, 20, 100, 50);
    }
}
