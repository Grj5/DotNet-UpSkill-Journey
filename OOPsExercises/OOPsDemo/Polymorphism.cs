// OOP/PolymorphismExample.cs

public class Shape
{
    public virtual void Draw() => Console.WriteLine("Drawing a generic shape.");
}

public class Circle : Shape
{
    public override void Draw() => Console.WriteLine("Drawing a circle.");
}

public class Square : Shape
{
    public override void Draw() => Console.WriteLine("Drawing a square.");
}

class Polymorphism
{
    static void Main()
    {
        Shape[] shapes = { new Circle(), new Square(), new Shape() };
        foreach (var shape in shapes)
            shape.Draw();
    }
}
