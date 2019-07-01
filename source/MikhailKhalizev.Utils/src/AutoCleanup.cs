using System;

namespace MikhailKhalizev.Utils
{
    /// <summary>
    /// Guarantees automatic execution of delegate functions when an instance of this class is constructed and/or
    /// when it is disposed.
    /// </summary>
    /// <remarks>
    /// The <see cref="AutoCleanup" /> class is used in cases where you would normally use a try/finally to ensure that
    /// your cleanup code is executed, regardless of whether an exception was thrown or not.  With the
    /// <see cref="AutoCleanup" /> class, instead of all of the try/catch lines which can make code less readable,
    /// you can leverage the <see langword="using" /> statement, instantiating an instance of this class,
    /// and pass either just the cleanup code or both the constructor code and cleanup code to execute.
    /// </remarks>
    public class AutoCleanup : IDisposable
    {
        /// <summary>
        /// The delegate function to execute when disposed.
        /// </summary>
        private Action _executeOnDispose;

        /// <summary>
        /// The delegate function to execute when finalized.
        /// </summary>
        private Action _executeOnFinalize;


        /// <summary>
        /// Constructs an <see cref="AutoCleanup" /> object, guaranteeing the execution of a provided delegate
        /// function when disposed.
        /// </summary>
        public AutoCleanup()
            : this(null, null)
        { }

        /// <summary>
        /// Constructs an <see cref="AutoCleanup" /> object, guaranteeing the execution of a provided delegate
        /// function when disposed.
        /// </summary>
        /// <param name="executeOnDispose">The delegate function to execute when disposed.</param>
        public AutoCleanup(Action executeOnDispose)
            : this(null, executeOnDispose)
        { }

        /// <summary>
        /// Constructs an <see cref="AutoCleanup" /> object, immediately executing a delegate function, and
        /// then guaranteeing the execution of a second deletate function when disposed.
        /// </summary>
        /// <param name="executeOnConstruct">The delegate function to execute during construction.</param>
        /// <param name="executeOnDispose">The delegate function to execute when disposed.</param>
        public AutoCleanup(Action executeOnConstruct, Action executeOnDispose)
            : this(executeOnConstruct, executeOnDispose, null)
        { }

        /// <summary>
        /// Constructs an <see cref="AutoCleanup" /> object, immediately executing a delegate function, and
        /// then guaranteeing the execution of a second deletate function when disposed.
        /// </summary>
        /// <param name="executeOnConstruct">The delegate function to execute during construction.</param>
        /// <param name="executeOnDispose">The delegate function to execute when disposed.</param>
        /// <param name="executeOnFinalize">The flag determine should <paramref name="executeOnDispose" /> execute when finalized.</param>
        public AutoCleanup(Action executeOnConstruct, Action executeOnDispose, bool executeOnFinalize)
            : this(executeOnConstruct, executeOnDispose, executeOnFinalize ? executeOnDispose : null)
        { }

        /// <summary>
        /// Constructs an <see cref="AutoCleanup" /> object, immediately executing a delegate function, and
        /// then guaranteeing the execution of a second deletate function when disposed.
        /// </summary>
        /// <param name="executeOnConstruct">The delegate function to execute duringconstruction.</param>
        /// <param name="executeOnDispose">The delegate function to execute when disposed.</param>
        /// <param name="executeOnFinalize">The delegate function to execute when finalized.</param>
        public AutoCleanup(Action executeOnConstruct, Action executeOnDispose, Action executeOnFinalize)
        {
            executeOnConstruct?.Invoke();

            _executeOnDispose = executeOnDispose;
            _executeOnFinalize = executeOnFinalize;

            if (_executeOnFinalize == null)
                GC.SuppressFinalize(this);
        }

        #region IDisposable Members

        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// Finalizes an instance of the <see cref="AutoCleanup" /> class.
        /// </summary>
        ~AutoCleanup()
        {
            Dispose(false);
        }

        /// <summary>
        /// Releases unmanaged and - optionally - managed resources.
        /// </summary>
        /// <param name="disposing">
        /// <c>true</c> to release both managed and unmanaged resources; <c>false</c> to release only
        /// unmanaged resources.
        /// </param>
        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (_executeOnDispose != null)
                {
                    _executeOnDispose();
                    _executeOnDispose = null;
                }
            }
            else
            {
                if (_executeOnFinalize != null)
                {
                    _executeOnFinalize();
                    _executeOnFinalize = null;
                }
            }
        }

        #endregion
    }
}