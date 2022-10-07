using async_await_learn;

var chef = new Chef();

chef.PrepareDinner();

await chef.PrepareDinnerAsync();

//chef.PrepareDinnerContinueWith();

while (chef.Complete != true)
{
    Console.WriteLine("Still Working...");
    Thread.Sleep(1000);
}