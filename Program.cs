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

                }
<<<<<<< HEAD
                else if (awnser == "lab 3")
=======
                else
>>>>>>> 4006cd6d4e49e4504b4574003045ce628041393b
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
