using MikhailKhalizev.Processor.x86.Utils;

namespace MikhailKhalizev.Processor.x86.BinToCSharp.LowLevel
{
    public class DecodedCode
    {
        // NOTE. Инструкции могут пересекаться.
        private readonly MySortedSet<(Address Address, IInstruction Instruction)> _instructions
            = new MySortedSet<(Address Address, IInstruction Instruction)>(
                new CustomComparer<(Address Address, IInstruction Instruction)>(
                    (a, b) => a.Address.CompareTo(b.Address)));

        public UsedSpace<Address> Area { get; } = new UsedSpace<Address>();

        public void Clear()
        {
            _instructions.Clear();
            Area.Clear();
        }

        public IInstruction GetInstructionOrNull(Address address)
        {
            _instructions.TryGetValue((address, null), out var actual);
            return actual.Instruction;
        }

        public IInstruction GetInstructionBefore(Address address)
        {
            return _instructions.FirstLessOrDefault((address, null)).Instruction;
        }

        /// <summary>
        /// Возвращает инструкцию, следующую за заданной.
        /// </summary>
        /// <param name="instruction">Инструкция, для которой необходимо определить следующую инструкцию.</param>
        /// <returns></returns>
        public IInstruction GetNextInstruction(IInstruction instruction)
        {
            return _instructions.FirstNotLessOrDefault((instruction.End, null)).Instruction;
        }

        public bool ContainsInstruction(Address address)
        {
            return _instructions.Contains((address, null));
        }

        public void Insert(IInstruction instruction)
        {
            _instructions.Add((instruction.Begin, instruction));
            Area.Add(instruction.Begin, instruction.End);
        }
    }
}