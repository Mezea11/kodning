namespace App;

class Admin : IUser
{

    public string Name;
    public string Role;

    public Admin(string name, string role)
    {
        Name = name;
        Role = role;
    }
   public string Info() => $"Name: {Name} Role: {Role}";
}