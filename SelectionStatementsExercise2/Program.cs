namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
           


            Console.WriteLine("What is your favorite subject in school?");
            var subject = (Console.ReadLine());

            switch (subject)
            {
                case "History":
                    Console.WriteLine("I dont't like History");
                    break;
                case "Science":
                    Console.WriteLine("I think Science is interesting.");
                    break;
                case "English":
                    Console.WriteLine("I think English is boring.");
                    break;
                case "Gym":
                    Console.WriteLine("I think Gym is fun.");
                    break;
                case "Math":
                    Console.WriteLine("I think Math is confusing.");
                    break;
                default:
                    Console.WriteLine("I haven't taken that subject before.");
                    break;
            }

        }
    }
}