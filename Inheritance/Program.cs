using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("Tests")]

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

            // 3. Create a list of Animals.
            List<Animal> animalList = new();

            // 4. Create a few Animals and add them
            // to the list of Animals.
            for (int i = 0; i < AnimalCount + 1; i++)
            {
                animalList.Add(StaticAnimalHelper.GetAnimal(i, random));
            }

            // 5. Print which animals are in the list.
            foreach (Animal animal in animalList)
            {
                Console.WriteLine(animal.Name);
                // 6. Call the DoSound() method
                // in the animals.
                animal.DoSound();
                // 7. Check if animal is IPerson and
                // if so, call Talk().
                if (animal is IPerson person)
                {
                    person.Talk();
                }
                Console.WriteLine();
            }

            Console.WriteLine("__________" + Environment.NewLine);

            // 8. Create a list of dogs.
            List<Dog> dogList = new();

            for (int i = 0; i < 4; i++)
            {
                dogList.Add(new Dog());
            }

            // F9. Try to add a horse to the list of dogs.
            // dogList.Add(new Horse()); ERROR
            // You cannot add a Horse to a list of Dogs!

            // 11. Print all the Animal stats.
            foreach (Animal animal in animalList)
            {
                Console.WriteLine(animal.Stats());
            }

            Console.WriteLine("__________" + Environment.NewLine);

            // 14. Print Stats only for the dogs in
            // the Animal list.
            foreach (Animal animal in animalList)
            {
                // F17
                // animal.AddSpeed(); ERROR
                // Animal does not contain a definition for AddSpeed()!
                // Only Dog does!
                if (animal is Dog dog)
                {
                    Console.WriteLine(animal.Stats());
                    // 18. Find a method to call the Dog
                    // method in the animal list.
                    // By typecasting animal into Dog dog I can access
                    // The AddSpeed() method in the Dog.
                    dog.AddSpeed(10);
                }
            }
        }
    }
}
