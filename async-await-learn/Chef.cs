namespace async_await_learn;

public class Chef
{
    public bool Complete { get; private set; }

    public Chef()
    {

    }

    public async void PrepareDinner()
    {
        Console.WriteLine("Preparing dinner...");
        Thread.Sleep(3000);
        await GetProducts();
    }

    public Task GetProducts()
    {
        var task = new Task(() =>
        {
            Console.WriteLine("Getting products...");
            Thread.Sleep(3000);
            Cook();
        });

        task.Start();
        return task;
    }

    public void Cook()
    {
        Console.WriteLine("Cooking dinner...");
        Thread.Sleep(5000);
        Serve();
    }

    public void Serve()
    {
        Console.WriteLine("Dinner is served...");
        Complete = true;
    }
}
