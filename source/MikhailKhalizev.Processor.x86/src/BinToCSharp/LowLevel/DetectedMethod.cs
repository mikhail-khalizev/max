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
        public List<IInstruction> Instructions { get; set; } = new List<IInstruction>();
        public byte[] RawBytes { get; set; }
        public MethodInfoDto MethodInfo { get; set; }


        public DetectedMethod(Address begin)
        {
            Begin = begin;
        }

        public IInstruction InstructionOf(Address address)
        {
            var index = Instructions.BinarySearch(new AddressSearchInstruction(address), IInstruction.BeginComparer);
            return index < 0 ? null : Instructions[index];
        }

        public int InstructionIndexOf(Address address)
        {
            return Instructions.BinarySearch(new AddressSearchInstruction(address), IInstruction.BeginComparer);
        }

        public int InstructionIndexOf(IInstruction instruction)
        {
            return Instructions.BinarySearch(instruction, IInstruction.BeginComparer);
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
