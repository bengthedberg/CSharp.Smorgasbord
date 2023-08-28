namespace CSharp.Smorgasbord.Dispose;

public class DisposeExample
{
    // When using classes that implement IDisposable then you must call Dispose method to release resources
    public static void Run()
    {
        StreamReader streamReader = null!;
        try
        {
            streamReader = new StreamReader(@"c:\temp\template.zip");
            var content = streamReader.ReadToEnd();
            Console.WriteLine(content.Length);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            if (streamReader != null)
            {
                streamReader.Dispose();
            }
        }
    }


    // Same as above, but using the using statement.
    // This is the preferred way of doing it.
    public static void RunUsing()
    {
        using (var streamReader = new StreamReader(@"c:\temp\template.zip"))
        {
            var content = streamReader.ReadToEnd();
            Console.WriteLine(content.Length);
        }
    }
}