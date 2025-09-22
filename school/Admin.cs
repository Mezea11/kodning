namespace App;

class Admin : IUser
{
    public string Username { get; }
    string _password;

    public Admin(string username, string password)
    {
        Username = username;
        _password = password;
    }

    public bool IsRole(Role role)
    {
        return Role.Admin == role;
    }

    public bool TryLogin(string username, string password)
    {
        return username == Username && password == _password;
    }

    public Role GetRole()
    {
        return Role.Admin;
    }

}