namespace Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<UserError> errors = new();
            Random random = new();

            for (int i = 0; i < 10; i++)
            {
                if (random.Next(0, 1000) % 2 == 0)
                    errors.Add(new NumericInputError());
                else errors.Add(new TextInputError());
            }

            foreach (UserError error in errors)
            {
                Console.WriteLine(error.UEMessage());
            }

            Console.WriteLine();
            errors.Clear();

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
