using System.Collections.Generic;
using System.Linq;
using MikhailKhalizev.Processor.x86.Abstractions;
using MikhailKhalizev.Processor.x86.Utils;

namespace MikhailKhalizev.Processor.x86.BinToCSharp
{
    public class DecodedCode
    {
        // NOTE. Инструкции могут пересекаться.
        private readonly Dictionary<Address, Instruction> _instructions = new Dictionary<Address, Instruction>();
        public UsedSpace<Address> Area { get; } = new UsedSpace<Address>();

        public Instruction GetInstruction(Address address)
        {
            _instructions.TryGetValue(address, out var actual);
            return actual;
        }

        /// <summary>
        /// Возвращает инструкцию, следующую за заданной.
        /// </summary>
        /// <param name="instruction">Инструкция, для которой необходимо определить следующую инструкцию.</param>
        /// <returns></returns>
        public Instruction GetNextInstruction(Instruction instruction)
        {
            return GetInstruction(instruction.End);
        }

        public bool Contains(Address address)
        {
            return _instructions.ContainsKey(address);
        }

        public void Insert(Instruction instruction)
        {
            _instructions[instruction.Begin] = instruction;
            Area.Add(instruction.Begin, instruction.End);
        }
    }
}