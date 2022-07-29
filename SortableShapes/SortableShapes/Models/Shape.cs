namespace SortableShapes.Models
{
    public abstract class Shape : IComparable<Shape>
    {
        public double Area => GetArea();

        public int CompareTo(Shape? other)
        {
            if (other is null)
                return 1;
            if (other.Area < this.Area)
                return 1;
            if (other.Area == this.Area)
                return 0;
            return -1;
        }

        public abstract double GetArea();

    }
}
