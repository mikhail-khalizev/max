using System;
using System.Collections.Generic;
using System.Linq;
using JetBrains.Annotations;
using MikhailKhalizev.Processor.x86.Utils;

namespace MikhailKhalizev.Processor.x86.BinToCSharp
{
    public static class AddressNameConverter
    {
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
    }
}