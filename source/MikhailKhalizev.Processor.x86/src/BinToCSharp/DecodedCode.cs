using System.Collections.Generic;
using System.Linq;
using MikhailKhalizev.Processor.x86.Abstractions;
using MikhailKhalizev.Processor.x86.Utils;

namespace MikhailKhalizev.Processor.x86.BinToCSharp
{
    public class DecodedCode
    {
        // NOTE. Инструкции могут пересекаться.
        private readonly MySortedSet<(Address Address, Instruction Instruction)> _instructions 
            = new MySortedSet<(Address Address, Instruction Instruction)>(new CustomComparer<(Address Address, Instruction Instruction)>((a, b) => a.Address.CompareTo(b.Address)));
        public UsedSpace<Address> Area { get; } = new UsedSpace<Address>();

        public Instruction GetInstruction(Address address)
        {
            _instructions.TryGetValue((address, null), out var actual);
            return actual.Instruction;
        }

        /// <summary>
        /// Возвращает инструкцию, следующую за заданной.
        /// </summary>
        /// <param name="instruction">Инструкция, для которой необходимо определить следующую инструкцию.</param>
        /// <returns></returns>
        public Instruction GetNextInstruction(Instruction instruction)
        {
            return _instructions.FirstNotLessOrDefault((instruction.End, null)).Instruction;
        }

        public bool Contains(Address address)
        {
            return _instructions.Contains((address, null));
        }

        public void Insert(Instruction instruction)
        {
            _instructions.Add((instruction.Begin, instruction));
            Area.Add(instruction.Begin, instruction.End);
        }
    }
}