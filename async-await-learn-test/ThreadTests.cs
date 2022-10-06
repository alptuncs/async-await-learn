using Assert = NUnit.Framework.Assert;

namespace async_await_learn_test;

[TestFixture]
public class ThreadTests : AsyncTestBase
{
    [Test]
    public async Task AddAsync__continues_with_another_thread()
    {
        var expected = Thread.CurrentThread.ManagedThreadId;

        var actual = await AddAsynchronous();


        Assert.That(actual, Is.Not.EqualTo(expected), $"actual: {actual}  expected: {expected}");
    }

    [Test]
    public async Task AddAsyncList__continues_with_another_thread()
    {
        var task = AddAsynchronousList();
        Add();
        var actual = await task;

        Assert.That(actual.FirstOrDefault(), Is.Not.EqualTo(actual[2]));
    }

}