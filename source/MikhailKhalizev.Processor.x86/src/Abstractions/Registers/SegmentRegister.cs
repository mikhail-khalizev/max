namespace MikhailKhalizev.Processor.x86.Abstractions.Registers
{
    public abstract class SegmentRegister : Register
    {
        /// <inheritdoc />
        public override int Bits => 16;

        public ushort Selector
        {
            get => UInt16;
            set => UInt16 = value;
        }

        // todo move SegmentDescriptor logic inside SegmentRegister. Remove SegmentDescriptor class.

        /// <summary>
        /// Descriptor.
        /// </summary>
        /// <remarks>Hidden part of segment.</remarks>
        public SegmentDescriptor Descriptor { get; set; } = new SegmentDescriptor();

        /// <summary>
        /// Index multiplies by 8.
        /// </summary>
        /// <remarks>
        /// Selects one of 8192 descriptors in the GDT or LDT.
        /// The processor multiplies the index value by 8 (the number of bytes in a segment descriptor) and
        /// adds the result to the base address of the GDT or LDT(from the GDTR or LDTR register, respectively).
        /// </remarks>
        public uint IndexMul8 => (uint) Selector & 0xfff8;

        /// <summary>
        /// L (64-bit code segment) flag.
        /// </summary>
        public bool l => Descriptor.l;

        /// <summary>
        /// D (default operation size) flag.
        /// B (default stack pointer size and/or upper bound) flag.
        /// </summary>
        public bool db => Descriptor.db;

        /// <summary>
        /// TI (table indicator) flag.
        /// </summary>
        /// <remarks>
        /// Specifies the descriptor table to use: 
        /// 0 - GDT, 
        /// 1 - LDT.
        /// </remarks>
        public bool TI => (Selector & 0x0100) != 0;

        /// <summary>
        /// Requested Privilege Level (RPL).
        /// </summary>
        /// <remarks>
        /// Specifies the privilege level of the selector.
        /// The privilege level can range from 0 to 3, with 0 being the most privileged level.
        /// 0 = Highest privilege (OS),
        /// 3 = Lowest privilege (User applications).
        /// </remarks>
        public abstract uint RPL { get; set; }

        /// <summary>
        /// null segment selector.
        /// </summary>
        /// <remarks>
        /// The first entry of the GDT is not used by the processor. A segment selector that points to this entry of the GDT (that
        /// is, a segment selector with an index of 0 and the TI flag set to 0) is used as a “null segment selector.” The processor
        /// does not generate an exception when a segment register (other than the CS or SS registers) is loaded with a null
        /// selector.It does, however, generate an exception when a segment register holding a null selector is used to access
        /// memory. A null selector can be used to initialize unused segment registers.Loading the CS or SS register with a null
        /// segment selector causes a general-protection exception (#GP) to be generated.
        /// </remarks>
        public bool IsNull => Selector <= 0x3;
        
        // TODO Remove
        public void Load(int selector)
        {
            Selector = (ushort)selector;
            LoadDescriptor();
        }

        protected abstract void LoadDescriptor();

        // todo rename to CheckLimit, CheckAccess
        /// <summary>
        /// Return true if check fail.
        /// </summary>
        public bool fail_limit_check(Address address, int size = 1)
        {
            if (Descriptor.Limit < address + (size == 0 ? 0 : size - 1))
                return true;
            return false;
        }


        public void ResetCodeSegment()
        {
            Selector = 0xf000;
            Descriptor = new SegmentDescriptor();
            Descriptor.Base = 0xffff0000;
            Descriptor.Limit = 0xffff;
            Descriptor.Present = true;
            Descriptor.Type = 0b0111;
        }

        public void ResetDataSegment()
        {
            Selector = 0;
            Descriptor = new SegmentDescriptor();
            Descriptor.Base = 0;
            Descriptor.Limit = 0xffff;
            Descriptor.Present = true;
            Descriptor.Type = 0b0011;
        }

        public void ResetTaskRegisterSegment()
        {
            Selector = 0;
            Descriptor = new SegmentDescriptor();
            Descriptor.Base = 0;
            Descriptor.Limit = 0xffff;
            Descriptor.Present = true;
            Descriptor.Type = 0b011;
        }

        public static Address operator +(SegmentRegister segment, Address address)
        {
            return (segment?.Descriptor.Base ?? 0) + address;
        }

        public Address this[Address address] => Descriptor.Base + address;
    }
}