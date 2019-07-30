using System;
using JetBrains.Annotations;
using MikhailKhalizev.Processor.x86.Abstractions;
using MikhailKhalizev.Processor.x86.Abstractions.Memory;
using MikhailKhalizev.Processor.x86.Abstractions.Registers;

namespace MikhailKhalizev.Processor.x86.Core
{
    public class MemoryValueImpl : MemoryValue
    {
        public MemoryAccessImpl MemoryAccess { get; }
        public override SegmentRegister Segment { get; }
        public override Address Address { get; }

        /// <inheritdoc />
        public override int Bits => MemoryAccess.DataBits;

        public ArraySegment<byte> MemorySpace =>
            _memorySpace ?? (_memorySpace = Segment == null
                ? MemoryAccess.Memory.GetMinSize(Address, Bits / 8)
                : MemoryAccess.Memory.GetMinSize(Segment, Address, Bits / 8)).Value;
        private ArraySegment<byte>? _memorySpace;

        /// <inheritdoc />
        protected override ulong UInt64Internal
        {
            get
            {
                var bytes = new byte[8];
                MemorySpace.Slice(0, Bits / 8).CopyTo(bytes);
                return BitConverter.ToUInt64(bytes);
            }
            set
            {
                var bytes = BitConverter.GetBytes(value);
                bytes.AsSpan().Slice(0, Bits / 8).CopyTo(MemorySpace);
            }
        }

        public MemoryValueImpl(MemoryAccessImpl memoryAccess, [CanBeNull] SegmentRegister segment, Address address)
        {
            MemoryAccess = memoryAccess;
            Segment = segment;
            Address = address & MemoryAccess.AddressMask;
        }
    }
}