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
        private static List<(Interval<Address, Address.Comparer> Interval, string Namespace)> NamespaceByAddress { get; } = new List<(Interval<Address, Address.Comparer>, string)>();

        public static void AddNamespace(Interval<Address, Address.Comparer> interval, string @namespace)
        {
            var item = NamespaceByAddress.FirstOrDefault(x => x.Interval.Contains(interval));

            if (!item.Interval.IsEmpty)
            {
                if (item.Interval == interval && item.Namespace == @namespace)
                    return;
                // throw new InvalidOperationException($"Already have internal {item.Interval} with namespace '{item.Namespace}'.");
            }

            NamespaceByAddress.Add((interval, @namespace));
        }

        [CanBeNull]
        public static string GetNamespace(Address address, string separator = "_")
        {
            return string.Join(separator, NamespaceByAddress.Where(x => x.Interval.Contains(address)).Select(x => x.Namespace).Distinct());
        }

        [CanBeNull]
        public static List<string> GetNamespaces(Address address)
        {
            return NamespaceByAddress.Where(x => x.Interval.Contains(address)).Select(x => x.Namespace).Distinct().ToList();
        }
    }
}