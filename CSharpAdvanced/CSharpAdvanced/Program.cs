using CSharpAdvanced.Base;
using CSharpAdvanced.Cars;
using CSharpAdvanced.Motocycles;
using System;
using System.Collections.Generic;

namespace CSharpAdvanced
{
    class Program
    {
        class Animal  // Base class (parent) 
        {
            public void animalSound()
            {
                Console.WriteLine("The animal makes a sound");
            }
        }

        class Pig : Animal  // Derived class (child) 
        {
            public void animalSound()
            {
                Console.WriteLine("The pig says: wee wee");
            }
        }

        class Dog : Animal  // Derived class (child) 
        {
            public void animalSound()
            {
                Console.WriteLine("The dog says: bow wow");
            }

            public void Bark()
            {
                Console.WriteLine("Bark");
            }
        }

        static void Main(string[] args)
        {
            Animal myAnimal = new Animal();  // Create a Animal object
            Animal myPig = new Pig();  // Create a Pig object
            Animal myDog = new Dog();  // Create a Dog object

            //myDog.Bark();

            myAnimal.animalSound();
            myPig.animalSound();
            myDog.animalSound();

            ////Vehicle vehicle = new Vehicle();


            //ModernCar modernCar = new ModernCar();
            //modernCar.Park();
            //modernCar.Drive();

            //Car oldCar = new Car();
            //oldCar.Drive();

            //Motocycle motoCycle = new Motocycle();
            //motoCycle.Drive();

            Harley harley = new Harley();
            harley.Drive();

            //Peugeot peugot406 = new Peugeot();
            ////peugot406.EngineType = "Diesel";
            

            //Console.WriteLine("Hello World!");

            //List<Car> cars = new ();

        }
    }
}
