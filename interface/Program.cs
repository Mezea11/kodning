using App;

List<IUser> users = new List<IUser>();

users.Add(new Admin("Christian", "admin"));
users.Add(new Customer("Elvis", "customer"));
users.Add(new Customer("Gabriel", "customer"));

foreach (IUser user in users)
{
    Console.WriteLine($"{user.Info()}");
}

