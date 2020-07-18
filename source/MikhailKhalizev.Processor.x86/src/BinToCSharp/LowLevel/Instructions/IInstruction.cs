using System.Collections.Generic;
using MikhailKhalizev.Processor.x86.Utils;

namespace MikhailKhalizev.Processor.x86.BinToCSharp.LowLevel
{
    public class InstructionMetadata
    {
        public bool HasLabel { get; set; }
        public bool? IsLocalBranch { get; set; }
    }

    public interface IInstruction
    {
        public static IEqualityComparer<IInstruction> BeginEqualityComparer =>
            new CustomEqualityComparer<IInstruction>(
                (x, y) => x.Begin == y.Begin,
                x => x.Begin.GetHashCode());

        public static IComparer<IInstruction> BeginComparer =>
            new CustomComparer<IInstruction>(
                (x, y) => x.Begin.CompareTo(y.Begin));


        Address Begin { get; }
        Address End { get; }

        InstructionMetadata Metadata { get; }

        bool IsJmpOrJcc { get; }
        bool IsRet { get; }
        bool IsJmp { get; }
        bool IsJmpOrRet => IsJmp || IsRet;

        IEnumerable<string> GetCode(bool isLastInstructionInMethod);
    }
}