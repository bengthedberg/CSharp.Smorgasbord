using CSharp.Smorgasbord.Shared;

namespace CSharp.Smorgasbord.Delegates;

// A delegate is an object that knows how to call a method or a group of methods. Basically a pointer to a function/s.

// Normally we use delegates to implement events and call back methods.

// Use delegates when
// - an eventing design pattern is used in a program.
// - the caller does not need to access other properties, methods, or interfaces on the object implementing the method.

// In the below example the photo only needs to be passed to the filter method. Nothing else is used.

// Use interfaces with polymorphism when
// - the caller must access other members on the object implementing the method.
// - the caller must pass the object to other code in a strongly-typed manner.

public class DelegateExample
{

    public class PhotoProcessor
    {

        // This code is not extensible as we need to change the code in the class to add a new filter.
        public void ProcessNoDelegate(string path)
        {
            var photo = Photo.Load(path);
            var filters = new PhotoFilters();
            filters.ApplyBrightness(photo);
            filters.ApplyContrast(photo);
            filters.Resize(photo);
            photo.Save();
        }
        
        // To make the code more extensible we can use delegates (also use interface with polymorphism). 
        
        // Use delegates 

        // Delegate type that can point to a function that takes a Photo as parameter and returns void.
        public delegate void PhotoFilterHandler(Photo photo);

        // Pass the delegate as parameter to the function.
        public void Process(string path, PhotoFilterHandler filterHandler)
        {
            var photo = Photo.Load(path);
            filterHandler(photo);
            photo.Save();
        }

        // Simplfy by using the built in delegate type Action<T> or Func<T, TResult>. No need to define a delegate type.
        public void ProcessWithAction(string path, Action<Photo> filterHandler)
        {
            var photo = Photo.Load(path);
            filterHandler(photo);
            photo.Save();
        }

    }

    public static void Run()
    {
        Console.WriteLine(typeof(DelegateExample));
        var processor = new PhotoProcessor();
        processor.ProcessNoDelegate("photo.jpg");

        // Use delegates solution, this is more extensible as the code in the class does not need to be changed to add a new filter.
        var filters = new PhotoFilters();
        PhotoProcessor.PhotoFilterHandler filterHandler;
        filterHandler = filters.ApplyBrightness;
        filterHandler += filters.Resize;
        processor.Process("photo.jpg", filterHandler);

        // Use the built in delegate type Action<T> or Func<T, TResult>. No need to define a delegate type.
        Action<Photo> filterActionHandler;
        filterActionHandler = filters.ApplyContrast;
        filterActionHandler += filters.Resize;
        processor.ProcessWithAction("photo.jpg", filterActionHandler);
    }
}