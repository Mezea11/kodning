using App;

class Program
{
    public static void Main(string[] args)
    {
        // lists

        List<int> numbers = new List<int>();
        numbers.Add(-2);
        numbers.Add(-1);
        numbers.Add(1);
        numbers.Add(2);
        numbers.Add(3);
        numbers.Add(4);

        Console.WriteLine($"{numbers.Count()}");

        /*         numbers.RemoveAt(3);
         */

        /*     foreach (int num in numbers)
            {
                if (num > 0)
                {
                    Console.WriteLine($"Positive numbers in num array: {num}");
                }
            }

            foreach (int num in numbers)
            {
                if (num < 0)
                {
                    Console.WriteLine($"Negative values i num array: {num}");
                }
            }

            bool running = true;

            while (running)
            {
                Console.WriteLine($"Insert the number that you wish to remove: ");

                string input = Console.ReadLine();

                if (int.TryParse(input, out int result) && input < 0)
                {
                    Console.WriteLine($"Please insert a positive number");
                }
                else if (int.TryParse(input, out int result) && input > 0)
                {
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (input == i)
                        {
                            numbers.RemoveAt(i);
                        }
                    }
                    Console.WriteLine($"Number was succesfully removed.");
                }
            } */

        List<Fish> fish_list = new List<Fish>();

        Fish my_fish = new Fish("Fiskstian", "Aborre");

        fish_list.Add(my_fish);

        foreach (Fish fish in fish_list)
        {
            Console.WriteLine($"{fish.ToString()}");
        }

        fish_list.RemoveAt(0);

        foreach (Fish fish in fish_list)
        {
            Console.WriteLine($"{fish.ToString}");
        }


    }
}