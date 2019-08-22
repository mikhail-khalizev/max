using System;
using JetBrains.Annotations;
using MikhailKhalizev.Processor.x86.CSharpExecutor.Abstractions.Memory;
using MikhailKhalizev.Processor.x86.CSharpExecutor.Abstractions.Registers;

namespace MikhailKhalizev.Processor.x86.CSharpExecutor
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
                switch (Bits)
                {
                    case 8:
                        return MemorySpace[0];
                    case 16:
                        return BitConverter.ToUInt16(MemorySpace.AsSpan(0, 2));
                    case 32:
                        return BitConverter.ToUInt32(MemorySpace.AsSpan(0, 4));
                    case 64:
                        return BitConverter.ToUInt64(MemorySpace.AsSpan(0, 8));
                    default:
                        throw new NotImplementedException($"Bits: {Bits}");
                }
            }
            set
            {
                var ms = MemorySpace;
                switch (Bits)
                {
                    case 8:
                        ms[0] = (byte)value;
                        break;
                    case 16:
                        BitConverter.TryWriteBytes(ms.AsSpan(0, 2), (ushort)value);
                        break;
                    case 32:
                        BitConverter.TryWriteBytes(ms.AsSpan(0, 4), (uint)value);
                        break;
                    case 64:
                        BitConverter.TryWriteBytes(ms.AsSpan(0, 8), value);
                        break;
                    default:
                        throw new NotImplementedException($"Bits: {Bits}");
                }
            }
        }

        /// <inheritdoc />
        public override long Int64
        {
            get
            {
                switch (Bits)
                {
                    case 8:
                        return (sbyte)MemorySpace[0];
                    case 16:
                        return BitConverter.ToInt16(MemorySpace.AsSpan(0, 2));
                    case 32:
                        return BitConverter.ToInt32(MemorySpace.AsSpan(0, 4));
                    case 64:
                        return BitConverter.ToInt64(MemorySpace.AsSpan(0, 8));
                    default:
                        throw new NotImplementedException($"Bits: {Bits}");
                }
            }
            set => UInt64Internal = (ulong)value;
        }

        /// <inheritdoc />
        public override ulong UInt64
        {
            get => UInt64Internal;
            set => UInt64Internal = value;
        }

        public MemoryValueImpl(MemoryAccessImpl memoryAccess, [CanBeNull] SegmentRegister segment, Address address)
        {
            MemoryAccess = memoryAccess;
            Segment = segment;
            Address = address & MemoryAccess.AddressMask;
        }
    }
}