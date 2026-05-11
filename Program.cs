namespace testYuh
{
    internal class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("what lab do you want to see : ");

                string awnser = Console.ReadLine();
                Console.WriteLine(awnser);

                if (awnser == "lab 1")
                {
                    Console.WriteLine("lab 1");
                }
                else if (awnser == "lab 2") 
                { 
                    Console.WriteLine("lab 2");
                    Random rand = new Random();

                    Console.WriteLine("Guess a number from 0 to 9");

                    int team1 = rand.Next(10);
                    int team2 = rand.Next(10);


                    int guess = int.Parse(Console.ReadLine());

                    Console.WriteLine($"Team 1: {team1}, Team 2: {team2}");

                    Console.ReadLine();

                }
                else if (awnser == "lab 3")
                { 
                    Console.WriteLine("lab 3");
                    bool childRunning = true;

                    while (childRunning == true)
                    {
                        Console.WriteLine("why tho");
                        string child = Console.ReadLine();
                        if (child == "because")
                        {
                            Console.WriteLine("ok son");
                            childRunning = false;
                        }
                    }
                }
            } 
        }
    }
}
