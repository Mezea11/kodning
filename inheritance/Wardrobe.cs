namespace WardrobeApp;

public class Wardrobe
{
    public Clothing[] Clothes;
    public int MaxCapacity;
    public Wardrobe(int capacity)
    {
        Clothes = new Clothing[capacity];
        MaxCapacity = capacity;
    }

    public void Show()
    {
        for (int i = 0; i < MaxCapacity; i++)
        {
            if (Clothes[i] != null)
            {
                Console.WriteLine($"{Clothes[i].Label} | {Clothes[i].Color} | {Clothes[i].Size}");
            }
        }
    }

    public void Add(string label, string color, int size)
    {
        for (int i = 0; i < MaxCapacity; i++)
        {
            if (Clothes[i] == null)
            {
                Clothes[i] = new Clothing(label, color, size);
                break;
            }
        }
    }

    public void Update(string label, string color)
    {
        for (int i = 0; i < MaxCapacity; i++)
        {
            if (Clothes[i] != null)
            {
                string input = Console.ReadLine();

                Console.WriteLine($"Enter the name you wish to change it to: ");
                input = label;

                Console.WriteLine($"Enter the color you wish to change it to: ");
                input = color;

                Clothes[i];
            }   
        }
    }
    }
