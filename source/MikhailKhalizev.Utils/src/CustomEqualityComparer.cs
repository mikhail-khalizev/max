using System;
using System.Collections.Generic;

namespace MikhailKhalizev.Utils
{
    /// <summary>
    /// Представляет настраиваемую реализацию <see cref="IEqualityComparer{T}" />.
    /// Реализует методы для поддержки операций сравнения объектов в отношении
    /// равенства на основе заданных при инициализации класса методов.
    /// </summary>
    /// <typeparam name="T">
    /// Тип объектов для сравнения. Этот параметр типа является контрвариантным.
    /// Это означает, что можно использовать либо указанный тип, либо менее
    /// производный тип Дополнительные сведения о ковариации и контрвариации см.
    /// в разделе Ковариация и контравариация в универсальных шаблонах.
    /// </typeparam>
    public class CustomEqualityComparer<T> : IEqualityComparer<T>
    {
        /// <summary>
        /// Содержит метод сравнения двух объектов.
        /// </summary>
        private readonly Func<T, T, bool> _equals;

        /// <summary>
        /// Содержит метод вычисления хэш-кода объекта.
        /// </summary>
        private readonly Func<T, int> _hash;


        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="CustomEqualityComparer{T}" />
        /// с заданными методами сравнения двух объектов и вычисления хэш-кода объекта.
        /// </summary>
        /// <param name="comparer">Метод сравнения двух объектов.</param>
        /// <param name="hash">Метод вычисления хэш-кода объекта.</param>
        public CustomEqualityComparer(Func<T, T, bool> comparer, Func<T, int> hash)
        {
            _equals = comparer;
            _hash = hash;
        }

        /// <summary>
        /// Определяет, равны ли два указанных объекта.
        /// </summary>
        /// <param name="x">Первый сравниваемый объект типа T.</param>
        /// <param name="y">Второй сравниваемый объект типа T.</param>
        /// <returns>Значение true, если указанные объекты равны; в противном случае — значение false.</returns>
        public bool Equals(T x, T y) => _equals(x, y);

        /// <summary>
        /// Возвращает хэш-код указанного объекта.
        /// </summary>
        /// <param name="obj">Объект, для которого должен быть возвращен хэш-код.</param>
        /// <returns>Хэш-код указанного объекта.</returns>
        public int GetHashCode(T obj) => _hash(obj);
    }
}