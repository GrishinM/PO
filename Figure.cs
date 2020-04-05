using System;

namespace Lab1
{
    public abstract class Figure
    {
        public Vector Center { get; set; }
        public abstract double S();
        public abstract double P();

        public Figure(Vector a)
        {
            Center=new Vector(a);
        }

        public abstract void Info();
        
        public class Vector
        {
            public double X { get; set; }
            public double Y { get; set; }

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