namespace App
{
    class Fish
    {
        public string Name;
        public string Type;

        public Fish(string name, string type)
        {
            Name = name;
            Type = type;
        }

        public override string ToString()
        {
            return "Name: " + Name +" Type: " + Type;
        }
    }
}