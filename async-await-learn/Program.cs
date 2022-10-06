using System.Threading.Tasks;

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

//await AddAsynchronous();
//Add();

//var random = AddAsynchronous();
//var result = Add();
//await random;

//var random = AddAsynchronous();
//var result = Add();
//random.Wait();

await AddWithTask();
await Add();

//AddAsynchronous();
//AddWithTask();
//Add();

//AddAsynchronous();
//Add();

//async Task<int> AddAsynchronous()
//{
//    int result = 0;
//    await Task.Run(() =>
//        {
//            for (int i = 1; i < 100; i++)
//            {
//                result++;
//                Console.WriteLine("AddAsynchronous is working result= " + result);
//                Task.Delay(10).Wait();
//                Console.WriteLine("Thread ID = " + Thread.CurrentThread.ManagedThreadId);
//            }
//        });

//    return result;
//}

async Task AddAsynchronous()
{
    Console.WriteLine("AddAsynchronous is working");
    await Task.Delay(10);
    Console.WriteLine("AddAsynchronous Thread ID = " + Thread.CurrentThread.ManagedThreadId);
    await Task.Delay(10);
    Console.WriteLine("AddAsynchronous Thread ID = " + Thread.CurrentThread.ManagedThreadId);
    await Task.Delay(300);
    Console.WriteLine("AddAsynchronous Thread ID = " + Thread.CurrentThread.ManagedThreadId);
}

async Task AnotherAsynchronous()
{
    Console.WriteLine("AnotherAsynchronous is working");
    await Task.Delay(10);
    Console.WriteLine("AnotherAsynchronous Thread ID = " + Thread.CurrentThread.ManagedThreadId);
    await Task.Delay(10);
    Console.WriteLine("AnotherAsynchronous Thread ID = " + Thread.CurrentThread.ManagedThreadId);
    await Task.Delay(300);
    Console.WriteLine("AnotherAsynchronous Thread ID = " + Thread.CurrentThread.ManagedThreadId);
}


Task AddWithTask()
{
    TaskCompletionSource<int> taskCompletionSource = new TaskCompletionSource<int>();

    Console.WriteLine("AddWithTask is working");
    Task.Delay(10).ContinueWith(t =>
    {
        Console.WriteLine("AddWithTask Thread ID = " + Thread.CurrentThread.ManagedThreadId);
        Task.Delay(10).ContinueWith(t1 =>
        {
            Console.WriteLine("AddWithTask Thread ID = " + Thread.CurrentThread.ManagedThreadId);
            Task.Delay(10).ContinueWith(t2 =>
            {
                Console.WriteLine("AddWithTask Thread ID = " + Thread.CurrentThread.ManagedThreadId);
            });
        });
    });

    return taskCompletionSource.Task;
}

//Task AddWithTask()
//{
//    Console.WriteLine("AddWithTask is working");
//    Task.Delay(50).ContinueWith(t =>
//  {
//      Console.WriteLine("AddWithTask Thread ID = " + Thread.CurrentThread.ManagedThreadId);
//      Task.Delay(50).ContinueWith(t1 =>
//      {
//          Console.WriteLine("AddWithTask Thread ID = " + Thread.CurrentThread.ManagedThreadId);
//          Task.Delay(50).ContinueWith(t2 =>
//          {
//              Console.WriteLine("AddWithTask Thread ID = " + Thread.CurrentThread.ManagedThreadId);
//          }).Start();
//      }).Start();
//  }).Start();

//    return Task.CompletedTask;
//}

int Add()
{
    var result = 0;

    for (int i = 1; i < 10; i++)
    {
        result++;
        Console.WriteLine("Add is working result= " + result);
        Task.Delay(10).Wait();
        Console.WriteLine("Thread ID = " + Thread.CurrentThread.ManagedThreadId);
    }

    return result;
}