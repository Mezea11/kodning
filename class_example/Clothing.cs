namespace MyApp;

public class Clothing
{
    public string name;
    public string color;
    public int size;


    // Object method that prints all params in clothing when invoked
    public void WriteLine()
    {
        Console.WriteLine(name + ", " + color + ", " + size);
    }

    public string Description()
    {
        string result = "";

        result = name + ", " + color + ", " + size;

        return result;

    }

    
}