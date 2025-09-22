namespace App;

class User
{
    public string Name;
    public int Age;
    public User(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public override string ToString()
    {
        return $"Name: {Name} | Age: {Age}";
    }
}