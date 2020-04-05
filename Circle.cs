using System;

namespace Lab1
{
    /// <summary>
    /// A circle is a shape consisting of all points in a plane that are a given distance from a given point, the centre
    /// </summary>
    public class Circle : Figure
    {
        private double r;

        public Circle(Vector a, double r) : base(a)
        {
            R = r;
        }

        public double R
        {
            get => r;
            set
            {
                if (value <= 0)
                    throw new Exception();
                r = value;
            }
        }

        public override double S()
        {
            return Math.PI * Math.Pow(r, 2);
        }

        public override double P()
        {
            return 2 * Math.PI * r;
        }

        public override void Info()
        {
            Console.WriteLine($"Координаты центра: {Center.X}, {Center.Y}\nРадиус: {r}\nПериметр: {P()}\nПлощадь: {S()}\n");
        }
    }
}