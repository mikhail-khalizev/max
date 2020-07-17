using System.Collections.Generic;
using System.Diagnostics;
using MikhailKhalizev.Processor.x86.BinToCSharp.MethodInfo;
using MikhailKhalizev.Processor.x86.Utils;

namespace MikhailKhalizev.Processor.x86.BinToCSharp.LowLevel
{
    [DebuggerDisplay("Begin = {Begin}, End = {End}, Id = {MethodInfo?.Id}")]
    public class DetectedMethod
    {
        public Address Begin { get; }
        public Address End { get; set; } // 0 if unknown
        public List<ICSharpInstruction> Instructions { get; set; } = new List<ICSharpInstruction>();
        public byte[] RawBytes { get; set; }
        public MethodInfoDto MethodInfo { get; set; }


        public DetectedMethod(Address begin)
        {
            Begin = begin;
        }

        public ICSharpInstruction InstructionOf(Address address)
        {
            var index = Instructions.BinarySearch(new AddressSearchCSharpInstruction(address), ICSharpInstruction.BeginComparer);
            return index < 0 ? null : Instructions[index];
        }

        public int InstructionIndexOf(Address address)
        {
            return Instructions.BinarySearch(new AddressSearchCSharpInstruction(address), ICSharpInstruction.BeginComparer);
        }

        public int InstructionIndexOf(ICSharpInstruction instruction)
        {
            return Instructions.BinarySearch(instruction, ICSharpInstruction.BeginComparer);
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
