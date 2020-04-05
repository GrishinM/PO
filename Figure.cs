namespace Lab1
{
    /// <summary>
    /// Abstract class Figure.
    /// Contains common methods and fields for all figures
    /// </summary>
    public abstract class Figure
    {
        public Vector Center { get; private set; }

        protected Figure(Vector a)
        {
            Center = new Vector(a);
        }

        public abstract double S();

        public abstract double P();

        public abstract void Info();

        public void Move(Vector vector)
        {
            Center += vector;
        }

        /// <summary>
        /// Vector is a geometric object that has magnitude (or length) and direction
        /// </summary>
        public class Vector
        {
            public double X { get; }
            public double Y { get; }

            public Vector(double x, double y)
            {
                X = x;
                Y = y;
            }

            public Vector(Vector vector)
            {
                X = vector.X;
                Y = vector.Y;
            }

            public static Vector operator +(Vector a, Vector b)
            {
                return new Vector(a.X + b.X, a.Y + b.Y);
            }

            public static Vector operator -(Vector a, Vector b)
            {
                return new Vector(a.X - b.X, a.Y - b.Y);
            }

            public static implicit operator Vector((double, double) pair)
            {
                var (item1, item2) = pair;
                return new Vector(item1, item2);
            }
        }
    }
}