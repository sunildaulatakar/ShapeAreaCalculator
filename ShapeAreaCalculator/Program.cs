using System;


namespace ShapeAreaCalculator
{
    public abstract  class Shape
    {
        public double Width, Height;
        public const double pi = 3.14;

        public abstract double CalculateArea();

    }
    public class Rectangle : Shape
    {
        public Rectangle(double width,double height)
        {
            Width = width;
            Height = height;        
        }

        public override double CalculateArea()
        {
            return Width * Height;
        }

    }
    public class Square:Shape
    { 
        public Square(double width)
        {

            Width = width;
        }

        public override double CalculateArea()
        {
            return Width * Width;
        }

    }
    public class Circle:Shape
    {
        public double Radius;
        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double CalculateArea()
        {
            return pi * Radius * Radius;
        }
    }
    public class Triangle : Shape
    {
        public double Base;
        public Triangle(double baseLength, double height)
        {
            Base = baseLength;
            Height = height;
        }
        public override double CalculateArea()
        {
            return 0.5 * Base * Height;
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Shape Area Calculator");
            Console.WriteLine("=====================");
            Console.WriteLine("Select a shape:");
            Console.WriteLine("1. Rectangle");
            Console.WriteLine("2. Square ");
            Console.WriteLine("3. Circle");
            Console.WriteLine("4. Triangle");

            int choice = int.Parse(Console.ReadLine());

            Shape shape = null;

            switch (choice)
            {
                case 1:
                    Console.Write("Enter Width: ");
                    double width = double.Parse(Console.ReadLine());
                    Console.Write("Enter Height: ");
                    double height = double.Parse(Console.ReadLine());
                    shape = new Rectangle(width, height);
                    break;

                case 2:
                    Console.Write("Enter Width: ");
                    double Width = double.Parse(Console.ReadLine());
                    shape = new Square(Width);
                    break;

                case 3:
                    Console.Write("Enter Radius: ");
                    double radius = double.Parse(Console.ReadLine());
                    shape = new Circle(radius);
                    break;

                case 4:
                    Console.Write("Enter Base: ");
                    double baseLength = double.Parse(Console.ReadLine());
                    Console.Write("Enter Height: ");
                    double triangleHeight = double.Parse(Console.ReadLine());
                    shape = new Triangle(baseLength, triangleHeight);
                    break;

                default:
                    Console.WriteLine("Invalid Choice...!");
                    break;

            }
            Console.WriteLine($"The area of the selected shape is: {shape.CalculateArea()}");

        }
    }
}
