using System;
using System.Collections.Generic;
using System.Linq;
using JetBrains.Annotations;
using MikhailKhalizev.Processor.x86.Utils;

namespace MikhailKhalizev.Processor.x86.Core.Abstractions
{
    public static class AddressNameConverter
    {
        public static BiDictionary<Address, string> KnownDefinitions { get; } = new BiDictionary<Address, string>();

        /// <summary>
        /// Пространство имён по умолчанию, используемое у функций с заданным диапазонов адресов.
        /// </summary>
        private static List<(Interval<Address> Interval, string Namespace)> NamespaceByAddress { get; } = new List<(Interval<Address>, string)>();

        public static void AddNamespace(Interval<Address> interval, string @namespace)
        {
            var item = NamespaceByAddress.FirstOrDefault(x => x.Interval.Contains(interval));

            if (!item.Interval.IsEmpty)
                throw new InvalidOperationException($"Already have internal {item.Interval} with namespace '{item.Namespace}'.");

            NamespaceByAddress.Add((interval, @namespace));
        }

        [CanBeNull]
        public static string GetNamespace(Address address)
        {
            return NamespaceByAddress.FirstOrDefault(x => x.Interval.Contains(address)).Namespace;
        }

        public static Address GetAddress(string nameOrAddress)
        {
            var address = KnownDefinitions.GetKeyOrDefault(nameOrAddress);
            if (address != default)
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
                return "Definitions." + str;

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