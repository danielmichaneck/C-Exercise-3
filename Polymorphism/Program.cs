namespace Polymorphism
{
    /// <summary>
    /// A program that adds UserErrors to a list
    /// and displays their message. Assigns errors
    /// to the list randomly.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new();

            // 7. Create a list of UserErrors and populate
            // it with instances of UserErrors-derived classes.
            List<UserError> errors = new();
            
            for (int i = 0; i < 10; i++)
            {
                if (random.Next(0, 1000) % 2 == 0)
                    errors.Add(new NumericInputError());
                else errors.Add(new TextInputError());
            }

            // 8. Print all the UserError messages.
            foreach (UserError error in errors)
            {
                Console.WriteLine(error.UEMessage());
            }

            Console.WriteLine();
            errors.Clear();

            // 9 & 10. Adding all the different types
            // of errors to a list and then printing them.
            for (int i = 0; i < 20; i++)
            {
                switch (random.Next(0, 1000) % 5)
                {
                    case 0:
                        errors.Add(new NumericInputError());
                        break;

                    case 1:
                        errors.Add(new TextInputError());
                        break;

                    case 2:
                        errors.Add(new CursorInputError());
                        break;

                    case 3:
                        errors.Add(new CatInputError());
                        break;

                    case 4:
                        errors.Add(new OutOfBoundsInputError());
                        break;


                }
            }

            foreach (UserError error in errors)
            {
                Console.WriteLine(error.UEMessage());
            }
        }
    }
}
