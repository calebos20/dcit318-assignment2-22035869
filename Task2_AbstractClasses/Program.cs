using System;

namespace Task2_AbstractClasses
{
    // Abstract base class
    public abstract class Shape
    {
        public string Name { get; protected set; }

        // Abstract method
        public abstract double GetArea();

        // Concrete method
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Shape: {Name}");
        }
    }

    // Derived class - Circle
    public class Circle : Shape
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
            this.Name = "Circle";
        }

        public override double GetArea()
        {
            return Math.PI * radius * radius;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Radius: {radius}");
        }
    }

    // Derived class - Rectangle
    public class Rectangle : Shape
    {
        private double width;
        private double height;

        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
            this.Name = "Rectangle";
        }

        public override double GetArea()
        {
            return width * height;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Width: {width}, Height: {height}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Task 2: Abstract Classes and Methods ===\n");

            // Create instances of Circle and Rectangle
            Circle circle = new Circle(5.0);
            Rectangle rectangle = new Rectangle(4.0, 6.0);

            // Display information and calculate areas
            Console.WriteLine("--- Circle ---");
            circle.DisplayInfo();
            Console.WriteLine($"Area: {circle.GetArea():F2} square units\n");

            Console.WriteLine("--- Rectangle ---");
            rectangle.DisplayInfo();
            Console.WriteLine($"Area: {rectangle.GetArea():F2} square units\n");

            // Demonstrating polymorphism with abstract classes
            Console.WriteLine("--- Polymorphism Demo with Abstract Classes ---");
            Shape[] shapes = { circle, rectangle };
            
            foreach (Shape shape in shapes)
            {
                shape.DisplayInfo();
                Console.WriteLine($"Area: {shape.GetArea():F2} square units\n");
            }
        }
    }
}
