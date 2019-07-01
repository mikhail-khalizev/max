using System;
using System.Threading;

namespace MikhailKhalizev.Utils
{
    /// <summary>
    /// Обёртка над <see cref="ReaderWriterLockSlim" />.
    /// </summary>
    public class ReaderWriterLockSlimWrap : IDisposable
    {
        /// <summary>
        /// Содержит целевой <see cref="ReaderWriterLockSlim" />.
        /// </summary>
        private readonly ReaderWriterLockSlim _slim;


        /// <summary>
        /// Содержит признак, показывающий, был ли уже произведён вызов <see cref="Dispose(bool)" />.
        /// </summary>
        private bool _disposed;


        /// <summary>
        /// Содержит признак, показывающий был ли выполнен вход в блокировку в режиме чтения.
        /// </summary>
        private bool _readLock;

        /// <summary>
        /// Содержит признак, показывающий был ли выполнен вход в блокировку в обновляемом режиме.
        /// </summary>
        private bool _upgradeableReadLock;

        /// <summary>
        /// Содержит признак, показывающий был ли выполнен вход в блокировку в режиме записи.
        /// </summary>
        private bool _writeLock;

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="ReaderWriterLockSlimWrap" />.
        /// </summary>
        /// <param name="slim">Целевой объект блокировки.</param>
        public ReaderWriterLockSlimWrap(ReaderWriterLockSlim slim)
        {
            Monitor.Enter(
                this); // Избегаем неправильного использование, когда кто-то делает lock от экземпляра класса вместо using.
            _slim = slim;
        }


        /// <summary>
        /// Пытается выполнить вход в блокировку в режиме чтения.
        /// </summary>
        public void EnterReadLock()
        {
            if (_readLock)
                return;

            _readLock = true;
            _slim.EnterReadLock();
        }

        /// <summary>
        /// Пытается выполнить вход в блокировку в обновляемом режиме.
        /// </summary>
        public void EnterUpgradeableReadLock()
        {
            if (_upgradeableReadLock)
                return;

            _upgradeableReadLock = true;
            _slim.EnterUpgradeableReadLock();
        }

        /// <summary>
        /// Пытается выполнить вход в блокировку в режиме записи.
        /// </summary>
        public void EnterWriteLock()
        {
            if (_writeLock)
                return;

            _writeLock = true;
            _slim.EnterWriteLock();
        }


        /// <summary>
        /// Уменьшает счетчик глубины рекурсии для режима чтения и выходит из режима чтения, если счетчик принял значение 0 (нуль).
        /// </summary>
        public void ExitReadLock()
        {
            if (!_readLock)
                return;

            _readLock = false;
            _slim.ExitReadLock();
        }

        /// <summary>
        /// Уменьшает счетчик глубины рекурсии для обновляемого режима и выходит из обновляемого режима, если счетчик принял
        /// значение 0 (нуль).
        /// </summary>
        public void ExitUpgradeableReadLock()
        {
            if (!_upgradeableReadLock)
                return;

            _upgradeableReadLock = false;
            _slim.ExitUpgradeableReadLock();
        }

        /// <summary>
        /// Уменьшает счетчик глубины рекурсии для режима записи и выходит из режима записи, если счетчик принял значение 0 (нуль).
        /// </summary>
        public void ExitWriteLock()
        {
            if (!_writeLock)
                return;

            _writeLock = false;
            _slim.ExitWriteLock();
        }

        /// <summary>
        /// Освобождает все ресурсы, используемые текущим экземпляром класса.
        /// </summary>
        public void Dispose()
        {
            // Не изменяйте этот код. Разместите код очистки выше в методе Dispose(bool disposing).
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// Освобождает неуправляемые ресурсы, используемые текущим экземпляром класса (при
        /// необходимости освобождает и управляемые ресурсы).
        /// </summary>
        /// <param name="disposing">
        /// Значение true, чтобы освободить все ресурсы (управляемые и неуправляемые); значение false,
        /// чтобы освободить только неуправляемые ресурсы.
        /// </param>
        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed && disposing)
            {
                ExitWriteLock();
                ExitUpgradeableReadLock();
                ExitReadLock();
            }

            _disposed = true;
        }
    }
}