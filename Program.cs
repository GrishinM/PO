using System;

namespace Lab1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var a = new Rectangle(new Figure.Vector(1, 1), 5, 10);
            a.Info();
            var b = new Circle(new Figure.Vector(5, -7), 3);
            b.Info();
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}