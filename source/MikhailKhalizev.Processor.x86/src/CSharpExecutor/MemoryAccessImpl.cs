using MikhailKhalizev.Processor.x86.CSharpExecutor.Abstractions.Memory;
using MikhailKhalizev.Processor.x86.CSharpExecutor.Abstractions.Registers;
using MikhailKhalizev.Processor.x86.Utils;

namespace MikhailKhalizev.Processor.x86.CSharpExecutor
{
    public class MemoryAccessImpl : MemoryAccess
    {
        public Memory Memory { get; }
        public int DataBits { get; }
        public int AddressBits { get; }
        public ulong AddressMask { get; }

        public MemoryAccessImpl(Memory memory, int dataBits, int addressBits)
        {
            Memory = memory;
            DataBits = dataBits;
            AddressBits = addressBits;
            AddressMask = BinaryHelper.MaskUInt64(AddressBits);
        }

        /// <inheritdoc />
        public override MemoryValue this[Address address]
        {
            get => new MemoryValueImpl(this, null, address);
            set => new MemoryValueImpl(this, null, address).UInt64 = value.UInt64;
        }

        /// <inheritdoc />
        public override MemoryValue this[SegmentRegister segment, Address address]
        {
            get => new MemoryValueImpl(this, segment, address);
            set => new MemoryValueImpl(this, segment, address).UInt64 = value.UInt64;
        }
    }
}