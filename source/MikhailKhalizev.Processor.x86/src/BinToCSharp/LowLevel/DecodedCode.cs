using MikhailKhalizev.Processor.x86.Utils;

namespace MikhailKhalizev.Processor.x86.BinToCSharp.LowLevel
{
    public class DecodedCode
    {
        // NOTE. Инструкции могут пересекаться.
        private readonly MySortedSet<IInstruction> _instructions
            = new MySortedSet<IInstruction>(IInstruction.BeginComparer);

        public IntervalCollection<Address> Area { get; } = new IntervalCollection<Address>();

        public void Clear()
        {
            _instructions.Clear();
            Area.Clear();
        }

        public IInstruction GetInstructionOrNull(Address beginInstructionAddress)
        {
            _instructions.TryGetValue(new AddressSearchInstruction(beginInstructionAddress), out var actual);
            return actual;
        }

        public IInstruction GetInstructionBefore(Address beginInstructionAddress)
        {
            return _instructions.FirstLessOrDefault(new AddressSearchInstruction(beginInstructionAddress));
        }

        /// <summary>
        /// Возвращает инструкцию, следующую за заданной.
        /// </summary>
        /// <param name="instruction">Инструкция, для которой необходимо определить следующую инструкцию.</param>
        /// <returns></returns>
        public IInstruction GetNextInstruction(IInstruction instruction)
        {
            return _instructions.FirstNotLessOrDefault(new AddressSearchInstruction(instruction.End));
        }

        public bool ContainsInstruction(Address address)
        {
            return _instructions.Contains(new AddressSearchInstruction(address));
        }

        public void Insert(IInstruction instruction)
        {
            _instructions.Add(instruction);
            Area.Add(instruction.Begin, instruction.End);
        }
    }
}