using App;
List<IUser> users = new List<IUser>();

Shop shop = new Shop();

bool running = true;

while (running)
{
    Console.Clear();
    User? activeUser = null;

    if (activeUser == null)
    {
        Console.WriteLine($"Insert username: ");
        string username = Console.ReadLine() ?? "Guest";

        Console.WriteLine($"Insert password: ");
        string password = Console.ReadLine() ?? "";

        Console.WriteLine($"Insert email: ");
        string email = Console.ReadLine() ?? "";

        User user = new User(username, password, email);

        foreach (IUser newUser in users)
        {
            if (user.TryLogin(username, password))
            {
                activeUser = user;
                break;
            }
        }

        Console.WriteLine($"Welcome {username} Is logged in: {activeUser != null}");
        Console.ReadLine();
    }
    else
    {

            Console.WriteLine($"Welcome to the Shop");
            Console.WriteLine($"Select an option: ");

            Console.WriteLine($"1. Add Item");
            Console.WriteLine($"2. Remove Item");
            Console.WriteLine($"3. Display All Items");
            Console.WriteLine($"4. Exit");

            string input = Console.ReadLine() ?? "";
            switch (input)
            {
                case "1":
                    Console.WriteLine($"Insert item name: ");
                    string itemName = Console.ReadLine() ?? "Item";

                    Console.WriteLine($"Insert item price: ");
                    double price = Convert.ToDouble(Console.ReadLine() ?? "0");

                    Item newItem = new Item(itemName, price);
                    shop.AddItem(newItem);

                    Console.WriteLine($"Item added: {newItem.ToString()}");
                    break;

                case "2":
                    break;
                default:
                    Console.WriteLine($"Invalid input. Please try again.");
                    break;
            }
        }
    }



