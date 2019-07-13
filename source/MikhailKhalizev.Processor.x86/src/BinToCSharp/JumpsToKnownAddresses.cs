using System.Collections.Generic;
using MikhailKhalizev.Processor.x86.Abstractions;
using MikhailKhalizev.Processor.x86.Utils;

namespace MikhailKhalizev.Processor.x86.BinToCSharp
{
    public class JumpsToKnownAddresses
    {
        public Address From { get; private set; }
        public SortedSet<Address> To { get; private set; }

        private JumpsToKnownAddresses()
        { }

        public static JumpsToKnownAddresses CreateDummy(Address from)
        {
            var obj = new JumpsToKnownAddresses();
            obj.From = from;
            return obj;
        }

        public static IComparer<JumpsToKnownAddresses> BeginComparer =>
            new CustomComparer<JumpsToKnownAddresses>(
                (x, y) => x.From.CompareTo(y.From));
    }
}