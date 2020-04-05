﻿using System;

namespace Lab1
{
    /// <summary>
    /// A rectangle is a quadrilateral with four right angles
    /// </summary>
    public class Rectangle : Figure
    {
        private double width, height;


        public Rectangle(Vector a, double width, double height) : base(a)
        {
            Width = width;
            Height = height;
        }

        public double Width
        {
            get => width;
            set
            {
                if (value <= 0)
                    throw new Exception();
                width = value;
            }
        }

        public double Height
        {
            get => height;
            set
            {
                if (value <= 0)
                    throw new Exception();
                height = value;
            }
        }

        public override double S()
        {
            return width * height;
        }

        public override double P()
        {
            return 2 * (width + height);
        }

        public override void Info()
        {
            Console.WriteLine($"Координаты центра: {Center.X}, {Center.Y}\nШирина: {width}\nВысота: {height}\nПериметр: {P()}\nПлощадь: {S()}\n");
        }
    }
}