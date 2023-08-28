// This file contains extension methods for the string class.
// 
// Extension methods enable you to "add" methods to existing types without creating a new derived type, recompiling, or otherwise modifying the original type.
// Extension methods are static methods, but they're called as if they were instance methods on the extended type.
// The first argument to an extension method specifies the type that the method operates on, and is preceded by the this modifier.

namespace System
{
    public static class StringExtension
    {
        public static string Shorten(this string str, int numberOfWords)
        {
            if (numberOfWords < 0) throw new ArgumentOutOfRangeException(nameof(numberOfWords), "Number of words should be greater than or equal to zero.");
            if (numberOfWords == 0) return string.Empty;
            
            var words = str.Split(' ');
            if (words.Length <= numberOfWords)
            {
                return str;
            }
            return string.Join(' ', words.Take(numberOfWords)) + "...";
        }   
    }
}
