using common_module;

namespace another_worker;

public class anotherWorker : IWorker
{
    public Task RunAsync(string message)
    {
        Console.WriteLine(message + $"{nameof(anotherWorker)}");

        return Task.CompletedTask;
    }
}
