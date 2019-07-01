using System.Collections.Generic;
using System.Linq;
using JetBrains.Annotations;
using MikhailKhalizev.Processor.x86.Abstractions;
using MikhailKhalizev.Utils;

namespace MikhailKhalizev.Processor.x86.Utils
{
    public static class AddressNameConverter
    {
        public static BiDictionary<Address, string> KnownDefinitions { get; } = new BiDictionary<Address, string>();

        /// <summary>
        /// Пространство имён по умолчанию, используемое у функций с заданным диапазонов адресов.
        /// </summary>
        public static List<(Interval<Address> Interval, string NameSpace)> DefaultNamespaceByAddress { get; } = new List<(Interval<Address>, string)>();
        
        [CanBeNull]
        public static string GetNamespace(Address address)
            => DefaultNamespaceByAddress.FirstOrDefault(x => x.Interval.Contains(address)).NameSpace;

        public static Address GetAddress(string nameOrAddress)
        {
            var address = KnownDefinitions.GetKeyOrDefault(nameOrAddress);
            if (address != default(Address))
                return address;

            return Address.Parse(nameOrAddress);
        }

        /// <summary>
        /// Преобразует адрес учитывая пространства имён и известные определения.
        /// </summary>
        /// <param name="address">Адрес, который необходимо записать.</param>
        /// <param name="padding">true, если необходимо добавить лидирующие нули ... выровнены по правому краю путем добавления слева нулей до указанной общей длины.</param>
        /// <param name="withNamespace">true, если необходимо добавить перед адресом комментарий с пространством имён; иначе - false.</param>
        public static string GetResultName(Address address, bool padding, bool withNamespace)
        {
            if (KnownDefinitions.TryGetValue(address, out var str))
                return str;

            str = "";
            if (withNamespace)
            {
                var n = GetNamespace(address);
                if (n != null)
                    str += $"/* {n} */ ";
            }

            if (padding)
                return $"{str}{address.ToFullString()}";
            else
                return $"{str}{address.ToShortString()}";
        }
    }
}