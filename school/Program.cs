using App;

// Användare 
// Resurser, dolda baserade på roll
// Logga in
// Logga ut
// Skapa användare om man är admin
// Se schema
// Lämna in uppgifter
// Få uppgifter rättade (betyg kan vara enum)

// IUser

List<IUser> users = new List<IUser>();
users.Add(new Student("123", "123"));
users.Add(new Student("elvis@gmail.com", "password123"));
users.Add(new Student("fanny@gmail.com", "password123"));
users.Add(new Student("gabbe@gmail.com", "password123"));

users.Add(new Admin("1234", "1234"));
users.Add(new Teacher("345", "345"));


IUser? active_user = null; // active_user set null by default, allowed to be null with ? before var declaration


bool running = true;

while (running)
{
    Console.Clear();
    if (active_user == null)
    {
        Console.Write($"Username: ");
        string username = Console.ReadLine();

        Console.Clear();

        Console.Write($"Password: ");
        string password = Console.ReadLine();

        Console.Clear();


        foreach (IUser user in users)
        {
            if (user.TryLogin(username, password))
            {
                active_user = user;
                break;
            }
        }

        Console.WriteLine($"Welcome {username}. Is logged in: {active_user != null}");
        Console.ReadLine();
    }

    else
    {
        Console.Clear();
        Console.WriteLine($"--- School system ---");
        Console.WriteLine($"Logout");

        // ADMIN ROLE SUBMENU
        if (active_user.IsRole(Role.Admin))
        {
            Console.WriteLine($"Welcome admin.");
            Console.WriteLine($"Select following: ");
            Console.WriteLine($"1. Create user");
            Console.WriteLine($"2. View all users");

            string adminChoice = Console.ReadLine();

            switch (adminChoice)
            {
                case "1":
                    CreateUser();
                    break;
                case "2":
                   /*  foreach (IUser user in users)
                    {
                        Console.WriteLine($"{user.Username}");
                    } */
                    break;
                case "3":
                    
                default:
                    Console.WriteLine($"Invalid input.");
                    break;
            }
        }

        // TEACHER ROLE SUBMENU
        if (active_user.IsRole(Role.Teacher))
        {
            Console.WriteLine($"Welcome teacher.");
        }


        // STUDENT ROLE SUBMENU
        if (active_user.IsRole(Role.Student))
        {
            Console.WriteLine($"Welcome student.");
        }

        string input = Console.ReadLine();

        switch (input)
        {
            case "logout":
                active_user = null;
                break;
            default:
                Console.WriteLine($"Invalid input, try again.");
                break;
        }
    }
}

void CreateUser()
{
    // show roles
    Console.WriteLine($"Select role of user (type the name):");
    foreach (var r in Enum.GetValues<Role>()) Console.WriteLine($"- {r}");

    // read role name
    string? userInput = Console.ReadLine();

    // match role
    Role? selectedRole = null;
    foreach (var r in Enum.GetValues<Role>())
    {
        if (string.Equals(userInput, r.ToString(), StringComparison.OrdinalIgnoreCase))
        {
            selectedRole = r;
            break;
        }
    }

    if (selectedRole is null)
    {
        Console.WriteLine($"Invalid role.");
        return;
    }

    // input params for new user

    Console.Write($"Insert username: ");
    string username = Console.ReadLine() ?? "";

    Console.Write($"Insert password: ");
    string password = Console.ReadLine() ?? "";

    IUser newUser = selectedRole switch
    {
        Role.Admin => new Admin(username, password),
        Role.Teacher => new Teacher(username, password),
        Role.Student => new Student(username, password),
    };
    users.Add(newUser);

    Console.WriteLine($"{selectedRole} created for {username}");
}