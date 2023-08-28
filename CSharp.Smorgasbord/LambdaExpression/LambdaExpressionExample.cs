namespace CSharp.Smorgasbord.LambdaExpression;

// A Lambda Expression is an anonymous function that can contain expressions and statements.
// - No access modifier
// - No return type
// - No name

// Why
// For convienence, to avoid creating a method that is only used once.
// More readable code.


// How
// Basic syntax:
// args => expression
// reads like args goes to expression.

public class LambdaExpressionExample
{
    static int Square(int number)
    {
        return number * number;
    }

    public static void Run()
    {
        Console.WriteLine(typeof(LambdaExpressionExample));

        Console.WriteLine(Square(5));

        // Use a lambda expression to create a function that squares a number.
        Func<int, int> sqFunc = number => number * number;
        Console.WriteLine(sqFunc(5));

        // Syntax of lambda
        // No arg:
        // () => expression
        // One arg:
        // arg => expression
        // Multiple args:
        // (arg1, arg2, arg3) => expression

        // Use can also use scoped variables in the expression.
        int factorValue = 2;
        Func<int, int> factor = number => number * factorValue;
        Console.WriteLine(factor(5));



    }
}