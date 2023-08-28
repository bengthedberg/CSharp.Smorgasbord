using CSharp.Smorgasbord.Delegates;
using CSharp.Smorgasbord.Shared;

namespace CSharp.Smorgasbord.Generics;

public static class GenericWithContraints
{
    //  Create a function that returns the largest value of 2.
    public static int Max(int a, int b)
    {
        return a > b ? a : b;
    }

    // Make it generic so it can be used with any type.
    // public T Max<T>(T a, T b)
    //{
    //   return a > b ? a : b;  // <--- Error: Operator '>' cannot be applied to operands of type 'T' and 'T'
    //}

    // We need to apply a constraint to the generic type.
    // The constraint is that the type must implement the IComparable interface.
    public static T Max<T>(T a, T b) where T : IComparable<T>
    {
        return a.CompareTo(b) > 0 ? a : b;
    }

    // The constraint can also be a class, (that is a Reference type).
    // The constraint is that the type must be a class and implement the IComparable interface.
    public static T MaxClass<T>(T a, T b) where T : class, IComparable<T>
    {
        return a.CompareTo(b) > 0 ? a : b;
    }

    // The constraint can also be a struct, (that is a Value Type)
    // The constraint is that the type must be a struct and implement the IComparable interface.
    public static T MaxStruct<T>(T a, T b) where T : struct, IComparable<T>
    {
        return a.CompareTo(b) > 0 ? a : b;
    }

    public static void Run()
    {
        Console.WriteLine(typeof(GenericWithContraints));
        Console.WriteLine(GenericWithContraints.Max(1, 2));
        Console.WriteLine(GenericWithContraints.Max("a", "b"));
        Console.WriteLine(GenericWithContraints.Max<Book>(new Book(1), new Book(2)));
        Console.WriteLine(GenericWithContraints.MaxClass(new Book(1), new Book(2)));
        Console.WriteLine(GenericWithContraints.MaxStruct(1, 2));
    }
    
}