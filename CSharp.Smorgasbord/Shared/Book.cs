namespace CSharp.Smorgasbord.Shared;

public class Book : IComparable<Book>
{
    public int Id { get; private set; }
    public string Title { get; set; } = string.Empty;
    public int Price { get; set; }

    public Book(int id)
    {
        Id = id;
    }

    public override string ToString()
    {
        return base.ToString() + $":{Id}:{Title}:{Price}";
    }

    public int CompareTo(Book? other)
    {
        return Id.CompareTo(other?.Id);
    }
}

