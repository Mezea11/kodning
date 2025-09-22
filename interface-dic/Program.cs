using App;
using System.Diagnostics;

Dictionary<string, Continent> string_to_continent = new Dictionary<string, Continent>();
string_to_continent["Asia"] = Continent.Asia;
string_to_continent["Europe"] = Continent.Europe;
string_to_continent["Africa"] = Continent.Africa;
string_to_continent["SouthAmerica"] = Continent.SouthAmerica;
string_to_continent["NorthAmerica"] = Continent.NorthAmerica;
string_to_continent["Oceania"] = Continent.Oceania;
string_to_continent["Antarctica"] = Continent.Antarctica;

Dictionary<string, List<Bird>> birds_by_continent = new Dictionary<string, List<Bird>>();

birds_by_continent[Continent.Asia] = new List<Bird>();
birds_by_continent[Continent.Europe] = new List<Bird>();
birds_by_continent[Continent.Africa] = new List<Bird>();
birds_by_continent[Continent.SouthAmerica] = new List<Bird>();
birds_by_continent[Continent.NorthAmerica] = new List<Bird>();
birds_by_continent[Continent.Antarctica] = new List<Bird>();
birds_by_continent[Continent.Oceania] = new List<Bird>();

bool running = true;

while (running)
{

    Console.WriteLine($"Select a continent");
    string? input = Console.ReadLine();


    if (input != null && string_to_continent.ContainsKey(input))
    {
        Continent selectedContinent = string_to_continent[input];
        List<Bird> birds = birds_by_continent[selectedContinent];

        Console.WriteLine($"Enter the name of a bird");

        input = Console.ReadLine();
        birds.Add(new Bird(input));


    }
}