namespace App;

interface IUser
{
    string Username { get; }
    public bool TryLogin(string username, string password);
    public bool IsRole(Role role) { get; }

}

enum Role
    {
        Student,
        Teacher,
        Admin
    }