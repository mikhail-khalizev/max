using System;
using System.Collections.Generic;
using System.ComponentModel;
using MikhailKhalizev.Processor.x86.CSharpExecutor.Abstractions;
using MikhailKhalizev.Processor.x86.Utils;
using Newtonsoft.Json;

namespace MikhailKhalizev.Processor.x86
{
    [JsonConverter(typeof(AddressJsonConverter))]
    [TypeConverter(typeof(AddressTypeConverter))]
    public struct Address : IEquatable<Address>, IComparable<Address>, IComparable
    {
        public struct Comparer : IComparer<Address>
        {
            public int Compare(Address x, Address y)
            {
                return x.Native.CompareTo(y.Native);
            }
        }


        public static Address MinValue { get; } = uint.MinValue;
        public static Address MaxValue { get; } = uint.MaxValue;
        public static Address Parse(string str) => HexHelper.ToUInt32(str);
        
        public uint Native { get; }

        public Address(uint address)
        {
            Native = address;
        }


        public override string ToString() => ToShortString();
        public string ToString(Func<HexHelper.Options, HexHelper.Options> setupOptions) => HexHelper.ToString(Native, setupOptions);
        public string ToShortString() => HexHelper.ToShortGrouped4Hex(Native);
        public string ToFullString() => HexHelper.ToString(Native, o => o.SetTrimZero(false).SetGroupSize(4));

        #region IEquatable

        /// <summary>Показывает, равен ли этот экземпляр заданному объекту.</summary>
        /// <returns>Значение true, если <paramref name="obj" /> и данный экземпляр относятся к одному типу и представляют одинаковые значения; в противном случае — значение false. </returns>
        /// <param name="obj">Объект для сравнения с текущим экземпляром. </param>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            return obj is Address address && Equals(address);
        }

        public bool Equals(Address other) => Native == other.Native;

        /// <summary>Returns a value that indicates whether the values of two <see cref="T:MikhailKhalizev.Processor.x86.Address" /> objects are equal.</summary>
        /// <param name="left">The first value to compare.</param>
        /// <param name="right">The second value to compare.</param>
        /// <returns>true if the <paramref name="left" /> and <paramref name="right" /> parameters have the same value; otherwise, false.</returns>
        public static bool operator ==(Address left, Address right) => left.Equals(right);

        /// <summary>Returns a value that indicates whether two <see cref="T:MikhailKhalizev.Processor.x86.Address" /> objects have different values.</summary>
        /// <param name="left">The first value to compare.</param>
        /// <param name="right">The second value to compare.</param>
        /// <returns>true if <paramref name="left" /> and <paramref name="right" /> are not equal; otherwise, false.</returns>
        public static bool operator !=(Address left, Address right) => !left.Equals(right);

        public override int GetHashCode() => (int)Native;

        #endregion

        #region IComparable

        /// <summary>Сравнивает текущий экземпляр с другим объектом того же типа и возвращает целое число, которое показывает, расположен ли текущий экземпляр перед, после или на той же позиции в порядке сортировки, что и другой объект.</summary>
        /// <returns>Значение, указывающее, каков относительный порядок сравниваемых объектов.Возвращаемые значения представляют следующие результаты сравнения.Значение Значение Меньше нуля Данный экземпляр предшествует параметру <paramref name="obj" /> в порядке сортировки. Zero Данный экземпляр занимает ту же позицию в порядке сортировки, что и параметр <paramref name="obj" />. Больше нуля. Данный экземпляр следует за параметром <paramref name="obj" /> в порядке сортировки. </returns>
        /// <param name="obj">Объект для сравнения с данным экземпляром. </param>
        /// <exception cref="T:System.ArgumentException">Тип значения параметра <paramref name="obj" /> отличается от типа данного экземпляра. </exception>
        public int CompareTo(object obj)
        {
            if (obj is null) return 1;
            if (!(obj is Address)) throw new ArgumentException($"Object must be of type {nameof(Address)}");
            return CompareTo((Address)obj);
        }

        public int CompareTo(Address other)
        {
            var copy = Native; // Prevent "Impure method is called for readonly field".
            return copy.CompareTo(other.Native);
        }

        /// <summary>Returns a value that indicates whether a <see cref="T:MikhailKhalizev.Processor.x86.Address" /> value is less than another <see cref="T:MikhailKhalizev.Processor.x86.Address" /> value.</summary>
        /// <param name="left">The first value to compare.</param>
        /// <param name="right">The second value to compare.</param>
        /// <returns>true if <paramref name="left" /> is less than <paramref name="right" />; otherwise, false.</returns>
        public static bool operator <(Address left, Address right) => left.CompareTo(right) < 0;

        /// <summary>Returns a value that indicates whether a <see cref="T:MikhailKhalizev.Processor.x86.Address" /> value is greater than another <see cref="T:MikhailKhalizev.Processor.x86.Address" /> value.</summary>
        /// <param name="left">The first value to compare.</param>
        /// <param name="right">The second value to compare.</param>
        /// <returns>true if <paramref name="left" /> is greater than <paramref name="right" />; otherwise, false.</returns>
        public static bool operator >(Address left, Address right) => left.CompareTo(right) > 0;

        /// <summary>Returns a value that indicates whether a <see cref="T:MikhailKhalizev.Processor.x86.Address" /> value is less than or equal to another <see cref="T:MikhailKhalizev.Processor.x86.Address" /> value.</summary>
        /// <param name="left">The first value to compare.</param>
        /// <param name="right">The second value to compare.</param>
        /// <returns>true if <paramref name="left" /> is less than or equal to <paramref name="right" />; otherwise, false.</returns>
        public static bool operator <=(Address left, Address right) => left.CompareTo(right) <= 0;

        /// <summary>Returns a value that indicates whether a <see cref="T:MikhailKhalizev.Processor.x86.Address" /> value is greater than or equal to another <see cref="T:MikhailKhalizev.Processor.x86.Address" /> value.</summary>
        /// <param name="left">The first value to compare.</param>
        /// <param name="right">The second value to compare.</param>
        /// <returns>true if <paramref name="left" /> is greater than <paramref name="right" />; otherwise, false.</returns>
        public static bool operator >=(Address left, Address right) => left.CompareTo(right) >= 0;

        #endregion

        #region Cast from/to Value Operators

        public static implicit operator Value(Address address) => address.Native;

        public static implicit operator Address(ValueBase v) => v.UInt64;

        #endregion

        #region Cast from/to Numeric Operators

        public static implicit operator uint(Address address) => address.Native;
        public static explicit operator int(Address address) => (int)address.Native;

        public static implicit operator Address(byte address) => new Address(address);
        public static implicit operator Address(ushort address) => new Address(address);
        public static implicit operator Address(uint address) => new Address(address);
        public static implicit operator Address(ulong address)
        {
            if (uint.MaxValue < address)
                throw new InvalidCastException("uint.MaxValue < address");
            return new Address((uint)address);
        }

        public static implicit operator Address(sbyte address) => (uint)address;
        public static implicit operator Address(short address) => (uint)address;
        public static implicit operator Address(int address) => (uint)address;
        public static implicit operator Address(long address)
        {
            if (uint.MaxValue < address)
                throw new InvalidCastException("uint.MaxValue < address");

            if (address < int.MinValue)
                throw new InvalidCastException("address < int.MinValue");

            return (uint)address; // Именно uint. Например чтобы для смещения -20 преобразование в Address увенчалось успешно.
        }

        #endregion

        #region Arithmetic Operators

        public static int operator -(Address a1, Address a2) => (int)a1 - (int)a2;
        public static Address operator +(Address a1, int offset) => (int)a1 + offset;
        public static Address operator -(Address a1, int offset) => (int)a1 - offset;

        #endregion
    }
}
