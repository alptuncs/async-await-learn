namespace async_await_learn_test;

public class AsyncTestBase
{
    public async Task<int> AddAsynchronous()
    {
        Console.WriteLine("AddAsynchronous is working result= ");
        await Task.Delay(50);
        Console.WriteLine("Thread ID = " + Thread.CurrentThread.ManagedThreadId);
        await Task.Delay(50);
        Console.WriteLine("Thread ID = " + Thread.CurrentThread.ManagedThreadId);
        await Task.Delay(50);
        Console.WriteLine("Thread ID = " + Thread.CurrentThread.ManagedThreadId);

        return Thread.CurrentThread.ManagedThreadId;
    }

    public async Task<List<int>> AddAsynchronousList()
    {
        var result = new List<int>();

        Console.WriteLine("AddAsynchronous is working result= ");
        await Task.Delay(50);
        Console.WriteLine("Thread ID = " + Thread.CurrentThread.ManagedThreadId);
        result.Add(Thread.CurrentThread.ManagedThreadId);
        await Task.Delay(50);
        Console.WriteLine("Thread ID = " + Thread.CurrentThread.ManagedThreadId);
        result.Add(Thread.CurrentThread.ManagedThreadId);
        await Task.Delay(50);
        Console.WriteLine("Thread ID = " + Thread.CurrentThread.ManagedThreadId);
        result.Add(Thread.CurrentThread.ManagedThreadId);

        return result;
    }
    public void Add()
    {
        var result = 0;

        for (int i = 1; i < 10; i++)
        {
            result++;
            Console.WriteLine("Add is working result= " + result);
            Task.Delay(10).Wait();
            Console.WriteLine("Thread ID = " + Thread.CurrentThread.ManagedThreadId);
        }
    }
}

