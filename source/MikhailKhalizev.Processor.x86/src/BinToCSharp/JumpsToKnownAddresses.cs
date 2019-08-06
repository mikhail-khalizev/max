using System.Collections.Generic;
using MikhailKhalizev.Processor.x86.Core.Abstractions;
using MikhailKhalizev.Processor.x86.Utils;

namespace MikhailKhalizev.Processor.x86.BinToCSharp
{
    public class JumpsToKnownAddresses
    {
        public Address From { get; set; }
        public SortedSet<Address> To { get; set; }

        public JumpsToKnownAddresses(Address from)
        {
            From = from;
        }

        public static IComparer<JumpsToKnownAddresses> BeginComparer =>
            new CustomComparer<JumpsToKnownAddresses>(
                (x, y) => x.From.CompareTo(y.From));
    }
}