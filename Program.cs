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

                }
            } 
        }
    }
}
