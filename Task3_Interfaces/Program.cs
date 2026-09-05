using System;

namespace Task3_Interfaces
{
    // Interface definition
    public interface IMovable
    {
        void Move();
    }

    // Class implementing IMovable - Car
    public class Car : IMovable
    {
        private string brand;

        public Car(string brand)
        {
            this.brand = brand;
        }

        public void Move()
        {
            Console.WriteLine("Car is moving");
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Brand: {brand}");
        }
    }

    // Class implementing IMovable - Bicycle
    public class Bicycle : IMovable
    {
        private string type;

        public Bicycle(string type)
        {
            this.type = type;
        }

        public void Move()
        {
            Console.WriteLine("Bicycle is moving");
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Type: {type}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Task 3: Interfaces ===\n");

            // Create instances of Car and Bicycle
            Car car = new Car("Toyota");
            Bicycle bicycle = new Bicycle("Mountain Bike");

            // Call Move() on each instance
            Console.WriteLine("--- Car ---");
            car.DisplayInfo();
            car.Move();

            Console.WriteLine("\n--- Bicycle ---");
            bicycle.DisplayInfo();
            bicycle.Move();

            // Demonstrating polymorphism with interfaces
            Console.WriteLine("\n--- Polymorphism Demo with Interfaces ---");
            IMovable[] movables = { car, bicycle };

            Console.WriteLine("\nCalling Move() through IMovable interface:");
            foreach (IMovable movable in movables)
            {
                movable.Move();
            }

            // Additional example with more implementations
            Console.WriteLine("\n--- Extended Example ---");
            IMovable[] vehicles = { new Car("Honda"), new Bicycle("Road Bike"), new Car("Ford") };

            Console.WriteLine("All vehicles moving:");
            foreach (IMovable vehicle in vehicles)
            {
                vehicle.Move();
            }
        }
    }
}
