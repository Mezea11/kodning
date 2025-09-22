using App;
class Program
{
    public static void Main(string[] args)
    {
        // Dictionary continuation
        // Declaration - datatype - variablename
        Dictionary<int, int> number_to_number;

        number_to_number = new Dictionary<int, int>();

        number_to_number.Add(1, 2);
        number_to_number.Add(3, 4);

        Console.WriteLine($"{number_to_number.Count()}");

        Dictionary<string, List<Bird>> birds_by_continent = new Dictionary<string, List<Bird>>();
        birds_by_continent.Add("europe", new List<Bird>());
        birds_by_continent.Add("asia", new List<Bird>());
        birds_by_continent.Add("africa", new List<Bird>());
        birds_by_continent.Add("north america", new List<Bird>());
        birds_by_continent.Add("south america", new List<Bird>());
        birds_by_continent.Add("oceania", new List<Bird>());
        birds_by_continent.Add("antartic", new List<Bird>());
        birds_by_continent.Add("arctic", new List<Bird>());

        while (true)
        {
            Console.WriteLine($"Please enter a continent: ");
            string input = Console.ReadLine();

            Console.Clear();
            Console.WriteLine($"Please enter the birds name: ");
            string birdname = Console.ReadLine();

            birds_by_continent[input].Add(new Bird(bird_name, "Bird"));

            Console.Clear();

            Console.WriteLine($"Press Q to stop adding birds: ");
            input = Console.ReadLine();

            if(input == "Q") { break; }
        }


    }
}