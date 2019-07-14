using System.Collections.Generic;
using MikhailKhalizev.Processor.x86.Abstractions;
using MikhailKhalizev.Processor.x86.Utils;
using MikhailKhalizev.Utils;

namespace MikhailKhalizev.Processor.x86.BinToCSharp
{
    public class DetectedMethod
    {
        public Address Begin { get; }
        public Address End { get; set; } // 0 if unknown
        public HashSet<Address> Labels { get; set; } = new HashSet<Address>();
        public List<Instruction> Instructions { get; set; } = new List<Instruction>();
        public byte[] RawBytes { get; set; }
        
        //        addr_type count_call_to_this;
        //        std::string[] reason_to_add; // @todo Условие добавления (для отладки).

        public DetectedMethod(Address begin)
        {
            Begin = begin;
        }
        
        public static IEqualityComparer<DetectedMethod> BeginEqualityComparer =>
            new CustomEqualityComparer<DetectedMethod>(
                (x, y) => x.Begin == y.Begin,
                x => x.Begin.GetHashCode());

        public static IComparer<DetectedMethod> BeginComparer =>
            new CustomComparer<DetectedMethod>(
                (x, y) => x.Begin.CompareTo(y.Begin));
    }
}
