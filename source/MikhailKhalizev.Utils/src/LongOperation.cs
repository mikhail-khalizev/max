using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MikhailKhalizev.Utils
{
    /// <summary>
    /// Represent a long-running operation, repeated invoke of which
    /// should be postponed until the previous invoke completes execution.
    /// </summary>
    public class LongOperation
    {
        /// <summary>
        /// The performed operation.
        /// </summary>
        private readonly Func<Task> _action;

        /// <summary>
        /// The lock object.
        /// </summary>
        private readonly object _lock = new object();

        /// <summary>
        /// Contains Tasks that are waiting for the completion of the operation with the specified number.
        /// </summary>
        private readonly SortedDictionary<int, TaskCompletionSource<object>> _operationComplete =
            new SortedDictionary<int, TaskCompletionSource<object>>();

        /// <summary>
        /// Contains operation call count.
        /// </summary>
        private int _callCount;

        /// <summary>
        /// Contains a flag that indicated is the task is being executed.
        /// </summary>
        private bool _isRunning;

        /// <summary>
        /// Contains a flag that indicated is the task needs to be restarted.
        /// </summary>
        private bool _needStartAfterCompletion;

        /// <summary>
        /// Contains the source of the <see cref="OperationsComplete" /> task.
        /// </summary>
        private TaskCompletionSource<bool> _operationsCompleteSource = new TaskCompletionSource<bool>();


        /// <summary>
        /// Initializes an instance of the <see cref="LongOperation" /> class with the specified operation.
        /// </summary>
        /// <param name="action">The method representing the operation.</param>
        public LongOperation(Action action)
            : this(action, default(TimeSpan))
        { }

        /// <summary>
        /// Initializes an instance of the <see cref="LongOperation" /> class with the specified operation.
        /// </summary>
        /// <param name="action">The method representing the operation.</param>
        /// <param name="actionMinWorkTime">Contains the minimum allowed time for the action to take place.</param>
        public LongOperation(Action action, TimeSpan actionMinWorkTime)
            : this(() =>
            {
                action();
                return null;
            }, actionMinWorkTime)
        { }

        /// <summary>
        /// Initializes an instance of the <see cref="LongOperation" /> class with the specified operation.
        /// </summary>
        /// <param name="action">
        /// A function that returns an object of the Task class representing the operation, or null if the
        /// operation is already completed.
        /// </param>
        public LongOperation(Func<Task> action)
            : this(action, default(TimeSpan))
        { }

        /// <summary>
        /// Initializes an instance of the <see cref="LongOperation" /> class with the specified operation.
        /// </summary>
        /// <param name="action">
        /// A function that returns an object of the Task class representing the operation, or null if the
        /// operation is already completed.
        /// </param>
        /// <param name="actionMinWorkTime">Contains the minimum allowed time for the action to take place.</param>
        public LongOperation(Func<Task> action, TimeSpan actionMinWorkTime)
        {
            if (actionMinWorkTime == default(TimeSpan))
                _action = action;
            else
                _action = async () =>
                {
                    var start = DateTime.UtcNow;

                    try
                    {
                        var tsk = action();
                        if (tsk != null)
                            await tsk;
                    }
                    finally
                    {
                        var delay = actionMinWorkTime - (DateTime.UtcNow - start);
                        if (TimeSpan.Zero < delay)
                            await Task.Delay(delay);
                    }
                };

            _operationsCompleteSource.TrySetResult(true);
        }

        /// <summary>
        /// Returns the task that ends when all scheduled operations are completed.
        /// </summary>
        public Task OperationsComplete => _operationsCompleteSource.Task;

        /// <summary>
        /// Starts the operation.
        /// </summary>
        /// <remarks>
        ///     <list>
        ///         <item>Thread safe.</item>
        ///         <item>Restarting the operation at run-time is delayed until the end of the previous one.</item>
        ///         <item>A series of repeated launches is perceived as a single restart.</item>
        ///     </list>
        /// </remarks>
        public Task Invoke()
        {
            TaskCompletionSource<object> tcs;

            lock (_lock)
            {
                // If the action is already in progress, we will schedule a restart at the end.
                if (_isRunning)
                {
                    _needStartAfterCompletion = true;

                    var requiredCall = _callCount + 1;
                    if (!_operationComplete.TryGetValue(requiredCall, out tcs))
                    {
                        tcs = new TaskCompletionSource<object>();
                        _operationComplete[requiredCall] = tcs;
                    }

                    return tcs.Task;
                }

                // Otherwise, run the action immediately.
                _isRunning = true;
                _operationsCompleteSource.TrySetResult(true);
                _operationsCompleteSource = new TaskCompletionSource<bool>();
                _needStartAfterCompletion = false;

                _callCount++;
                if (!_operationComplete.TryGetValue(_callCount, out tcs))
                {
                    tcs = new TaskCompletionSource<object>();
                    _operationComplete[_callCount] = tcs;
                }
            }

            RunActionTask();

            return tcs.Task;
        }

        /// <summary>
        /// Cancels the scheduled restart of the operation.
        /// </summary>
        /// <remarks>Thread-safe.</remarks>
        public void Cancel()
        {
            lock (_lock)
            {
                _needStartAfterCompletion = false;

                foreach (var pair in _operationComplete.SkipWhile(x => x.Key <= _callCount).ToList())
                {
                    pair.Value.TrySetCanceled();
                    _operationComplete.Remove(pair.Key);
                }
            }
        }

        /// <summary>
        /// It is called by an operation to report its completion.
        /// </summary>
        /// <remarks>Thread-safe.</remarks>
        private void Finish()
        {
            lock (_lock)
            {
                while (0 < _operationComplete.Count)
                {
                    var pair = _operationComplete.First();
                    if (_callCount < pair.Key)
                        break;

                    pair.Value.TrySetResult(null);
                    _operationComplete.Remove(pair.Key);
                }

                // If restart is not planned, we finish processing.
                if (!_needStartAfterCompletion)
                {
                    _isRunning = false;
                    _operationsCompleteSource.TrySetResult(true);
                    return;
                }

                // Otherwise, restart the action.
                _needStartAfterCompletion = false;
                _callCount++;
            }

            RunActionTask();
        }

        /// <summary>
        /// Performs the specified operation in new task.
        /// </summary>
        private void RunActionTask()
        {
            Task.Factory.StartNew(RunAction);
        }

        /// <summary>
        /// Performs the specified operation.
        /// </summary>
        private void RunAction()
        {
            Task task = null;

            try
            {
                task = _action();
            }
            finally
            {
                if (task == null || task.IsCompleted)
                    Finish();
                else
                    task.ContinueWith(x => Finish(), TaskContinuationOptions.ExecuteSynchronously);
            }
        }
    }
}