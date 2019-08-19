using System.Collections.Generic;
using System.Diagnostics;
using MikhailKhalizev.Processor.x86.BinToCSharp.MethodInfo;
using MikhailKhalizev.Processor.x86.Core.Abstractions;
using MikhailKhalizev.Processor.x86.Utils;

namespace MikhailKhalizev.Processor.x86.BinToCSharp
{
    [DebuggerDisplay("Begin = {Begin}, End = {End}, MethodInfo = {MethodInfo?.Id}")]
    public class DetectedMethod
    {
        public Address Begin { get; }
        public Address End { get; set; } // 0 if unknown
        public HashSet<Address> Labels { get; set; } = new HashSet<Address>();
        public List<CSharpInstruction> Instructions { get; set; } = new List<CSharpInstruction>();
        public byte[] RawBytes { get; set; }
        public MethodInfoDto MethodInfo { get; set; }


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
