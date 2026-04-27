using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("Start of Program");

        Task task1 = DoWorkAsync();

        Console.WriteLine("Main method continues execution...");

        await task1;

        Console.WriteLine("End of Program");
    }

    static async Task DoWorkAsync()
    {
        Console.WriteLine("Task started...");

        // Simulating long-running task
        await Task.Delay(3000);

        Console.WriteLine("Task completed after delay");
    }
}