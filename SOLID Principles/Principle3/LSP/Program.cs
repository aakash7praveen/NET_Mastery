using ManagementAPI._3;

class Program
{
    static void Main(string[] args)
    {
        List<Bird> birds = new List<Bird>
            {
                new Sparrow { Name = "Jack" },
                new Ostrich { Name = "Ozzy" }
            };

        foreach (var bird in birds)
        {
            Console.WriteLine($"Bird: {bird.Name}");

            if (bird is IBirdMethod birdMethod)
            {
                birdMethod.Fly();
            }
            else
            {
                Console.WriteLine($"{bird.Name} can't fly.");
            }

            Console.WriteLine(); 
        }

        Console.WriteLine("Program finished successfully.");
    }
}
