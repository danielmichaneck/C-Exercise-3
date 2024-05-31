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

using System.Runtime.CompilerServices;

namespace Inheritance
{
    internal class Program
    {
        internal const int AnimalCount = 6;

        static void Main(string[] args)
        {
            Random random = new();
            List<Animal> animalList = new();

            for (int i = 0; i < AnimalCount + 1; i++)
            {
                animalList.Add(GetAnimal(i, random));
            }

            foreach (Animal animal in animalList)
            {
                Console.WriteLine(animal.Name);
                animal.DoSound();
                if (animal is IPerson person)
                {
                    person.Talk();
                }
                Console.WriteLine();
            }

            Console.WriteLine("__________" + Environment.NewLine);

            List<Dog> dogList = new();

            for (int i = 0; i < 4; i++)
            {
                dogList.Append(new Dog());
            }

            foreach(Animal animal in animalList)
            {
                Console.WriteLine(animal.Stats());
            }

            Console.WriteLine("__________" + Environment.NewLine);

            // Type cast eller loopa rätt lista?
            foreach (Animal animal in animalList)
            {
                // animal.AddSpeed(); ERROR
                // Animal does not contain a definition for AddSpeed()!
                // Only Dog does!
                if (animal is Dog dog)
                {
                    Console.WriteLine(animal.Stats());
                    Console.WriteLine("?");
                }
            }
        }

        static Animal GetAnimal(int animalInt, Random random)
        {
            switch (animalInt)
            {
                case 0:
                    if (random.Next(2) == 0)
                        return new Flamingo();
                    else if (random.Next(1) == 0)
                        return new Pelican();
                    else return new Swan();

                case 1:
                    return new Dog();

                case 2:
                    return new Hedgehog();

                case 3:
                    return new Horse();

                case 4:
                    return new Wolf();

                case 5:
                    return new Worm();

                default:
                    return new Wolfman();
            }
        }
    }
}
