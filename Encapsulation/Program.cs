namespace Persons
{
    /// <summary>
    /// A program that creates different people using an
    /// intermediary person handler.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            var personHandler = new PersonHandler();
            var arthas = personHandler.CreatePerson(30, "Arthas", "Menethil", 180, 80);
            var malfurion = personHandler.CreatePerson(1000, "Malfurion", "Stormrage", 200, 100);
            var thrall = personHandler.CreatePerson(60, "Thrall", "Go'el", 240, 200);
        }
    }
}
