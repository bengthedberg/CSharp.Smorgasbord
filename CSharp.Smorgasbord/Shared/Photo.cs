namespace CSharp.Smorgasbord.Shared;

public class Photo
{
    public string Path { get; set; }

    public static Photo Load(string path)
    {
        return new Photo { Path = path };
    }

    public void Save()
    {
        Console.WriteLine($"Saving photo {Path}");
    }
}