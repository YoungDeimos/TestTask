using SortableShapes.Models;

namespace SortableShapes
{
    class Program
    {
        public static void Main()
        {
            Shape square = new Square(2);
            Shape circle = new Circle(5);
            Shape rectangle = new Rectangle(5, 10);
            Shape triangle = new Triangle(3, 5);

            List<Shape> shapes = new List<Shape> { square, circle, rectangle, triangle };

            shapes.Sort();

            foreach (Shape shape in shapes)
            {
                Console.WriteLine($"Area of a {shape.GetType().Name} = {shape.Area}");
            }
        }
    }
}

