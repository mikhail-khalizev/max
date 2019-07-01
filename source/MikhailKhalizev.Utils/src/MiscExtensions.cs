using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using JetBrains.Annotations;

namespace MikhailKhalizev.Utils
{
    public static class MiscExtensions
    {
        public static List<T> Transform<T>(List<T> list, Func<T, T> transform)
        {
            for (var i = 0; i < list.Count; i++)
                list[i] = transform(list[i]);
            return list;
        }

        /// <summary>
        /// Выполняет фильтрацию последовательности элементов, оставляя элементы не равные null.
        /// </summary>
        /// <param name="source">Последовательность, подлежащая фильтрации.</param>
        /// <returns>Последовательность, содержащая элементы входной последовательности не равные null.</returns>
        /// <remarks>В случае, если входная последовательность равна null, функция возвращает пустую последовательность.</remarks>
        [NotNull]
        [ItemNotNull]
        public static IEnumerable SkipNull([CanBeNull] this IEnumerable source)
        {
            if (source == null)
                yield break;

            foreach (var x in source)
            {
                if (x != null)
                    yield return x;
            }
        }

        /// <summary>
        /// Выполняет фильтрацию последовательности элементов, оставляя элементы не равные null.
        /// </summary>
        /// <typeparam name="TSource">Тип элементов последовательности source.</typeparam>
        /// <param name="source">Последовательность, подлежащая фильтрации.</param>
        /// <returns>Последовательность, содержащая элементы входной последовательности не равные null.</returns>
        /// <remarks>В случае, если входная последовательность равна null, функция возвращает пустую последовательность.</remarks>
        [NotNull]
        [ItemNotNull]
        public static IEnumerable<TSource> SkipNull<TSource>([CanBeNull] this IEnumerable<TSource> source) =>
            from x in source ?? Enumerable.Empty<TSource>()
            where x != null
            select x;


        [NotNull]
        public static IEnumerable<T> Each<T>([CanBeNull] this IEnumerable<T> source, Action<T> action)
        {
            return source.Each((i, x) => action(x));
        }

        [NotNull]
        public static IEnumerable<T> Each<T>([CanBeNull] this IEnumerable<T> source, Action<int, T> action)
        {
            if (source == null)
                yield break;

            foreach (var p in source.Select((x, i) => new { x, i }))
            {
                action(p.i, p.x);
                yield return p.x;
            }
        }


        public static int IndexOf<T>(
            [CanBeNull] this IEnumerable<T> source,
            Func<T, bool> condition,
            int defaultIfNotFound = -1)
        {
            if (source == null)
                return defaultIfNotFound;

            return source
                .Select((x, i) => new { Value = x, Index = i })
                .Where(x => condition(x.Value))
                .Select(x => x.Index)
                .DefaultIfEmpty(defaultIfNotFound)
                .First();
        }

        [NotNull]
        public static IEnumerable<TSource> DistinctBy<TSource, TKey>(
            [CanBeNull] this IEnumerable<TSource> source,
            Func<TSource, TKey> keySelector)
        {
            if (source == null)
                yield break;

            var keys = new HashSet<TKey>();
            foreach (var element in source)
            {
                if (keys.Add(keySelector(element)))
                    yield return element;
            }
        }


        [NotNull]
        public static IEnumerable<IReadOnlyList<T>> Split<T>([CanBeNull] this IEnumerable<T> source, int chunkSize)
        {
            if (source == null)
                yield break;

            var list = new List<T>(chunkSize);
            foreach (var element in source)
            {
                list.Add(element);
                if (chunkSize <= list.Count)
                {
                    yield return list;
                    list = new List<T>(chunkSize);
                }
            }

            if (list.Count != 0)
                yield return list;
        }


        /// <summary>
        /// Возвращает новый экземпляр класса <see cref="ReaderWriterLockSlimWrap" /> с установленной блокировкой в режиме чтения.
        /// </summary>
        /// <param name="slim">Целевой объект блокировки.</param>
        public static ReaderWriterLockSlimWrap StartRead(this ReaderWriterLockSlim slim)
        {
            var ret = new ReaderWriterLockSlimWrap(slim);
            ret.EnterReadLock();
            return ret;
        }

        /// <summary>
        /// Возвращает новый экземпляр класса <see cref="ReaderWriterLockSlimWrap" /> с установленной блокировкой в обновляемом
        /// режиме.
        /// </summary>
        /// <param name="slim">Целевой объект блокировки.</param>
        public static ReaderWriterLockSlimWrap StartUpgradeableRead(this ReaderWriterLockSlim slim)
        {
            var ret = new ReaderWriterLockSlimWrap(slim);
            ret.EnterUpgradeableReadLock();
            return ret;
        }

        /// <summary>
        /// Возвращает новый экземпляр класса <see cref="ReaderWriterLockSlimWrap" /> с установленной блокировкой в режиме записи.
        /// </summary>
        /// <param name="slim">Целевой объект блокировки.</param>
        public static ReaderWriterLockSlimWrap StartWrite(this ReaderWriterLockSlim slim)
        {
            var ret = new ReaderWriterLockSlimWrap(slim);
            ret.EnterWriteLock();
            return ret;
        }

        /* Delete ?

        /// <summary>
        /// Преобразовывает объект в объект типа <paramref name="type"/>.
        /// </summary>
        /// <param name="type">Целевой тип объекта.</param>
        /// <param name="source">Объект, подлежащий преобразованию или null.</param>
        /// <returns>Объект типа <paramref name="type"/>, представляющий входной объект <paramref name="source"/> или null.</returns>
        [CanBeNull]
        public static object As(this object source, Type type)
        {
            var methodAs = typeof(ExoExtensions).GetMethod(nameof(AsGeneric), BindingFlags.NonPublic | BindingFlags.Static);
            methodAs = methodAs.MakeGenericMethod(type);

            return methodAs.Invoke(null, new[] { source });
        }

        /// <summary>
        /// Преобразовывает объект в объект типа <typeparamref name="T"/>.
        /// </summary>
        /// <typeparam name="T">Целевой тип объекта.</typeparam>
        /// <param name="source">Объект, подлежащий преобразованию или null.</param>
        /// <returns>Объект типа <typeparamref name="T"/>, представляющий входной объект <paramref name="source"/> или null.</returns>
        [UsedImplicitly]
        private static object AsGeneric<T>(object source) where T : class
        {
            return source as T;
        }

        /// <summary>
        /// Преобразовывает неуниверсальный объект <see cref="IEnumerable"/> 
        /// в универсальный объект <see cref="IQueryable{T}"/> фильтруя элементы по заданому типу.
        /// </summary>
        /// <param name="type">Тип, по которому фильтруются элементы последовательности.</param>
        /// <param name="source">Последовательность, подлежащая преобразованию или null.</param>
        /// <returns>Объект <see cref="IQueryable"/>, представляющий входную последовательность.</returns>
        [NotNull]
        public static IQueryable AsQueryableOfType(this IEnumerable source, Type type)
        {
            var method = typeof(ExoExtensions).GetMethod(nameof(AsQueryableOfTypeGeneric), BindingFlags.NonPublic | BindingFlags.Static);
            method = method.MakeGenericMethod(type);

            return (IQueryable)method.Invoke(null, new object[] { source });
        }

        /// <summary>
        /// Преобразовывает неуниверсальный объект <see cref="IEnumerable"/> в универсальный объект <see cref="IQueryable{T}"/>.
        /// </summary>
        /// <typeparam name="T">Тип элементов последовательности <paramref name="source"/>.</typeparam>
        /// <param name="source">Последовательность, подлежащая преобразованию или null.</param>
        /// <returns>Объект <see cref="IQueryable{T}"/>, представляющий входную последовательность.</returns>
        [UsedImplicitly]
        private static IQueryable<T> AsQueryableOfTypeGeneric<T>(IEnumerable source)
        {
            return source?.OfType<T>().AsQueryable() ?? Enumerable.Empty<T>().AsQueryable();
        }

        /// <summary>
        /// Преобразовывает неуниверсальный объект <see cref="IEnumerable"/> 
        /// в универсальный объект <see cref="IEnumerable{T}"/> фильтруя элементы по заданому типу.
        /// </summary>
        /// <param name="type">Тип, по которому фильтруются элементы последовательности.</param>
        /// <param name="source">Последовательность, подлежащая преобразованию или null.</param>
        /// <returns>Объект <see cref="IEnumerable"/>, представляющий входную последовательность.</returns>
        [NotNull]
        public static IEnumerable AsEnumerableOfType(this IEnumerable source, Type type)
        {
            var method = typeof(ExoExtensions).GetMethod(nameof(AsEnumerableOfTypeGeneric), BindingFlags.NonPublic | BindingFlags.Static);
            method = method.MakeGenericMethod(type);

            return (IEnumerable)method.Invoke(null, new object[] { source });
        }

        /// <summary>
        /// Преобразовывает неуниверсальный объект <see cref="IEnumerable"/> в универсальный объект <see cref="IEnumerable{T}"/>.
        /// </summary>
        /// <typeparam name="T">Тип элементов последовательности <paramref name="source"/>.</typeparam>
        /// <param name="source">Последовательность, подлежащая преобразованию или null.</param>
        /// <returns>Объект <see cref="IEnumerable{T}"/>, представляющий входную последовательность.</returns>
        [UsedImplicitly]
        private static IEnumerable<T> AsEnumerableOfTypeGeneric<T>(IEnumerable source)
        {
            return source?.OfType<T>() ?? Enumerable.Empty<T>();
        }
        
        */

        /// <summary>
        /// Изменяет порядок элементов на противоположный.
        /// </summary>
        /// <typeparam name="T">Тип элементов последовательности source.</typeparam>
        /// <param name="source">Последовательность значений, которые следует расставить в обратном порядке.</param>
        /// <returns>
        /// Последовательность, элементы которой соответствуют элементам входной коллекции, но следуют в противоположном
        /// порядке.
        /// </returns>
        public static IEnumerable<T> Reverse<T>(this IList<T> source)
        {
            for (var i = source.Count - 1; i >= 0; i--)
                yield return source[i];
        }


        /// <summary>
        /// Возвращает исходную строку, если она содержит символы, иначе - null.
        /// </summary>
        /// <param name="source">Исходная строка.</param>
        /// <returns>Исходная строка, если она содержит символы, иначе - null.</returns>
        public static string NullIfEmpty(this string source) => string.IsNullOrEmpty(source) ? null : source;

        public static string Left(this string source, int count)
        {
            if (source == null)
                return null;

            if (source.Length <= count)
                return source;

            return source.Substring(0, count);
        }

        /// <summary>
        /// Возвращает заданное количество последних символов строки.
        /// </summary>
        /// <param name="source">Исходная строка.</param>
        /// <param name="count">Количество последних символов строки, которые требуется вернуть в качестве новой строки.</param>
        /// <returns>
        /// Новая строка, содержащая заданное количество последних символов строки.
        /// Если длина исходной строки меньше Count, исходная строка возвращается без изменений.
        /// </returns>
        public static string Right(this string source, int count)
        {
            if (source == null)
                return null;

            if (source.Length <= count)
                return source;

            return source.Substring(source.Length - count);
        }


        public static FieldInfo GetBackingField(this PropertyInfo pi)
        {
            if (!pi.CanRead || !pi.GetGetMethod(true).IsDefined(typeof(CompilerGeneratedAttribute), true))
                return null;
            var backingField = pi.DeclaringType.GetField($"<{pi.Name}>k__BackingField",
                BindingFlags.Instance | BindingFlags.NonPublic);
            if (backingField == null)
                return null;
            if (!backingField.IsDefined(typeof(CompilerGeneratedAttribute), true))
                return null;
            return backingField;
        }

        public static T GetStructure<T>(this byte[] exeBytes)
        {
            var handle = GCHandle.Alloc(exeBytes, GCHandleType.Pinned);
            try
            {
                return Marshal.PtrToStructure<T>(handle.AddrOfPinnedObject());
            }
            finally
            {
                handle.Free();
            }
        }

        // Add a Contains extension method for string.
        public static bool Contains(
            this string container,
            string subString,
            StringComparison comparisonType)
        {
            if (container == null)
                throw new ArgumentNullException(nameof(container));

            if (subString == null)
                throw new ArgumentNullException(nameof(subString));

            return container.IndexOf(subString, comparisonType) > -1;
        }
    }
}