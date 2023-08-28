using CSharp.Smorgasbord.Shared;

namespace CSharp.Smorgasbord.Generics
{
    public class GenericsSample
    {
        // This class only works with integers
        public class IntList
        {
            private readonly List<int> _data = new();

            public void Add(int value)
            {
                _data.Add(value);
            }

            public int? this[int index] => _data[index];


            // More method like Remove, Find etc...
        }

        // If we want to use the class with other types we need to create a new class
        // for each type.
        public class ListBooks
        {
            private readonly List<Book> _data = new();

            public void Add(Book value)
            {
                _data.Add(value);
            }

            public Book? this[int index] => _data[index];
            // More method like Remove, Find etc...
        }

        // To avoid this the class can use object as type.
        public class ObjectList
        {
            private readonly List<object> _data = new();
            public void Add(object value)
            {
                _data.Add(value);
            }

            public object? this[int index] => _data[index];

            // More method like Remove, Find etc...
        }

        // But this will cause boxing and unboxing. This has a performance impact if you use this for a value type as well as casting between object types.
     
        // The solution is to use generics.

        public class GenericList<T>
        {
            public void Add(T value)
            {
                throw new NotImplementedException();
            }

            public T this[int index]
            {
                get { throw new NotImplementedException(); }
            }
            // More method like Remove, Find etc...
        }
    }

}

