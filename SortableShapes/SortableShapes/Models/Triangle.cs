namespace SortableShapes.Models
{
    public class Triangle : Shape
    {
        public double Side { get; set; }

        public double Height { get; set; }

        public Triangle(double side, double height)
        {
            Side = side;
            Height = height;
        }

        public override double GetArea()
        {
            return Side * Height / 2;
        }
    }
}
