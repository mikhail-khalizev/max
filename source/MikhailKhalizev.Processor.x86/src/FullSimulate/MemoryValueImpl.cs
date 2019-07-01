using System;
using JetBrains.Annotations;
using MikhailKhalizev.Processor.x86.Abstractions;
using MikhailKhalizev.Processor.x86.Abstractions.Memory;
using MikhailKhalizev.Processor.x86.Abstractions.Registers;

namespace MikhailKhalizev.Processor.x86.FullSimulate
{
    public class MemoryValueImpl : MemoryValue
    {
        public MemoryAccessImpl MemoryAccess { get; }
        public SegmentRegister Segment { get; }
        public Address Address { get; }

        /// <inheritdoc />
        public override int Bits => MemoryAccess.DataBits;

        public ArraySegment<byte> MemorySpace =>
            _memorySpace ?? (_memorySpace = Segment == null
                ? MemoryAccess.Memory.mem_pg_raw(Address, Bits)
                : MemoryAccess.Memory.mem_seg_pg_raw(Segment, Address, Bits)).Value;
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

        /// <inheritdoc />
        public override Address EffectiveAddress
        {
            get
            {
                var address = (Segment?.Descriptor.Base ?? 0) + Address;
                return MemoryAccess.Memory.mem_pg_raw_get_phys_addr(address);
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