namespace CSharp.Smorgasbord.AsyncAwait;

// Note: Task.Delay(1000) simulates doing work for 1 second.

// I think it's best to think of this as waiting for a response from an external resource.
// Since our code is waiting for a response, the system can set the running task off to the side and come back to it once it's finished.
//
// Meanwhile, it can do some other work on that thread.

public static class ExampleTwo
{
    public static async Task Run()
    {
        Console.WriteLine(DateTime.Now);

        // This block takes 1 second to run because all
        // 5 tasks are running simultaneously
        {
            var a = Task.Delay(1000);
            var b = Task.Delay(1000);
            var c = Task.Delay(1000);
            var d = Task.Delay(1000);
            var e = Task.Delay(1000);

            //await a;
            //await b;
            //await c;
            //await d;
            //await e;
            
            Task.WaitAll(a, b, c, d, e);
        }

        Console.WriteLine(DateTime.Now + " (First block took 1 second)");

        // This block takes 2 seconds to run because of all
        // 5 tasks that where running it is only waiting forone that completes first
        {
            var a = Task.Delay(5000);
            var b = Task.Delay(5000);
            var c = Task.Delay(3000);
            var d = Task.Delay(2000);
            var e = Task.Delay(18000);

            //await a;
            //await b;
            //await c;
            //await d;
            //await e;

            Task.WaitAny(a, b, c, d, e);
        }
        Console.WriteLine(DateTime.Now + " (Seconds block took 2 second)");


        // This block takes 5 seconds to run because each "await"
        // pauses the code until the task finishes
        {
            await Task.Delay(1000);
            await Task.Delay(1000);
            await Task.Delay(1000);
            await Task.Delay(1000);
            await Task.Delay(1000);
        }
        Console.WriteLine(DateTime.Now + " (Third block took 5 seconds)");
    }
}