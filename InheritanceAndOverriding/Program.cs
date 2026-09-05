using System;

namespace InheritanceAndOverriding
{
    // Base class demonstrating a virtual method
    class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Some generic sound");
        }
    }

    // Derived class overriding MakeSound
    class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Bark");
        }
    }

    // Another derived class overriding MakeSound
    class Cat : Animal
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
            var animal = new Animal();
            var dog = new Dog();
            var cat = new Cat();

            animal.MakeSound();
            dog.MakeSound();
            cat.MakeSound();
        }
    }
}
