using System;
using System.Collections.Generic;
using MikhailKhalizev.Processor.x86.Utils;

namespace MikhailKhalizev.Processor.x86.BinToCSharp.LowLevel
{
    public interface IInstruction
    {
        public static IEqualityComparer<IInstruction> BeginEqualityComparer =>
            new CustomEqualityComparer<IInstruction>(
                (x, y) => x.Begin == y.Begin,
                x => x.Begin.GetHashCode());

        public static IComparer<IInstruction> BeginComparer =>
            new CustomComparer<IInstruction>(
                (x, y) => x.Begin.CompareTo(y.Begin));


        public Address Begin { get; }
        public Address End { get; }
        public int Length => End - Begin;

        public InstructionMetadata Metadata { get; }

        public IEnumerable<string> GetLowLevelCode();
        // public IEnumerable<string> GetHighLevelCode();
    }
}