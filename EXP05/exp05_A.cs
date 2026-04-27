//run program in synchronous way
using System;

namespace async_await
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program Started");

            Method1();
            Method2();
            Method3();

            Console.WriteLine("Program Finished");
            Console.ReadLine();
        }

        static void Method1()
        {
            Console.WriteLine("Method 1 Execution Started");
            Thread.Sleep(2000); // waits for 2 seconds
            Console.WriteLine("Method 1 Execution Completed");
        }

        static void Method2()
        {
            Console.WriteLine("Method 2 Execution Started");
            Thread.Sleep(2000);
            Console.WriteLine("Method 2 Execution Completed");
        }

        static void Method3()
        {
            Console.WriteLine("Method 3 Execution Started");
            Thread.Sleep(2000);
            Console.WriteLine("Method 3 Execution Completed");
        }
    }
}