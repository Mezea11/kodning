namespace App;

class Student : IUser
{
    public string Username { get; }
    
    string _password; // private by default

    public Student(string username, string password)
    {
        Username = username;
        _password = password;
    }

    public bool IsRole(Role role)
    {
        return Role.Student == role;
    }

    public bool TryLogin(string username, string password)
    {
        return username == Username && password == _password;
    }

    public Role GetRole()
    {
        return Role.Student;
    }
  
}