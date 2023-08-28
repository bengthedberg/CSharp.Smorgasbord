namespace CSharp.Smorgasbord.ExtensionMethods;

public class StringExtensionExample
{
    public static void Run()
    {
        var numkWords = 5;
        string post = "This is supposed to be a very long blog post blah blah blah...";
        var shortenedPost = post.Shorten(numkWords);

        Console.WriteLine($"{post}");
        Console.WriteLine($"{numkWords} {shortenedPost}");

    }
}