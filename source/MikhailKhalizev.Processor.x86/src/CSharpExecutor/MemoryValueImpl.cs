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
        public override int LengthInBits => MemoryAccess.DataBits;

        public Span<byte> Span =>
            Segment == null
                ? MemoryAccess.Memory.GetMinSize(Address, LengthInBits / 8)
                : MemoryAccess.Memory.GetMinSize(Segment, Address, LengthInBits / 8);

        /// <inheritdoc />
        protected override ulong UInt64Internal
        {
            get
            {
                switch (LengthInBits)
                {
                    case 8:
                        return Span[0];
                    case 16:
                        return Span.Ref<ushort>();
                    case 32:
                        return Span.Ref<uint>();
                    case 64:
                        return Span.Ref<ulong>();
                    default:
                        throw new NotImplementedException($"LengthInBits: {LengthInBits}");
                }
            }
            set
            {
                switch (LengthInBits)
                {
                    case 8:
                        Span[0] = (byte)value;
                        break;
                    case 16:
                        Span.Ref<ushort>() = (ushort)value;
                        break;
                    case 32:
                        Span.Ref<uint>() = (uint)value;
                        break;
                    case 64:
                        Span.Ref<ulong>() = (ulong)value;
                        break;
                    default:
                        throw new NotImplementedException($"LengthInBits: {LengthInBits}");
                }
            }
        }

        /// <inheritdoc />
        public override long Int64
        {
            get
            {
                switch (LengthInBits)
                {
                    case 8:
                        return (sbyte)Span[0];
                    case 16:
                        return Span.Ref<short>();
                    case 32:
                        return Span.Ref<int>();
                    case 64:
                        return Span.Ref<long>();
                    default:
                        throw new NotImplementedException($"LengthInBits: {LengthInBits}");
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