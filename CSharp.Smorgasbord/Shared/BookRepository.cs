namespace CSharp.Smorgasbord.Shared;

public class BookRepository
{
    public IEnumerable<Book> GetBooks()
    {
        return new List<Book>
        {
            new Book(1) { Title= "Title A", Price = 5},
            new Book(2) { Title= "Title B", Price = 9},
            new Book(3) { Title= "Title C", Price = 7},
            new Book(4) { Title= "Title D", Price = 17},
            new Book(5) { Title= "Title E", Price = 15},
            new Book(6) { Title= "Title F", Price = 12},
            new Book(7) { Title = "Title G", Price = 12},
            new Book(8) { Title= "Title H", Price = 8},
            new Book(9) { Title= "Title I", Price = 4},
            new Book(10) { Title= "Title J", Price = 30}
        };
    }
}