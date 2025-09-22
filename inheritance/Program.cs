using WardrobeApp;

class Program
{
    static void Main(string[] args)
    {

        Wardrobe wardrobe = new Wardrobe(64);

        wardrobe.Clothes[0] = new Clothing("shirt", "blue", 3);

        bool running = true;
        
        Console.WriteLine($"1. Write 'show' to show");
        Console.WriteLine($"2. Write 'add' to add");
        Console.WriteLine($"3. Write 'exit' to exit");

        while (running)
        {
            string input = Console.ReadLine();


            switch (input)
            {
                case "show":
                    {
                        wardrobe.Show();
                        break;
                    }
                case "add":
                    {
                        Console.WriteLine($"Please enter the label for your article of clothing");
                        string label = Console.ReadLine();

                        Console.WriteLine($"Please enter the color for your article of clothing");
                        string color = Console.ReadLine();

                        wardrobe.Add(label, color, 3);
                        break;
                    }
                case "update":
                    {
                        wardrobe.Update();
                        break;
                }
                case "quit":
                    {
                        running = false;
                        Console.WriteLine($"Exiting..");
                        break;
                    }
            }
        }
        
    }
}