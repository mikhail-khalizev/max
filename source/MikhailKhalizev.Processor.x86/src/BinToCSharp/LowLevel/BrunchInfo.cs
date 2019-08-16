using System.Collections.Generic;
using MikhailKhalizev.Processor.x86.Core.Abstractions;
using MikhailKhalizev.Processor.x86.Utils;

namespace MikhailKhalizev.Processor.x86.BinToCSharp
{
    public class BrunchInfo
    {
        public Address From { get; set; }
        public SortedSet<Address> To { get; set; }

        public BrunchInfo(Address from)
        {
            From = from;
        }

        public static IComparer<BrunchInfo> BeginComparer =>
            new CustomComparer<BrunchInfo>(
                (x, y) => x.From.CompareTo(y.From));
    }
}