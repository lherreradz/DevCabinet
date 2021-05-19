using System;
using System.Threading;
using System.Threading.Tasks;

namespace Async
{
    class Program
    {
        static async Task Main(string[] args)
        {
            await Task.Run(PrepareCoffe);

            Console.WriteLine("Done!");
        }
        private static async Task PrepareCoffe()
        {
            Console.WriteLine("Start preparing coffe");
            Thread.Sleep(5000);
            Console.WriteLine("The coffe is ready");
        }
    }
}
