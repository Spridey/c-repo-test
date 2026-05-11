namespace Gablab8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("wrock paper scissors");
            Console.WriteLine("Enter your choice (rock, paper, scissors): ");
            string userChoice = Console.ReadLine().ToLower();
            string[] choices = { "rock", "paper", "scissors" };
            Random random = new Random();
            string computerChoice = choices[random.Next(choices.Length)];
            Console.WriteLine($"Computer chose: {computerChoice}");
            if (userChoice == computerChoice)
            {
                Console.WriteLine("It's a tie!");
            }
            else if ((userChoice == "rock" && computerChoice == "scissors") ||
                     (userChoice == "paper" && computerChoice == "rock") ||
                     (userChoice == "scissors" && computerChoice == "paper"))
            {
                Console.WriteLine("You win!");
            }
            else
            {
                Console.WriteLine("Computer wins!");
            }
            
        }
    }
}
