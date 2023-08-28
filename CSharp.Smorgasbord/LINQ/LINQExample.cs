using CSharp.Smorgasbord.Shared;

namespace CSharp.Smorgasbord.LINQ;

public class LINQExample
{
    public static void Run()
    {

        IEnumerable<int> numbers = new List<int> { 7, 13, 77, 4, 7 };

        Console.WriteLine($"The largest number is {numbers.Max()}");
        Console.WriteLine($"The average number is {numbers.Average()}");
        Console.WriteLine($"The minimum number is {numbers.Min()}");
        Console.WriteLine($"The number of large number (>10) are {numbers.Count(x => x > 10)}");

        var books = new BookRepository().GetBooks();

        // Use LINQ to find the cheapests books in the list and order on title:
        var cheapBooks = books
            .Where(book => book.Price < 10)
            .OrderBy(b => b.Title);
        foreach (var b in cheapBooks)
            Console.WriteLine(b);

        // Find the cheapest books in the lists and transform to a new anonymous class:
        var transform = books
            .Where(book => book.Price < 10)
            .Select(b => new { b.Id, b.Title });
        foreach (var b in transform)
            Console.WriteLine(b);

        // Exactly one book that meet the criteria, must exists:
        // If not then InvalidOperationException: Sequence contains no matching element
        var book = books.Single(b => b.Id == 1);
        Console.WriteLine($"{book}");

        // Exactly one book that meet the criteria, may or maynot exists:
        var bookNull = books.SingleOrDefault(b => b.Id == 999);
        Console.WriteLine($"bookNull is {bookNull}");

        var firstBook = books.First();
        Console.WriteLine($"First {firstBook}");

        var lastBook = books.Last();
        Console.WriteLine($"last {lastBook}");

        // Take a partition of the book list, starting at index 2 and take 3 books:
        var pagedBook = books.Skip(2).Take(3);
        foreach (var b in pagedBook)
            Console.WriteLine(b);

        // Return the book with the highest price:
        var maxPrice = books.Max(b => b.Price);
        Console.WriteLine($"Max price is {maxPrice}");

        // Return the book with the highest price:
        var avgPrice = books.Average(b => b.Price);
        Console.WriteLine($"Average price is {avgPrice}");




    }
}