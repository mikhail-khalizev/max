using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace MikhailKhalizev.Processor.x86.Utils
{
    // TODO Optimize

    public static class NonBlockingConsole
    {
        private static readonly BlockingCollection<string> Queue = new BlockingCollection<string>(1000);

        static NonBlockingConsole()
        {
            var thread = new Thread(
                () =>
                {
                    while (true)
                    {
                        var cache = new List<string>();
                        while ((cache.Count == 0 || 0 < Queue.Count) && cache.Count < Queue.BoundedCapacity)
                            cache.Add(Queue.Take());

                        Console.WriteLine(string.Join(Environment.NewLine, cache));
                    }
                });
            thread.IsBackground = true;
            thread.Start();
        }

        public static void WriteLine(object value)
        {
            WriteLine(value.ToString());
        }

        public static void WriteLine(string value)
        {
            Queue.Add(value);
        }
    }
}