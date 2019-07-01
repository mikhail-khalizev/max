using System;
using System.Collections.Immutable;
using System.Threading;
using System.Threading.Tasks;

namespace MikhailKhalizev.Utils
{
    /// <summary>
    /// Provides a queue of long-running sequential operations.
    /// </summary>
    public class LongOperationQueue
    {
        private readonly LongOperation _longOperation;
        private ImmutableQueue<Func<Task>> _queue = ImmutableQueue<Func<Task>>.Empty;

        /// <summary>
        /// Initializes a new instance of the class <see cref="LongOperationQueue" />.
        /// </summary>
        public LongOperationQueue()
        {
            _longOperation = new LongOperation(Operation);
        }

        /// <summary>
        /// Adds a method to the queue and starts executing operations.
        /// </summary>
        /// <remarks>Thread-safe.</remarks>
        public Task Enqueue(Func<Task> act, CancellationToken cancellationToken = default)
        {
            return Enqueue<object>(async () =>
            {
                await act();
                return null;
            }, cancellationToken);
        }

        /// <summary>
        /// Adds a method to the queue and starts executing operations.
        /// </summary>
        /// <remarks>Thread-safe.</remarks>
        public async Task<T> Enqueue<T>(
            Func<Task<T>> act,
            CancellationToken cancellationToken = default)
        {
            var tcs = new TaskCompletionSource<T>();
            using (var cancelRegistered = cancellationToken.Register(() => tcs.TrySetCanceled()))
            {
                ImmutableInterlocked.Enqueue(ref _queue, async () =>
                {
                    try
                    {
                        // Disable automatic cancellation because now only act() determine when the task will be canceled.
                        cancelRegistered.Dispose();

                        if (cancellationToken.IsCancellationRequested)
                        {
                            tcs.TrySetCanceled(cancellationToken);
                            return;
                        }

                        var result = await act();
                        tcs.TrySetResult(result);
                    }
                    catch (Exception ex)
                    {
                        tcs.TrySetException(ex);
                    }
                });
                _longOperation.Invoke(); // todo .ForgotTask();

                return await tcs.Task;
            }
        }

        private async Task Operation()
        {
            while (ImmutableInterlocked.TryDequeue(ref _queue, out var act))
                await act();
        }
    }
}