namespace Lab1
{
    public abstract class Figure
    {
        public Vector Center { get; set; }

        public Figure(Vector a)
        {
            Center = new Vector(a);
        }

        public abstract double S();

        public abstract double P();

        public abstract void Info();

        public class Vector
        {
            public double X { get; private set; }
            public double Y { get; private set; }

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
        }
    }
}