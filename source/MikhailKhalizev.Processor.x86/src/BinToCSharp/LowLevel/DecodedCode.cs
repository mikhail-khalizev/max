using MikhailKhalizev.Processor.x86.Utils;

namespace MikhailKhalizev.Processor.x86.BinToCSharp.LowLevel
{
    public class DecodedCode
    {
        // NOTE. Инструкции могут пересекаться.
        private readonly MySortedSet<(Address Address, ICSharpInstruction Instruction)> _instructions
            = new MySortedSet<(Address Address, ICSharpInstruction Instruction)>(
                new CustomComparer<(Address Address, ICSharpInstruction Instruction)>(
                    (a, b) => a.Address.CompareTo(b.Address)));

        public UsedSpace<Address> Area { get; } = new UsedSpace<Address>();

        public void Clear()
        {
            _instructions.Clear();
            Area.Clear();
        }

        public ICSharpInstruction GetInstructionOrNull(Address address)
        {
            _instructions.TryGetValue((address, null), out var actual);
            return actual.Instruction;
        }

        public ICSharpInstruction GetInstructionBefore(Address address)
        {
            return _instructions.FirstLessOrDefault((address, null)).Instruction;
        }

        /// <summary>
        /// Возвращает инструкцию, следующую за заданной.
        /// </summary>
        /// <param name="instruction">Инструкция, для которой необходимо определить следующую инструкцию.</param>
        /// <returns></returns>
        public ICSharpInstruction GetNextInstruction(ICSharpInstruction instruction)
        {
            return _instructions.FirstNotLessOrDefault((instruction.End, null)).Instruction;
        }

        public bool ContainsInstruction(Address address)
        {
            return _instructions.Contains((address, null));
        }

        public void Insert(ICSharpInstruction instruction)
        {
            _instructions.Add((instruction.Begin, instruction));
            Area.Add(instruction.Begin, instruction.End);
        }
    }
}