namespace testYuh
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            while (true)
            {
                string awnser = Console.ReadLine();
                Console.WriteLine(awnser);

                if (awnser == "lab1")
                {
                    Console.WriteLine("lab 1");
                }
                else if (awnser == "lab2") 
                { 
                    Console.WriteLine("lab 2");

                }
                else
                { 
                    Console.WriteLine("lab 3");
                    Random rand = new Random();

                    Console.WriteLine("Guess a number from 0 to 9");

                    int team1 = rand.Next(10);
                    int team2 = rand.Next(10);


                    int guess = int.Parse(Console.ReadLine());

                    Console.WriteLine($"Team 1: {team1}, Team 2: {team2}");

                    Console.ReadLine();
                }
            } 
        }
    }
}
