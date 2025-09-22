
using System.Runtime.CompilerServices;
using LibraryApp;

class Program
{
    private static List<Book> books = new List<Book>();
    public static void Main(string[] args)
    {

        Console.WriteLine("Welcome to the Library App.");
        bool running = true;

        while (running)
        {
            Console.WriteLine($"Insert your choice: ");
            Console.WriteLine($"1. Add book");
            Console.WriteLine($"2. View all books");


            switch (Console.ReadLine())
            {
                case "1":
                    AddBook();
                    break;
                case "2":
                    ShowBooks();
                    break;
                default:
                    running = false;
                    break;

            }
        }
    }



    private static void AddBook()
    {
    
        
            Console.WriteLine("Insert the books title: ");
            string Title = Console.ReadLine();

            Console.WriteLine($"Insert the books author");
            string Author = Console.ReadLine();

            Console.WriteLine($"Insert the books ISBN: ");
            string Isbn = Console.ReadLine();

            Console.WriteLine($"Insert the amount of books (number): ");
            int Amount = int.Parse(Console.ReadLine());


            books.Add(new Book(Title, Author, Isbn, Amount));

    }

    private static void ShowBooks()
    {
        int i = 0;
            foreach (Book b in books)
        {
            i++;
            Console.WriteLine($"\n{i}. {b}");
        }
    }
}