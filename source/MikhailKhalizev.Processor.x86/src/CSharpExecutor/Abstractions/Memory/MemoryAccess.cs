using MikhailKhalizev.Processor.x86.CSharpExecutor.Abstractions.Registers;

namespace MikhailKhalizev.Processor.x86.CSharpExecutor.Abstractions.Memory
{
    public abstract class MemoryAccess
    {
        /// <summary>
        /// no seg, yes pg
        /// </summary>
        public abstract MemoryValue this[Address address] { get; set; }

        /// <summary>
        /// yes seg, yes pg
        /// </summary>
        public abstract MemoryValue this[SegmentRegister segment, Address address] { get; set; }
    }
}
