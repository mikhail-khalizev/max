using System.Collections.Generic;
using System.Linq;
using MikhailKhalizev.Processor.x86.Core.Abstractions;
using MikhailKhalizev.Processor.x86.Utils;

namespace MikhailKhalizev.Processor.x86.BinToCSharp
{
    public class DecodedCode
    {
        // NOTE. Инструкции могут пересекаться.
        private readonly MySortedSet<(Address Address, CSharpInstruction Instruction)> _instructions 
            = new MySortedSet<(Address Address, CSharpInstruction Instruction)>(new CustomComparer<(Address Address, CSharpInstruction Instruction)>((a, b) => a.Address.CompareTo(b.Address)));
        public UsedSpace<Address> Area { get; } = new UsedSpace<Address>();

        public void Clear()
        {
            _instructions.Clear();
            Area.Clear();
        }

        public CSharpInstruction GetInstructionOrNull(Address address)
        {
            _instructions.TryGetValue((address, null), out var actual);
            return actual.Instruction;
        }

        public CSharpInstruction GetInstructionBefore(Address address)
        {
            return _instructions.FirstLessOrDefault((address, null)).Instruction;
        }

        /// <summary>
        /// Возвращает инструкцию, следующую за заданной.
        /// </summary>
        /// <param name="instruction">Инструкция, для которой необходимо определить следующую инструкцию.</param>
        /// <returns></returns>
        public CSharpInstruction GetNextInstruction(CSharpInstruction instruction)
        {
            return _instructions.FirstNotLessOrDefault((instruction.End, null)).Instruction;
        }

        public bool Contains(Address address)
        {
            return _instructions.Contains((address, null));
        }

        public void Insert(CSharpInstruction instruction)
        {
            _instructions.Add((instruction.Begin, instruction));
            Area.Add(instruction.Begin, instruction.End);
        }
    }
}