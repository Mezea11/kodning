namespace App;

class Customer : IUser
{

    public string Name;
    public string Role;

    public Customer(string name, string role)
    {
        Name = name;
        Role = role;
    }

    public string Info()
    {
        return $"Name: {Name} | Role: {Role}";
    }
}