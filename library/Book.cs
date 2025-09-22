
namespace LibraryApp
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Isbn { get; set; }
        public int Amount { get; set; }

        public Book(string Title, string Author, string Isbn, int Amount)
        {
            this.Title = Title;
            this.Author = Author;
            this.Isbn = Isbn;
            this.Amount = Amount;
        }

        public override string ToString()
        {
            return $"Title: {Title} | Author: {Author} | ISBN: {Isbn} | Amount: {Amount}";
        }

       
    }
}