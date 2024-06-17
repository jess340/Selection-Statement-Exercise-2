namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite school subject?");

            var subject = Console.ReadLine();

            switch (subject.ToLower())
            {
                case "math": 
                    Console.WriteLine("Math is tough subject!");
                    break;

                case "english":
                Console.WriteLine("English is an interesting subject!");
                break;

                case "science":
                    Console.WriteLine("Science is an awesome subject!");
                    break;

                default:
                    Console.WriteLine($"Ah wow! I haven't taken that subject before. {subject} has been on my mind to take for some time now!");
                    break; 
           
            }

          
        }
    }
}