using System;

namespace AbstractClasses
{
    // Abstract base class with an abstract method GetArea
    abstract class Shape
    {
        public abstract double GetArea();
    }

    // Circle implements GetArea using Math.PI
    class Circle : Shape
    {
        public double Radius { get; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double GetArea()
        {
            return Math.PI * Radius * Radius;
        }
    }

    // Rectangle implements GetArea using length * width
    class Rectangle : Shape
    {
        public double Length { get; }
        public double Width { get; }

        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
        }

        public override double GetArea()
        {
            return Length * Width;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var circle = new Circle(5); // sample radius
            var rectangle = new Rectangle(10, 5); // sample length and width

            Console.WriteLine($"Circle Area: {circle.GetArea():F2}");
            Console.WriteLine($"Rectangle Area: {rectangle.GetArea():F0}");
        }
    }
}
