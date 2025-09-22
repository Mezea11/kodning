namespace MyApp2;

class User
{
    public string name;
    public int age;

    public User(string name_in, int age_in)
    {
        name = name_in;
        age = age_in;
    }

    public string Info()
    {
        return name + ", " + age;
    }

    public int Add(int a, int b)
    {
        return a + b;
    }
}