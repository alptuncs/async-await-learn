namespace async_await_learn;

public class Chef
{
    public bool Complete { get; private set; }

    public Chef()
    {

    }

    public void PrepareDinner()
    {
        Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
        Console.WriteLine("Preparing dinner...");
        Task.Delay(300).Wait();

        Console.WriteLine("Getting products...");
        Task.Delay(300).Wait();

        Console.WriteLine("Cooking dinner...");
        Task.Delay(500).Wait();

        Task.Delay(500).Wait();
        Console.WriteLine("Dinner is served...");
        Complete = true;
        Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
    }

    public async Task PrepareDinnerAsync()
    {
        Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
        Console.WriteLine("Preparing dinner...");
        await Task.Delay(300);

        Console.WriteLine("Getting products...");
        await Task.Delay(300);

        Console.WriteLine("Cooking dinner...");
        await Task.Delay(500);

        await Task.Delay(500);
        Console.WriteLine("Dinner is served...");
        Complete = true;
        Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
    }

    public Task PrepareDinnerContinueWith()
    {
        return Task.Delay(10).ContinueWith(t =>
         {
             Console.WriteLine("Preparing dinner...");
             Thread.Sleep(3000);

             Task.Delay(10).ContinueWith(t1 =>
             {
                 Console.WriteLine("Getting products...");
                 Thread.Sleep(3000);

                 Task.Delay(10).ContinueWith(t2 =>
                 {
                     Console.WriteLine("Cooking dinner...");
                     Thread.Sleep(5000);
                     Task.Delay(10).ContinueWith(t3 =>
                     {
                         Thread.Sleep(5000);
                         Console.WriteLine("Dinner is served...");
                         Complete = true;
                     });
                 });
             });
         });
    }
}
