//AddAsynchronous();

//AddAsynchronous();
//AddAsynchronous();

//await AddAsynchronous();

//AddAsynchronous();
//Task.Delay(100).Wait();

//var number = AddAsynchronous();

//var number = AddAsynchronous();
//Add();

//var otherNumber = await AddAsynchronous();

//Add();

//Add();
//AddAsynchronous();

//AddAsynchronous();
//Add();

//AddWithTask();
//Add();

//AddAsynchronous();
//AddWithTask();
//Add();

//AddAsynchronous();
//Add();

async Task<int> AddAsynchronous()
{
    int result = 0;
    await Task.Run(() =>
        {
            for (int i = 1; i < 100; i++)
            {
                result++;
                Console.WriteLine("AddAsynchronous is working result= " + result);
                Task.Delay(10).Wait();
                Console.WriteLine("Thread ID = " + Thread.CurrentThread.ManagedThreadId);
            }
        });

    return result;
}

async Task AddAsynchronous()
{
    Console.WriteLine("AddAsynchronous is working result= ");
    await Task.Delay(10);
    Console.WriteLine("Thread ID = " + Thread.CurrentThread.ManagedThreadId);
    await Task.Delay(10);
    Console.WriteLine("Thread ID = " + Thread.CurrentThread.ManagedThreadId);
    await Task.Delay(10);
    Console.WriteLine("Thread ID = " + Thread.CurrentThread.ManagedThreadId);
}

Task AddWithTask()
{
    Console.WriteLine("AddWithTask is working result= ");
    var task = Task.Delay(10).ContinueWith(t =>
    {
        Console.WriteLine("Thread ID = " + Thread.CurrentThread.ManagedThreadId);
        Task.Delay(10).ContinueWith(t1 =>
        {
            Console.WriteLine("Thread ID = " + Thread.CurrentThread.ManagedThreadId);
            Task.Delay(10).ContinueWith(t2 =>
            {
                Console.WriteLine("Thread ID = " + Thread.CurrentThread.ManagedThreadId);
            }).Start();
        }).Start();
    });

    task.Start();
    return task;
}

void Add()
{
    var result = 0;

    for (int i = 1; i < 100; i++)
    {
        result++;
        Console.WriteLine("Add is working result= " + result);
        Task.Delay(10).Wait();
        Console.WriteLine("Thread ID = " + Thread.CurrentThread.ManagedThreadId);
    }
}