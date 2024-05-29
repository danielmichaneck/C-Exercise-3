namespace Persons
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var personHandler = new PersonHandler();
            var person = personHandler.CreatePerson(30, "Arthas", "Menethil", 180, 80);
            personHandler.SetAge(person, 50);
            Console.WriteLine(person.Age);
            personHandler.SetName(person, "Muradin Bronzebeard");
            Console.WriteLine(person.FName);
            Console.WriteLine(person.LName);
        }
    }
}
