using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Leonardo;

public class Fibonacci
{
    public static int Run(int i)
    {
        if (i <= 2)
            return 1;
        return Run(i - 1) + Run(i - 2);
    }

    public static async Task<IList<int>> RunAsync(string[] args)
    {
        IList<int> results = new List<int>();
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        var tasks = new List<Task<int>>();
        foreach(var arg in args)
        {
            var task = Task.Run(() =>
            {
                var result = Fibonacci.Run(int.Parse(arg));
                Console.WriteLine($"Elapsed time: {stopwatch.ElapsedMilliseconds} ms {arg}");
                return result;
            });
            tasks.Add(task);
        }
        foreach (var task in tasks)
        {
            
            var result = await task;
            Console.WriteLine($"Result: {task.Result}");
            results.Add(task.Result);
        }
        stopwatch.Stop();
        Console.WriteLine("Total elapsed time: {0} ms", stopwatch.ElapsedMilliseconds);

        return results;
    }
}





/*namespace DefaultNamespace;

using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Leonardo
{
    public static class Fibonacci
    {
        public static async Task<IList<int>> RunAsync(string[] args)
        {
            
            var tasks = new List<Task<int>>();

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            foreach (var arg in args)
            {

                var task = Task.Run(() =>
                {
                    var result1 = Fibonacci.Run(int.Parse(arg));
                    Console.WriteLine($"Elapsed Time: {stopwatch.ElapsedMilliseconds} ms {arg}");
                    return result1;
                });
                tasks.Add(task);
                //Console.WriteLine($"Résulat: {Fibonacci.Run(int.Parse(arg))}");
                //Console.WriteLine(stopwatch.ElapsedMilliseconds);
            }
            
            foreach (var task in tasks)
            {
                Console.WriteLine($"Result: {task.Result}");
            }
            
            await Task.Delay(2000);
            return tasks;
        }
    }
}

// See https://aka.ms/new-console-template for more information
using Leonardo;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;

Console.WriteLine("Hello, World!");



Task.WaitAll(tasks.ToArray());

Console.WriteLine(stopwatch.ElapsedMilliseconds);
stopwatch.Stop();
namespace Leonardo
{
    static class Fibonacci{
        public static int Run(int i)
        {
            if (i <= 2)
            {
                return 1;
            }

            return Run(i - 1) + Run(i - 2);
        }
    }
}
*/