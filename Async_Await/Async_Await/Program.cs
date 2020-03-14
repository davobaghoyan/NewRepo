using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Async_Await
{
    class Program
    {
        static async Task Main(string[] args)
        {
            //ommitted for brevity
            string message = await DoWorkAsync();
            Console.WriteLine(message);
            Console.WriteLine("GGG");
            Console.ReadLine();
            //ommitted for brevity
        }
        static string DoWork()
        {
            Thread.Sleep(5_000);
            return "Done with work!";
        }
        static async Task<string> DoWorkAsync()
        {
            return await Task.Run(() =>
            {
                Thread.Sleep(5_000);
                return "Done with work!";
            });
        }
      
    }
}
