using System;

namespace Lab1
{
    public class Circle : Figure
    {
        private double r;
        
        public Circle(Vector a, double r) : base(a)
        {
            R = r;
        }

        /// <summary>
        /// Радиус круга
        /// </summary>
        /// <exception cref="Exception"></exception>
        public double R
        {
            get => r;
            set
            {
                if (value < 0)
                    throw new Exception();
                r = value;
            }
        }

        /// <summary>
        /// Площадь круга
        /// </summary>
        /// <returns>Площадь</returns>
        public override double S()
        {
            return Math.PI * Math.Pow(r, 2);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
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