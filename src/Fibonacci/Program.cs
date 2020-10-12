using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Fibonacci
{
    /*
    public static class Compute
    {
        private static int Fib(int i)
        {
            if (i <= 2) return 1;
            return Fib(i - 2) + Fib(i - 1);
        }
        
        static void Main(string[] args)
        {
            var timer = new Stopwatch();
            timer.Start();
            
            IList<Task<int>> tasks = new List<Task<int>>();
            var results = new ConcurrentBag<int>();
            
            Parallel.ForEach(args, (arg) =>
            {
                var result = Fib(Convert.ToInt32(arg));
                results.Add(result);
            });

          foreach (var result in results)
          {
              Console.WriteLine("result: " + result);
          }
            timer.Stop();
            Console.WriteLine(timer.Elapsed.TotalSeconds);
        }
    }
    */
    
    public static class Compute
    {
        public static int Fib(int i)
        {
            if (i <= 2) return 1;
            return Fib(i - 2) + Fib(i - 1);
        }

        public static IList<int> Execute(String[] args)
        {
            var results = new ConcurrentBag<int>();
            Parallel.ForEach(args, (arg) =>
            {
                var result = Fib(int.Parse(arg));
                results.Add(result);
            });
            return results.ToList();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("work");
        }
    }
}
