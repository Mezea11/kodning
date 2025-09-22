namespace WardrobeApp;


public class Clothing
{
    public string Label;
    public string Color;
    public int Size; // 1 small, 2 medium, 3 large

    public Clothing(string label, string color, int size)
    {
        Label = label;
        Color = color;
        Size = size;
    }
    }