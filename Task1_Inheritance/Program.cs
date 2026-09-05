using System;

namespace Task1_Inheritance
{
    // Base class
    public class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Some generic sound");
        }
    }

    // Derived class - Dog
    public class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Bark");
        }
    }

    // Derived class - Cat
    public class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Meow");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Task 1: Inheritance and Method Overriding ===\n");

            // Create instances of Animal, Dog, and Cat
            Animal animal = new Animal();
            Dog dog = new Dog();
            Cat cat = new Cat();

            // Call MakeSound() on each instance
            Console.WriteLine("Animal sound:");
            animal.MakeSound();

            Console.WriteLine("\nDog sound:");
            dog.MakeSound();

            Console.WriteLine("\nCat sound:");
            cat.MakeSound();

            Console.WriteLine("\n--- Polymorphism Demo ---");
            // Demonstrating polymorphism
            Animal[] animals = { animal, dog, cat };
            Console.WriteLine("\nCalling MakeSound() through Animal reference:");
            foreach (Animal a in animals)
            {
                a.MakeSound();
            }
        }
    }
}
