using App;

class Program
{
    public static void Main(string[] args)
    {
        List<string> names = new List<string>();

        names.Add("Michu");

        foreach (string name in names)
        {
            if (name != null && name != "")
            {
                Console.WriteLine($"{name}");
            }
        }

        List<User> users = new List<User>();
        users.Add(new User("Christian", 9)); // always instantiate new object with new keyword, then insert all parameters in instantiation
        users.Add(new User("Maria", 29)); // always instantiate new object with new keyword, then insert all parameters in instantiation

        foreach (User user in users)
        {
            Console.WriteLine(user.ToString());
        }

        Console.WriteLine($"Current amount of users: ");

        Console.WriteLine($"{users.Count()}");

        // Dictionary stores data in form of key value pairs. Efficient for lookups (dont need to sort through data)
        Dictionary<string, string> email_by_name = new Dictionary<string, string>(); // generic collection

        email_by_name.Add("Christian", "christian@gmail.com");

        Console.WriteLine($"{email_by_name["Christian"]}");

        Dictionary<int, string> email_by_id = new Dictionary<int, string>(); // this dictionary holds multiple values
        email_by_id.Add(1, "christianmeza@gmail.com");
        Console.WriteLine($"{email_by_id[1]}");

        /* Dictionary<string, User> user_by_name = new Dictionary<string, User>(); // generic collection
        user_by_name.Add("Maria", users[1]);
        Console.WriteLine(user_by_name[Maria].Info()); */

        /* 
        names.Add(item); ADDS ITEM TO LIST 
        list.Remove(item); REMOVES ITEM FROM LIST
        int numbers = list.Count; COLLECTS ALL ITEMS FROM LIST
        bool exists = list.Contains(item); CHECKS IF ITEM EXISTS IN LIST
        list.Sort(); SORTS ELEMENTS IN LIST IN ASC ORDER


         */
    }
}