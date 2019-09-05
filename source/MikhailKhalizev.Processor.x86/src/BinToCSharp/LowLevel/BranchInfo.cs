using System.Collections.Generic;
using MikhailKhalizev.Processor.x86.Utils;

namespace MikhailKhalizev.Processor.x86.BinToCSharp.LowLevel
{
    public class BranchInfo
    {
        public Address From { get; set; }
        public MySortedSet<Address> To { get; set; }

        public BranchInfo(Address from)
        {
            From = from;
        }

        public static IComparer<BranchInfo> BeginComparer =>
            new CustomComparer<BranchInfo>(
                (x, y) => x.From.CompareTo(y.From));
    }
}