using System.Runtime.Intrinsics.X86;

namespace CSharp.Smorgasbord.AsyncAwait;


public static class Example
{

    // Before we see what is asynchronous programming, let's understand what is synchronous programming using the following console example.
    public static class SynchronuosExample
    {
        public static void Run()
        {
            LongProcess();

            ShortProcess();
        }

        static void LongProcess()
        {
            Console.WriteLine("LongProcess Started");

            //some code that takes long execution time 
            Thread.Sleep(4000); // hold execution for 4 seconds

            Console.WriteLine("LongProcess Completed");
        }

        static void ShortProcess()
        {
            Console.WriteLine("ShortProcess Started");

            //do something here

            Console.WriteLine("ShortProcess Completed");
        }
    }


    // What is Asynchronous Programming?

    // In asynchronous programming, the code gets executed in a thread without having to wait for an I/O-bound or long-running task to finish.
    // For example, in the asynchronous programming model, the LongProcess() method will be executed in a separate thread from the thread pool,
    // and the main application thread will continue to execute the next statement.
    // When the LongProcess() method completes its execution, it will notify the main application thread, and the main application thread will continue its execution.

    public static class AsynchronuosExample
    {
        public static async Task Run()
        {
            Task result = LongProcess();

            // Independent work which doesn't need the result of LongProcess can be done here
            ShortProcess();

            await result; // wait until the long process has completed
        }

        static async Task LongProcess()
        {
            Console.WriteLine("LongProcess Started");

            //some code that takes long execution time 
            await Task.Delay(4000); // hold execution for 4 seconds

            Console.WriteLine("LongProcess Completed");
        }

        static void ShortProcess()
        {
            Console.WriteLine("ShortProcess Started");

            //do something here

            Console.WriteLine("ShortProcess Completed");
        }
    }
}