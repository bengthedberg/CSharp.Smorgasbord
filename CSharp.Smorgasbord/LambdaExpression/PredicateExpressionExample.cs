using CSharp.Smorgasbord.Shared;

namespace CSharp.Smorgasbord.LambdaExpression;

public class PredicateExpressionExample
{
    public static void Run()
    {
        List<Book> books = new List<Book>(new BookRepository().GetBooks());
        
        static bool IsCheapBook(Book book)
        {
            return book.Price < 20;
        }
        var cheapBooks = books.FindAll(IsCheapBook);
        Console.WriteLine("Cheap books:");
        foreach (var book in cheapBooks)
        {
            Console.WriteLine(book);
        }
        
        // A predicate is a function that returns a boolean value. 
        cheapBooks = books.FindAll(book => book.Price < 20);
        Console.WriteLine("Cheap books:");
        foreach (var book in cheapBooks)
        {
            Console.WriteLine(book);
        }

        
    }
}