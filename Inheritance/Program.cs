// Polymorphism
// 13 F: If we need a new attribute for all birds
// that attribute should go in the Bird class as
// all birds inherit from it.

// F14: If all animals need a new attribute
// that attribute should go in the Animal
// class as all animals inherit from it.

// More polymorphism
// F9: What happens if I try to add a horse to a list of dogs?
// dogList.Add(new Horse()); ERROR
// You cannot add a Horse to a list of Dogs!
// While they inherit from the same base class
// they are fundamentally different and may
// have unique members the other does not.

// F10: What type must the list be to be
// able to store all of the animals?
// The list must be in Animal type to contain
// all Animal classes.

// F13: What is happening?
// The foreach loop calls the Stats() method
// in all Animals in the animalList.

// F17: Why cannot the program access the
// method in Dog by looping through the
// Animal-list?
// Since Animal does not contain a definition
// for the method it cannot acces it!
// A type cast is necessary to treat the
// animal like a dog.

using System.Runtime.CompilerServices;

namespace Inheritance
{
    /// <summary>
    /// A program that creates a list of Animals and
    /// a list of Dogs and then performs various
    /// operations on these lists. Mostly printing
    /// sounds they make or statistics about them.
    /// </summary>
    internal class Program
    {
        internal const int AnimalCount = 6;

        static void Main(string[] args)
        {
            Random random = new();

            // 3.
            List<Animal> animalList = new();

            // 4.
            for (int i = 0; i < AnimalCount + 1; i++)
            {
                animalList.Add(StaticAnimalHelper.GetAnimal(i, random));
            }

            // 5.
            foreach (Animal animal in animalList)
            {
                Console.WriteLine(animal.Name);
                // 6.
                animal.DoSound();
                // 7.
                if (animal is IPerson person)
                {
                    person.Talk();
                }
                Console.WriteLine();
            }

            Console.WriteLine("__________" + Environment.NewLine);

            // 8.
            List<Dog> dogList = new();

            for (int i = 0; i < 4; i++)
            {
                dogList.Add(new Dog());
            }

            // F9.
            // dogList.Add(new Horse()); ERROR
            // You cannot add a Horse to a list of Dogs!

            // 11.
            foreach (Animal animal in animalList)
            {
                Console.WriteLine(animal.Stats());
            }

            Console.WriteLine("__________" + Environment.NewLine);

            // 14.
            foreach (Animal animal in animalList)
            {
                // F17
                // animal.AddSpeed(); ERROR
                // Animal does not contain a definition for AddSpeed()!
                // Only Dog does!
                if (animal is Dog dog)
                {
                    Console.WriteLine(animal.Stats());
                    // 18.
                    // By typecasting animal into Dog dog I can access
                    // The AddSpeed() method in the Dog.
                    dog.AddSpeed(10);
                }
            }
        }
    }
}
