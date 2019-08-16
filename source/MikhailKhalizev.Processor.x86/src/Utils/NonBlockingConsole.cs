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
        public static Task AllWritten => _tcs.Task;
        private static TaskCompletionSource<int> _tcs = new TaskCompletionSource<int>();

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

                        if (_tcs.Task.IsCompleted)
                            _tcs = new TaskCompletionSource<int>();

                        Console.WriteLine(string.Join(Environment.NewLine, cache));

                        if (Queue.Count == 0)
                            _tcs.TrySetResult(0);
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