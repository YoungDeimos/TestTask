namespace SortableShapes.Models
{
    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Length { get; set; }

        public Rectangle(double width, double length)
        {
            Width = width;
            Length = length;
        }

        public override double GetArea()
        {
            return Width * Length;
        }
    }
}
