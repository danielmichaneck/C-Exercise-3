// 13 F: If we need a new attribute for all birds
// that attribute should go in the Bird class as
// all birds inherit from it.

// 14 F: If all animals need a new attribute
// that attribute should go in the Animal
// class as all animals inherit from it.

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var bird = new Bird();
            Console.WriteLine(bird.Stats());
            bird = new Flamingo();
            Console.WriteLine(bird.Stats());
            bird = new Pelican();
            Console.WriteLine(bird.Stats());
            bird = new Swan();
            Console.WriteLine(bird.Stats());
        }
    }
}
