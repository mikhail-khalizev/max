using System;
using MikhailKhalizev.Utils;

namespace MikhailKhalizev.Processor.x86.Abstractions.Registers
{
    public class SegmentDescriptor
    {
        public byte[] Bytes { get; set; }

        public SegmentDescriptor()
            : this(new byte[8])
        { }

        public SegmentDescriptor(byte[] bytes)
        {
            if (bytes.Length != 8)
                throw new ArgumentException("desc.Length != 8");
            Bytes = bytes;
        }

        
        #region Segment Descriptors

        /// <summary>
        /// Segment limit field.
        /// </summary>
        public uint Limit
        {
            get
            {
                uint limit = 0;

                BinaryHelper.Set(Bytes[0], ref limit, 0);
                BinaryHelper.Set(Bytes[1], ref limit, 8);
                BinaryHelper.Set(Bytes[6], ref limit, 16, 4);

                if (G)
                    limit = (limit << 12) | 0xfff;

                return limit;
            }
            set
            {
                var limit = value;
                if (G)
                    limit >>= 12;

                BinaryHelper.Set(ref Bytes[0], limit, 0);
                BinaryHelper.Set(ref Bytes[1], limit, 8);
                BinaryHelper.Set(ref Bytes[6], limit, 16, 4);
            }
        }

        /// <summary>
        /// Base address fields.
        /// </summary>
        public uint Base
        {
            get
            {
                uint value = 0;
                BinaryHelper.Set(Bytes[2], ref value, 0);
                BinaryHelper.Set(Bytes[3], ref value, 8);
                BinaryHelper.Set(Bytes[4], ref value, 16);
                BinaryHelper.Set(Bytes[7], ref value, 24);
                return value;
            }
            set
            {
                BinaryHelper.Set(ref Bytes[2], value, 0);
                BinaryHelper.Set(ref Bytes[3], value, 8);
                BinaryHelper.Set(ref Bytes[4], value, 16);
                BinaryHelper.Set(ref Bytes[7], value, 24);
            }
        }

        /// <summary>
        /// Type field.
        /// </summary>
        public uint Type
        {
            get => BinaryHelper.GetUInt(Bytes[5], 4);
            set => BinaryHelper.Set(ref Bytes[5], value, bits: 4);
        }

        /// <summary>
        /// S (descriptor type) flag.
        /// </summary>
        /// <remarks>
        /// Specifies whether the segment descriptor is for a system segment (S flag is clear)
        /// or a code or data segment(S flag is set).
        /// </remarks>
        public bool S => (Bytes[5] & 0x10u) != 0;

        public uint SAndType => Bytes[5] & 0x1fu;

        /// <summary>
        /// DPL (descriptor privilege level) field.
        /// </summary>
        /// <remarks>
        /// Specifies the privilege level of the segment.
        /// The privilege level can range from 0 to 3, with 0 being the most privileged level.
        /// 
        /// 0 = Highest privilege (OS),
        /// 3 = Lowest privilege (User applications).
        /// </remarks>
        public uint DPL
        {
            get => BinaryHelper.GetUInt(Bytes[5], 2, 5);
            set => BinaryHelper.Set(ref Bytes[5], value, 0, 2, 5);
        }

        /// <summary>
        /// P (segment-present) flag.
        /// </summary>
        /// <remarks>Indicates whether the segment is present in memory (set) or not present (clear).</remarks>
        public bool Present
        {
            get => BinaryHelper.IsSet(Bytes[5], 7);
            set => BinaryHelper.Set(ref Bytes[5], value, 7);
        }

        /// <summary>
        /// D/B (default operation size/default stack pointer size and/or upper bound) flag.
        /// </summary>
        /// <remarks>
        /// This flag should always be set to 1 for 32-bit code and data segments and to 0 for 16-bit code and data segments.
        /// </remarks>
        public bool db
        {
            get => BinaryHelper.IsSet(Bytes[6], 6);
            set => BinaryHelper.Set(ref Bytes[6], value, 6);
        }

        /// <summary>
        /// Granularity flag.
        /// </summary>
        /// <remarks>
        /// Determines the scaling of the segment limit field.
        /// </remarks>
        public bool G
        {
            get => BinaryHelper.IsSet(Bytes[6], 7);
            set => BinaryHelper.Set(ref Bytes[6], value, 7);
        }

        /// <summary>
        /// L (64-bit code segment) flag.
        /// </summary>
        public bool l
        {
            get => BinaryHelper.IsSet(Bytes[6], 5);
            set => BinaryHelper.Set(ref Bytes[6], value, 5);
        }

        #endregion

        #region Code- and Data-Segment Descriptor Types

        /// <summary>
        /// Is the descriptor is for either a code or a data segment.
        /// </summary>
        public bool IsTypeDataOrCode => S;

        public bool IsTypeData => (SAndType | 0b0111) == 0b1_0111;

        public bool IsTypeCode => (SAndType | 0b0111) == 0b1_1111;

        public bool IsTypeConformingCode => (SAndType | 0b0011) == 0b1_1111;

        public bool IsTypeNonConformingCode => (SAndType | 0b0011) == 0b1_1011;


        /// <summary>
        /// Accessed.
        /// </summary>
        public bool A => (Type & 0x1) != 0;

        /// <summary>
        /// Write-enable (for data segments).
        /// </summary>
        public bool W => (Type & 0x2) != 0;

        /// <summary>
        /// Read enable (for code segments).
        /// </summary>
        public bool R => W;

        /// <summary>
        /// Expansion-direction (for data segments).
        /// </summary>
        public bool E => (Type & 0x4) != 0;

        /// <summary>
        /// Conforming (for code segments).
        /// </summary>
        public bool C => E;

        #endregion

        #region System Descriptor Types

        // Page 1736. Table 3-2. System-Segment and Gate-Descriptor Types

        /// <summary>
        /// Is the descriptor type is a system descriptor.
        /// </summary>
        /// <remarks>
        /// • Local descriptor-table (LDT) segment descriptor.
        /// • Task-state segment (TSS) descriptor.
        /// • Call-gate descriptor.
        /// • Interrupt-gate descriptor.
        /// • Trap-gate descriptor.
        /// • Task-gate descriptor.
        /// </remarks>
        public bool IsTypeSystem => !S;
        
        public SystemSegmentTypeIn32BitMode SystemSegmentTypeIn32BitMode => (SystemSegmentTypeIn32BitMode) (Bytes[5] & 0x1fu);
        
        public SystemSegmentTypeInIa32Mode SystemSegmentTypeInIa32eMode => (SystemSegmentTypeInIa32Mode)(Bytes[5] & 0x1fu);
        
        public bool IsTssBusy
        {
            get => BinaryHelper.IsSet(SAndType, 1);
            set => BinaryHelper.Set(ref Bytes[5], value, 1);
        }
        
        public ushort GateSelector => BinaryHelper.FromBytes(Bytes[3], Bytes[2]);
        
        public uint InterruptOrTrapEip => BinaryHelper.FromBytes(Bytes[7], Bytes[6], Bytes[1], Bytes[0]);
        
        // for 32 Bit Mode
        public int get_system_segment_size => BinaryHelper.IsSet(Type, 3) ? 32 : 16;

        #endregion
    }
}